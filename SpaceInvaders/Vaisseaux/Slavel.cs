using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Vaisseaux
{
    class Slavel : Vaisseau
    {
        private double coefCheat = 1;

        public Slavel() : base("Slavel",30 , 0 , 0)
        {

        }

        public override void Attaque(Vaisseau v)
        {
            Random rand = new Random();
            int degats = 0;

            foreach (Arme a in this.armes) {
                degats += rand.Next(a.damageMin, a.damageMax);
            }

            v.Endommage((int)(degats * coefCheat));
        }
    }
}
