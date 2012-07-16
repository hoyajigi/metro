using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237
//http://map.naver.com/?dlevel=12&lat=37.5596085&lng=126.9956299&slng=126.9936478&slat=37.5613757&elng=126.9881809&elat=37.5511791&eelng=126.9821418&eelat=37.5523581&pathType=1&dtPathType=0&menu=route&mapMode=0&sText=7ZWY64uI66eo7IWY&eText=TuyEnOyauO2DgOybjA%3D%3D&enc=b64
//http://map.naver.com/

//http://dev.naver.com/openapi/apis/map/javascript_2_0/reference#coordtrans
//http://dna.daum.net/apis/local/geo/addr2coord
//https://developers.google.com/maps/documentation/geocoding/?hl=ko


namespace Metro
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class AfterArrive : Metro.Common.LayoutAwarePage
    {
        public AfterArrive()
        {
            this.InitializeComponent();
            wv1.Navigate(new Uri("http://map.naver.com/?dlevel=12&lat=37.5596085&lng=126.9956299&slng=126.9936478&slat=37.5613757&elng=126.9881809&elat=37.5511791&eelng=126.9821418&eelat=37.5523581&pathType=1&dtPathType=0&menu=route&mapMode=0&sText=7ZWY64uI66eo7IWY&eText=TuyEnOyauO2DgOybjA%3D%3D&enc=b64"));
        }
        
        

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
