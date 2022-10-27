using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nombre_Magique.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
            InfiniteRotation(star1,4000);
            InfiniteRotation(star2,5000);
            InfiniteRotation(star3,7000);
            InfiniteScale(playButton, 1000);
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
        }

        private async Task InfiniteRotation(View view, uint lenght)
        {
            while (true)
            {
                await view.RotateTo(360, lenght);
                view.Rotation = 0;
            }
            

        } 
        private async Task InfiniteScale(View view, uint lenght)
        {
            while (true)
            {
                await playButton.ScaleTo(1.1, lenght);
                await playButton.ScaleTo(1.0, (lenght)+500);
                
            }
            

        }
        private void PlayButton_Cliked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new GamePage());
        }
    }
}