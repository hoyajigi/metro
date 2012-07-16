using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Data.Json;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using NotificationsExtensions.ToastContent;
using Windows.UI.Notifications;
using Windows.UI.Popups;
using System.Net.Http.Headers;

namespace Metro
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Geolocator _geolocator = null;
        private CancellationTokenSource _cts = null;
        DispatcherTimer t=new DispatcherTimer(){
            Interval=TimeSpan.FromSeconds(1)
        };

        public MainPage()
        {
            this.InitializeComponent();
            _geolocator = new Geolocator();
            t.Tick += toastf;
           // t.Start();
           
            
        }

        
        private void toastf(object sender, object e){

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
        private void toastf2()
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
            var date = DateTimeOffset.Now.AddSeconds(5);
            var stn = new ScheduledToastNotification(template, date);
            notifier.AddToSchedule(stn);
            toastf2();

        }

        //http://m.seoul.go.kr/traffic/SubInfoNearDetail.do?subSearch=2&station=220&upage=3&flag=3&sflag=1

        async private void GetTimeTables()
        {
            try	    {
      // Create a New HttpClient object.
      HttpClient client = new HttpClient();
      //Cache-Control: 
      client.DefaultRequestHeaders.Add("Cache-Control", "max-age=0");
      client.DefaultRequestHeaders.Add("Accept","text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
      client.DefaultRequestHeaders.Add("Accept-Language", "ko-KR,ko;q=0.8,en-US;q=0.6,en;q=0.4");
      client.DefaultRequestHeaders.Add("Accept-Charset", "windows-949,utf-8;q=0.7,*;q=0.3");
      client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/536.11 (KHTML, like Gecko) Chrome/20.0.1132.57 Safari/536.11");

      string body = await client.GetStringAsync(new Uri("http://m.seoul.go.kr/traffic/SubInfoNearDetail.do?subSearch=2&station=220&upage=3&flag=3&sflag=1", UriKind.RelativeOrAbsolute));
              
//      HttpResponseMessage response = await client.GetStringAsyncGetAsync("http://m.seoul.go.kr/traffic/SubInfoNearDetail.do?subSearch=2&station=220&upage=3&flag=3&sflag=1");
//      response.EnsureSuccessStatusCode();
//      string responseBody = await response.Content.ReadAsStringAsync();
      // Above three lines can be replaced with new helper method in following line
      // string body = await client.GetStringAsync(uri);
      //string body = await client.GetStringAsync("http://m.seoul.go.kr/traffic/SubInfoNearDetail.do?subSearch=2&station=220&upage=3&flag=3&sflag=1");
        //    string input=responseBody;
      string pattern = "<a href=\"(.+)\" class=\"lst_n\">(\\s*)<div class=\"p\">(\\s*)(.+)\\[(.+) 도착정보\\](.+)(\\s*)(.+)(\\s*)</div>";
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(body);
            //matche[6];
                if (matches.Count > 0) {
          //        Console.WriteLine("{0} ({1} matches):", input, matches.Count);
                  //foreach (Match match in matches){
                   //      Console.WriteLine("   " + match.Value);
                    Match match = matches[0];
                    way1.Text=match.Groups[5].ToString();
                      way1time1.Text = match.Groups[8].ToString();
                       match = matches[1];
                      way1time2.Text = match.Groups[8].ToString();
                       match = matches[2];
                      way2.Text = match.Groups[5].ToString();
                      way2time1.Text = match.Groups[8].ToString();
                      match = matches[3];
                      way2time2.Text = match.Groups[8].ToString();
                  //}
            }
    }  
    catch(HttpRequestException e)
    {
     // Console.WriteLine("\nException Caught!");	
     // Console.WriteLine("Message :{0} ",e.Message);
    }




        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached. The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
         //   GetGeolocationButton.IsEnabled = true;
         //   CancelGetGeolocationButton.IsEnabled = false;
            GetGeolocation();
            GetTimeTables();
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
            if (_cts != null)
            {
                _cts.Cancel();
                _cts = null;
            }

            base.OnNavigatingFrom(e);
        }


        /// <summary>
        /// This is the click handler for the 'getGeolocation' button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void GetGeolocation()
        {
           // GetGeolocationButton.IsEnabled = false;
           // CancelGetGeolocationButton.IsEnabled = true;

            try
            {
                // Get cancellation token
                _cts = new CancellationTokenSource();
                CancellationToken token = _cts.Token;

             //   rootPage.NotifyUser("Waiting for update...", NotifyType.StatusMessage);

                // Carry out the operation
                try
                {
                    Geoposition pos = await _geolocator.GetGeopositionAsync().AsTask(token);
               
             
              //  ScenarioOutput_Accuracy.Text = pos.Coordinate.Accuracy.ToString();

               HttpClient hc = new HttpClient();
               var res=await hc.GetAsync(new Uri("http://apis.daum.net/local/geo/coord2addr?apikey=200144fae82575a21821d764cfe7b3dc9de453d9&longitude=" + pos.Coordinate.Longitude.ToString() + "&latitude=" + pos.Coordinate.Latitude.ToString() + "&format=simple&output=json&inputCoordSystem=WGS84"));
               var st = await res.Content.ReadAsStringAsync();
               var s = JsonObject.Parse(st);
               start_address.Text = s["name1"].GetString() +" "+ s["name2"].GetString() +" "+ s["name3"].GetString();
               start_station.Text = "선릉역";
                }
                catch (Exception e)
                {
                }
            }
            catch (System.UnauthorizedAccessException)
            {
              /*  rootPage.NotifyUser("Disabled", NotifyType.StatusMessage);

                ScenarioOutput_Latitude.Text = "No data";
                ScenarioOutput_Longitude.Text = "No data";
                ScenarioOutput_Accuracy.Text = "No data";
            
               */
            }
            catch (TaskCanceledException)
            {
              //  rootPage.NotifyUser("Canceled", NotifyType.StatusMessage);
            }
            finally
            {
                _cts = null;
            }

//            GetGeolocationButton.IsEnabled = true;
//            CancelGetGeolocationButton.IsEnabled = false;
        }

        /// <summary>
        /// This is the click handler for the 'CancelGetGeolocation' button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelGetGeolocation(object sender, RoutedEventArgs e)
        {
            if (_cts != null)
            {
                _cts.Cancel();
                _cts = null;
            }

//            GetGeolocationButton.IsEnabled = true;
//            CancelGetGeolocationButton.IsEnabled = false;
        }

        private void End_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Select),"end");
        }
        private void Start_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AfterArrive), "start");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Move));
        }
    }
}
