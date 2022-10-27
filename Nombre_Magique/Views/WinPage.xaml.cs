using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nombre_Magique.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinPage : ContentPage
    {
        public WinPage(int nbMagique)
        {
            InitializeComponent();
            nbMagiqueWinPage.Text = "Le nombre magique était : "+ nbMagique;
            NavigateToWelcomePage();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async Task NavigateToWelcomePage()
        {
            await Task.Delay(3000);
            await Navigation.PopToRootAsync();  

        }
    }
}