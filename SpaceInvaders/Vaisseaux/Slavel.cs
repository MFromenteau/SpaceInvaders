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
<<<<<<< HEAD
            Equipe(Armurerie.Instance.getWeaponList()[1]);
=======

>>>>>>> master
        }

        public override void Attaque(Vaisseau v)
        {
            int degats = 0;

            foreach (Arme a in this.armes)
            {
                degats += a.Tir();
            }

            v.Endommage((int)(degats * coefCheat));
        }
    }
}
