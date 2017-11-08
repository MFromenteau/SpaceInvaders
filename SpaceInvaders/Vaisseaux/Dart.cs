using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Vaisseaux
{
    class Dart : Vaisseau
    {

        public Dart() : base("Dart", 10, 3, 3)
        { 
            Equipe(Armurerie.Instance.getWeaponList().First(a => a.nom == "L4Z3R"));
        }

        public override void Attaque(Vaisseau v)
        {
            if (EstDetruit())
                return;

            int degats = 0;
            double bonus = 1;
     
            foreach (Arme a in this.armes)
            {
                if (a.instanceType == Arme.Type.Direct)
                    bonus = (int)a.tempsRecharge;
                degats += a.Tir();
            }
            Console.WriteLine(this + (" -" + degats + "-> ").PadRight(7, ' ') + v);

            v.Endommage((int)(degats));
        }
    }
}
