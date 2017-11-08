using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Vaisseaux
{
    class Slavel : Vaisseau
    {

        public Slavel() : base("Slavel",30 , 0 , 0)
        {
            Equipe(Armurerie.Instance.getWeaponList().First((a) => a.nom == "B0MB3"));
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
