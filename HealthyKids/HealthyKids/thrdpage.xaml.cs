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
    public partial class thrdpage : ContentPage
    {
        public thrdpage()
        {
            InitializeComponent();
        }
        public void BackoClicked(object sender, EventArgs args)
        {
            App.Current.MainPage = new Secondpage();
        }

        public void rosCliced(object sender, EventArgs args)
        {
            App.Current.MainPage = new Page1();
            Console.WriteLine("second page Clicked");
        }
    }
}