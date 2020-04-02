using ProjetXamarin.models;
using ProjetXamarin.services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProjetXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService = new TwitterServiceImplements();
        public MainPage()
        {
            InitializeComponent();
            this.connectedButton.Clicked += Connection_Clicked;
            this.cacherErreur();
        }

        private async void Connection_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("bouton cliqué");

            Console.WriteLine(this.identifiant.Text);
            Console.WriteLine(this.motDePasse.Text);
            Console.WriteLine(this.memorisation.IsToggled);

            bool verification = true;
            string message = null;
            var current = Connectivity.NetworkAccess;
            
            if (this.identifiant.Text == null || string.IsNullOrWhiteSpace(this.identifiant.Text.ToString()) || this.identifiant.Text.ToString().Length < 3)
            {
                message = "L'identifiant doit avoir au moins 3 caractères";
                verification = false;
            }
            else if (this.motDePasse.Text == null || string.IsNullOrWhiteSpace(this.motDePasse.Text.ToString()) || this.motDePasse.Text.ToString().Length < 6)
            {
                message = "Le mot de passe doit avoir au moins 6 caractères";
                verification = false;
            }
            else if (!twitterService.authenticate(this.identifiant.Text, this.motDePasse.Text))
            {
                message = "L'utilisateur n'est pas enregistré ou le mot de passe est invalide";
                verification = false;
            }
            else if (current != NetworkAccess.Internet)
            {
                message = "Veuillez vous connectez à internet";
                verification = false;
            }

            if (verification)
            {
                await Navigation.PushAsync(new Twitter());
            }
            else
            {
                afficherErreur(message);
                return;
            }
        }

        private void cacherErreur()
        {
            this.erreur.IsVisible = false;
        }

        private void afficherErreur(string message)
        {
            this.erreur.IsVisible = true;
            this.erreur.Text = message;
        }
    }
}
