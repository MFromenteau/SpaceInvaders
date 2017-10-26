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

        public Alkesh() : base("Alkesh", 3, 5, 5)
        {
            Arme newWeapon = Armurerie.Instance.getWeaponList()[2];
            newWeapon.SetTempsRecharge(1);
            Equipe(newWeapon);
            
        }

        

        public override void Attaque(Vaisseau v)
        {
            int degats = 0;

            foreach (Arme a in this.armes)
            {
                degats += a.Tir();
            }

            v.Endommage((int)(degats *coefCheat));
        }
    }
}
