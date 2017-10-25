using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Joueur
    {
        private string nom;
        private string prenom;
        private string pseudo;

        public Joueur(string pNom, string pPrenom, string pPseudo)
        {
            nom = pNom;
            prenom = pPrenom;
            pseudo = pPseudo;
            formateName();
        }

        private void formateName()
        {
            nom = nom.ToLower();
            nom = nom.First().ToString().ToUpper() + nom.Substring(1, nom.Length-1);
            prenom = prenom.ToLower();
            prenom = prenom.First().ToString().ToUpper() + prenom.Substring(1, prenom.Length-1);
        }

        public override string ToString()
        {
            return (nom + " " + prenom);
        }

        public override bool Equals(Object obj)
        {
            if(obj is Joueur)
            {
                return ((Joueur)obj).pseudo == this.pseudo;
            }
            return false;
        }
        
    }
}
