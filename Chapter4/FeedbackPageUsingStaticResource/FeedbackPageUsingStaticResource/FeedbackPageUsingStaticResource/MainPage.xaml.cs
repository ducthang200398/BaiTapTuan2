using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FeedbackPageUsingStaticResource
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
        
            InitializeComponent();
            Feedback.Text = (string)Resources["FeedbackPlaceholder"];
            Feedback.TextColor = (Color)Resources["InputPlaceholderColor"];

        }
        void HandleFeedback(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var placeHolderText = (string)Resources["FeedbackPlaceholder"];
            if (Feedback.Text == placeHolderText) { Feedback.Text = string.Empty; Feedback.TextColor = (Color)Resources["InputTextColor"]; return; }
            if (Feedback.Text == string.Empty) { Feedback.Text = placeHolderText; Feedback.TextColor = (Color)Resources["InputPlaceholder Color"]; return; }
        }
    }
}
