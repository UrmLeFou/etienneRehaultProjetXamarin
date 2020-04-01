using ProjetXamarin.models;
using System;
using System.Collections.Generic;
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

        public List<Tweet> GetTweets()
        {
            return new List<Tweet>
            {
                new Tweet { Identifiant = "1", DateDeCreation = DateTime.Now.ToString(), Texte = "Contenu du 1er tweet", Utilisateur ="user1", IdentifiantUtilisateur="123456", PseudoUtilisateur="Bobby" },
                new Tweet { Identifiant = "2", DateDeCreation = DateTime.Now.ToString(), Texte = "Contenu du 2e tweet", Utilisateur = "user2", IdentifiantUtilisateur = "123456", PseudoUtilisateur = "JR" },
                new Tweet { Identifiant = "3", DateDeCreation = DateTime.Now.ToString(), Texte = "Contenu du 3e tweet", Utilisateur = "user3", IdentifiantUtilisateur = "123456", PseudoUtilisateur = "SueEllen" }
            };
        }
    }
}
