using System.ComponentModel;
using Android.Content;
using Mobile.App.Android.Renderers;
using Mobile.App.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLocalPDFView), typeof(CustomLocalPDFRenderer))]

namespace Mobile.App.Android.Renderers
{
    public class CustomLocalPDFRenderer : WebViewRenderer
    {
        public CustomLocalPDFRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomLocalPDFView;
                Control.Settings.AllowUniversalAccessFromFileURLs = true;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            var customWebView = sender as CustomLocalPDFView;
            if (Control != null)
            {
                Control.Settings.BuiltInZoomControls = true;
                Control.Settings.DisplayZoomControls = true;
            }
            if (e.PropertyName == "Uri")
            {
                Control.LoadUrl(string.Format("file:///android_asset/pdfjs/web/viewer.html?file={0}", customWebView.Uri));
            }
        }
    }
}