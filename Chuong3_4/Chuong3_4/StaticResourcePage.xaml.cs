using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chuong3_4
{
    public partial class StaticResourcesPage : ContentPage
    {
        void HandleFeedback(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var placeHolderText = (string)Resources["FeedbackPlaceholder"];
            if (Feedback.Text == placeHolderText)
            {
                Feedback.Text = string.Empty;
                Feedback.TextColor = (Color)Resources["InputTextColor"];
                return;
            }
            if (Feedback.Text == string.Empty)
            {
                Feedback.Text = placeHolderText;
                Feedback.TextColor = (Color)Resources["InputPlaceholder
               Color"];
            return;
            }
        }
    }
}