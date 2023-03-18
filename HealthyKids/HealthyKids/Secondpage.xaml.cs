using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthyKids
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Secondpage : ContentPage
    {
        public Secondpage()
        {
            InitializeComponent();
        }
        public void BackClicked(object sender, EventArgs args)
        {
            App.Current.MainPage = new MainPage();
        }

        public void MLSClicked(object sender, EventArgs args)
        {
            App.Current.MainPage = new thrdpage();
            Console.WriteLine("thrd page Clicked");
        }

        public void DRKClicked(object sender, EventArgs args)
        {
            App.Current.MainPage = new thrdpage();
            Console.WriteLine("thrd page Clicked");
        }
    }
}