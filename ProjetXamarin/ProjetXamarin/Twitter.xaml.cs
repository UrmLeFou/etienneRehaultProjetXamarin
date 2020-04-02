using ProjetXamarin.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Twitter : ContentPage
    {
        private ITwitterService twitterService = new TwitterServiceImplements();
        public Twitter()
        {
            InitializeComponent();
            this.listeTweets.ItemsSource = twitterService.GetTweets();
        }
    }
}