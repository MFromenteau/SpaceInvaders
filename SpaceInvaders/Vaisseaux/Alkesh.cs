using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Vaisseaux
{
    class Alkesh : Vaisseau
    {
        private double coefCheat = 0.9;

        public Alkesh(string nom, int ptStructMax, int ptBouclier, int ptBouclierMax) : base(nom, ptStructMax, ptBouclier, ptBouclierMax)
        {
        }

        public override void Attaque(Vaisseau v)
        {
            Random rand = new Random();
            int degats = 0;

            foreach (Arme a in this.armes) {
                degats += rand.Next(a.damageMin, a.damageMax);
            }

            v.Endommage((int)(degats *coefCheat));
        }
    }
}
