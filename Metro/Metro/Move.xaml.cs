using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237
using NotificationsExtensions.ToastContent;
using Windows.UI.Notifications;
using Windows.UI.Popups;

namespace Metro
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Move : Metro.Common.LayoutAwarePage
    {
        private Geolocator _geolocator = null;
/*        DispatcherTimer toastTimer = new DispatcherTimer()
        {
            Interval = TimeSpan.FromSeconds(10)
        };*/
        DispatcherTimer mapTimer = new DispatcherTimer()
        {
            Interval = TimeSpan.FromSeconds(15)
        };
        public Move()
        {
            this.InitializeComponent();
            _geolocator = new Geolocator();
            _geolocator.PositionChanged -= new TypedEventHandler<Geolocator, PositionChangedEventArgs>(OnPositionChanged);
//            _geolocator.StatusChanged -= new TypedEventHandler<Geolocator, StatusChangedEventArgs>(OnStatusChanged);
           this.Loaded+=Move_Loaded;
           //t.Tick += toastf;
            // t.Start();
           //toastTimer.Tick += Move_AboutToComplete;
           toastf();
           mapTimer.Tick += Move_Complete;
           mapTimer.Start();
        }

        private void Move_Complete(object sender, object e)
        {
            this.Frame.Navigate(typeof(AfterArrive));
        }

        private void Move_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard1.Begin();
        }

        
        private void toastf()
        {
            var notifier = ToastNotificationManager.CreateToastNotifier();

            // Make sure notifications are enabled
            if (notifier.Setting != NotificationSetting.Enabled)
            {
                var dialog = new MessageDialog("Notifications are currently disabled");
                dialog.ShowAsync();
                return;
            }

            // Get a toast template and insert a text node containing a message
            var template = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText01);
            var element = template.GetElementsByTagName("text")[0];
            element.AppendChild(template.CreateTextNode("Reminder!"));

            // Schedule the toast to appear 30 seconds from now
            var date = DateTimeOffset.Now.AddSeconds(10);
            var stn = new ScheduledToastNotification(template, date);
            notifier.AddToSchedule(stn);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached. The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           // StartTrackingButton.IsEnabled = true;
           // StopTrackingButton.IsEnabled = false;
        }

        /// <summary>
        /// Invoked immediately before the Page is unloaded and is no longer the current source of a parent Frame.
        /// </summary>
        /// <param name="e">
        /// Event data that can be examined by overriding code. The event data is representative
        /// of the navigation that will unload the current Page unless canceled. The
        /// navigation can potentially be canceled by setting e.Cancel to true.
        /// </param>
        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            //if (StopTrackingButton.IsEnabled)
            //{
                _geolocator.PositionChanged -= new TypedEventHandler<Geolocator, PositionChangedEventArgs>(OnPositionChanged);
            //    _geolocator.StatusChanged -= new TypedEventHandler<Geolocator, StatusChangedEventArgs>(OnStatusChanged);
            //}

            base.OnNavigatingFrom(e);
        }

        /// <summary>
        /// This is the event handler for PositionChanged events.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void OnPositionChanged(Geolocator sender, PositionChangedEventArgs e)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Geoposition pos = e.Position;

                //rootPage.NotifyUser("Updated", NotifyType.StatusMessage);

               // pos.Coordinate.Latitude.ToString();
                // pos.Coordinate.Longitude.ToString();
                // pos.Coordinate.Accuracy.ToString();
            });
        }

        /// <summary>
        /// This is the event handler for StatusChanged events.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*
        async private void OnStatusChanged(Geolocator sender, StatusChangedEventArgs e)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                switch (e.Status)
                {
                    case PositionStatus.Ready:
                        ScenarioOutput_Status.Text = "Ready";
                        break;

                    case PositionStatus.Initializing:
                        ScenarioOutput_Status.Text = "Initializing";
                        break;

                    case PositionStatus.NoData:
                        ScenarioOutput_Status.Text = "No data";
                        break;

                    case PositionStatus.Disabled:
                        ScenarioOutput_Status.Text = "Disabled";

                        //Clear cached location data if any
                        ScenarioOutput_Latitude.Text = "No data";
                        ScenarioOutput_Longitude.Text = "No data";
                        ScenarioOutput_Accuracy.Text = "No data";
                        break;

                    case PositionStatus.NotInitialized:
                        ScenarioOutput_Status.Text = "Not initialized";
                        break;

                    case PositionStatus.NotAvailable:
                        ScenarioOutput_Status.Text = "Not available";
                        break;

                    default:
                        ScenarioOutput_Status.Text = "Unknown";
                        break;
                }
            });
        }
        */

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }
    }
}
