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
            Equipe(Armurerie.Instance.getWeaponList().First((a) => a.nom == "L4Z3R"));
        }

        public override void Attaque(Vaisseau v)
        {
            int degats = 0;
            int bonus = 1;

            foreach (Arme a in this.armes)
            {
                if (a.instanceType == Arme.Type.Direct)
                    bonus = a.tempsRecharge;
                degats += a.Tir();
            }

            v.Endommage((int)(degats * coefCheat));
        }
    }
}
