using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using CostMatrix;
using CostMatrix.iOS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Foundation;



[assembly: ExportRenderer(typeof(MyEntry), typeof(CustomEntry))]
namespace CostMatrix.iOS
{
    public class CustomEntry : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}