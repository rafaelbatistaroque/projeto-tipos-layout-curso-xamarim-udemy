using System;
using System.ComponentModel;
using TiposLayout.Layouts.Absolute;
using TiposLayout.Layouts.Grid;
using TiposLayout.Layouts.Relative;
using TiposLayout.Layouts.Scroll;
using TiposLayout.Layouts.Stack;
using Xamarin.Forms;

namespace TiposLayout
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void IrAbsolute(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsolutePage());
        }
        private void IrGrid(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }
        private void IrRelative(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativePage());
        }
        private void IrScroll(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollPage());
        }
        private void IrStack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackPage());
        }
    }
}
