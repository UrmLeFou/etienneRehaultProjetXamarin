using ProjetXamarin.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjetXamarin.services
{
    class TwitterServiceImplements : ITwitterService
    {
        public bool authenticate(string utilisateur, string motDePasse)
        {
            if (utilisateur == "Bobby" && motDePasse == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ObservableCollection<Tweet> GetTweets()
        {
            return new ObservableCollection<Tweet>
            {
                new Tweet { Identifiant = "1", DateDeCreation = DateTime.Now.ToString(), Texte = "You really think you can fly that thing? Hey, take a look at the earthlings. Goodbye!", Utilisateur ="user1", IdentifiantUtilisateur="123456", PseudoUtilisateur="Bobby" },
                new Tweet { Identifiant = "2", DateDeCreation = DateTime.Now.ToString(), Texte = "What do they got in there? King Kong? My dad once told me, laugh and the world laughs with you, Cry, and I'll give you something to cry about you little bastard! ", Utilisateur = "user2", IdentifiantUtilisateur = "123456", PseudoUtilisateur = "JR" },
                new Tweet { Identifiant = "3", DateDeCreation = DateTime.Now.ToString(), Texte = "Life finds a way. Did he just throw my cat out of the window? They're using our own satellites against us.", Utilisateur = "user3", IdentifiantUtilisateur = "123456", PseudoUtilisateur = "SueEllen" }
            };
        }
    }
}
