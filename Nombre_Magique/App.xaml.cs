using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Nombre_Magique.Views;

namespace Nombre_Magique

{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomePage());
            
        }

       

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
