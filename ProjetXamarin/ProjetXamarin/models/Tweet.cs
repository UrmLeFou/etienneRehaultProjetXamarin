using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetXamarin.models
{
    class Tweet
    {
        private string identifiant;
        private string dateDeCreation;
        private string texte;
        private string utilisateur;
        private string identifiantUtilisateur;
        private string pseudoUtilisateur;

        public string Identifiant { get => identifiant; set => identifiant = value; }
        public string DateDeCreation { get => dateDeCreation; set => dateDeCreation = value; }
        public string Texte { get => texte; set => texte = value; }
        public string Utilisateur { get => utilisateur; set => utilisateur = value; }
        public string IdentifiantUtilisateur { get => identifiantUtilisateur; set => identifiantUtilisateur = value; }
        public string PseudoUtilisateur { get => pseudoUtilisateur; set => pseudoUtilisateur = value; }
    }
}
