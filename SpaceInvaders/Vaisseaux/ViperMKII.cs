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

        public ViperMKII() : base("ViperMKII", 10, 15, 15)
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

            v.Endommage((int)(degats * coefCheat));
        }
    }
}
