using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nombre_Magique.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        const int nb_max = 2;
        const int nb_min = 1;
        int nb_magique = 0;
        public GamePage()
        {
            InitializeComponent();
            nb_magique = new Random().Next(nb_min,nb_max);
            valeur.Text = "Entre " + nb_min + " et " + nb_max;
            NavigationPage.SetHasNavigationBar(this, false);
        } 
        
        void Button_Clicked(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(numberEntry.Text))
            {
                DisplayAlert("Atention", "vous n'avez pas rentre de valeur correcte", "ok");
                return;
            }
            int nb_utilisateur = 0;
            try
            {
                nb_utilisateur = Int32.Parse(numberEntry.Text);
            }
            catch (Exception )
            {
                DisplayAlert("Atention", "vous n'avez pas rentre de valeur correcte", "ok");
                return;
            }
            if((nb_utilisateur < nb_min)||(nb_utilisateur > nb_max))
            {
                DisplayAlert("Atention", "Vous devez uniquement rentrez des chifre " + nb_min + " et " + nb_max,"ok");
                return;
            } 

            if(nb_magique > nb_utilisateur)
            {
                DisplayAlert("Oops", "le nombre magique est supérieur à " + nb_utilisateur,"Ok");
                return;
            }
            if(nb_magique < nb_utilisateur)
            {
                DisplayAlert("Oops", "le nombre magique est inférieur à " + nb_utilisateur, "Ok");
            }
            if(nb_magique == nb_utilisateur)
            {
#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
                WinAction();
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
                return;
            }
        }
        private async Task WinAction()
        {
            //await DisplayAlert("Gagné", "le nombre magique est bien  " , "Ok");
            await Navigation.PushAsync(new WinPage(nb_magique));
        }
    }
}