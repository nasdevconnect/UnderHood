using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace UnderHood.Droid
{
    public class Global
    {
        public static Global I = new Global();
        public FormsAppCompatActivity MainActivity { get; set; }
    }
}