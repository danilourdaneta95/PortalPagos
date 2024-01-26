using System.ComponentModel;
using Android.Content;
using Mobile.App.Android.Renderers;
using Mobile.App.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace Mobile.App.Android.Renderers
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        private readonly string DriveUrl = "http://www.africau.edu/";
        public CustomWebViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomWebView;
                Control.Settings.AllowUniversalAccessFromFileURLs = true;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            var customWebView = sender as CustomWebView;
            if (e.PropertyName == "Uri")
            {
                Control.LoadUrl(DriveUrl + customWebView.Uri);
            }
        }
    }
}