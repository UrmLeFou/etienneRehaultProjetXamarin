using ProjetXamarin.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjetXamarin.services
{
    interface ITwitterService
    {
        bool authenticate(string utilisateur, string motDePasse);
        ObservableCollection<Tweet> GetTweets();

    }
}
