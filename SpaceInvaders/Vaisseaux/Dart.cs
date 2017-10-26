using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Vaisseaux
{
    class Dart : Vaisseau
    {
        private double coefCheat = 1.1;

        public Dart() : base("Dart", 10, 3, 3)
        { 
            Equipe(Armurerie.Instance.getWeaponList()[0]);
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
