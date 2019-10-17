using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RelativeLayout
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Label below = new Label { Text = "Below Upper Left", FontSize = 15 };
            LayoutContainer.Children.Add(below, Constraint.Constant(0),
            Constraint.RelativeToView(UpperLeft, (parent, sibling) =>
            { return sibling.Y + sibling.Height; }));

        }
    }
}
