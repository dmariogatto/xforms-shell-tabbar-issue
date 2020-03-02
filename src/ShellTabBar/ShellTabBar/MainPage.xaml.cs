using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ShellTabBar
{
    [Preserve(AllMembers = true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public string TabName 
        { 
            get => NameLabel.Text;
            set => NameLabel.Text = value;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ((Shell)Application.Current.MainPage).GoToAsync($"{TabName}/modal");
        }
    }
}
