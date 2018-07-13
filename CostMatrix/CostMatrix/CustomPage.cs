using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CostMatrix 
{
    public class CustomPage : ContentPage
    {
        public CustomPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Hello, Custom Renderer !",
                    },
                    new MyEntry {
                        Text = "In Shared Code",
                    }
                },
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
        }

    }
}
