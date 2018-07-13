using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CostMatrix;
//using CostMatrix.Droid;
using CostMatrix.Android;
using Android.Content;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
//using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


[assembly: ExportRenderer(typeof(MyEntry), typeof(CustomEntry))]
namespace CostMatrix.Android
{
    public class CustomEntry : EntryRenderer
    {

        public CustomEntry(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}