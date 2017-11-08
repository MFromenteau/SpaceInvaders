using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Vaisseaux
{
    class Alkesh : Vaisseau
    {
        public Alkesh() : base("Alkesh", 3, 5, 5)
        {
            Equipe(Armurerie.Instance.getWeaponList().First((a) =>  a.nom == "Torpille"));
        }

        

        public override void Attaque(Vaisseau v)
        {
            
            if (EstDetruit())
                return;

            int degats = 0;

            foreach (Arme a in this.armes)
            {
                degats += a.Tir();
            }

            Console.WriteLine(this + (" -" + degats + "-> ").PadRight(7, ' ') + v);

            v.Endommage((int)(degats));
        }
    }
}
