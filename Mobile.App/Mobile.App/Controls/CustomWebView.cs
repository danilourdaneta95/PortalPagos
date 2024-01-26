﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mobile.App.Controls
{
    public class CustomWebView: WebView
    {
        public static readonly BindableProperty UriProperty = BindableProperty.Create(propertyName: "Uri",
               returnType: typeof(string),
               declaringType: typeof(CustomWebView),
               defaultValue: default(string));

        public string Uri
        {
            get { return (string)GetValue(UriProperty); }
            set { SetValue(UriProperty, value); }
        }

        public static readonly BindableProperty IsPdfProperty = BindableProperty.Create(propertyName: "IsPdf",
        returnType: typeof(bool),
        declaringType: typeof(CustomWebView),
        defaultValue: default(bool));
    }
}
