using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealthyKids
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Eatclicked(object sender, EventArgs args)
        {
            App.Current.MainPage = new Secondpage();
            Console.WriteLine("second page Clicked");
        }
    }
}
