using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Vaisseaux
{
    class ViperMKII : Vaisseau
    {
        private double coefCheat = 1.5 ;

        public ViperMKII(string nom, int ptStructMax, int ptBouclier, int ptBouclierMax) : base(nom, ptStructMax, ptBouclier, ptBouclierMax)
        {
        }

        public override void Attaque(Vaisseau v)
        {
            int degats = 0;

            foreach (Arme a in this.armes) {
                degats += a.Tir();
            }

            v.Endommage((int)(degats * coefCheat));
        }
    }
}
