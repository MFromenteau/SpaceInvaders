using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Vaisseaux
{
    class ViperMKII : Vaisseau
    {
        public ViperMKII() : base("ViperMKII", 20, 15, 15)
        {
            Equipe(Armurerie.Instance.getWeaponList().First(a => a.nom == "Mitrailleuse"));
            Equipe(Armurerie.Instance.getWeaponList().First(a => a.nom == "EMG"));
            Equipe(Armurerie.Instance.getWeaponList().First(a => a.nom == "Missile"));
        }

        public override void Attaque(Vaisseau v)
        {
            if (EstDetruit())
                return;

            int degats = 0;

            //foreach (Arme a in this.armes) {
            //    degats += a.Tir();
            //}

            // TP 2 Q 2.D Viper ne peut tirer qu'avec une seule arme à la fois on va donc 
            // choisir aléatoirement une arme dans la liste pour tirer
            Random rnd = new Random();

            degats = armes[rnd.Next(armes.Count)].Tir();

            Console.WriteLine(this + (" -" + degats + "-> ").PadRight(7, ' ') + v);

            v.Endommage((int)(degats));
        }

        public override string ToString()
        {
            if (EstDetruit())
                return (("V[" + this.nom).PadRight(15, ' ') + "] : DESTROYED").PadRight(40, ' ');

            return (("[" + this.nom).PadRight(11, ' ') + "]:H" + (this.ptStruct + "/" + this.ptStructMax).PadRight(5, ' ') + "||B" + (this.ptBouclier + "/" + this.ptBouclierMax).PadRight(5, ' ')).PadRight(40, ' ');
        }
    }
}
