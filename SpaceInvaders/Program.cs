using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public static class Program
    {
        private static void Print(Joueur player)
        {
            Console.WriteLine(player);
        }

        public static void Main(string[] args)
        {
            SpaceInvaders G_Joueur = SpaceInvaders.Instance;
            Armurerie G_Arme = Armurerie.Instance;
            G_Joueur.allPlayers.ForEach(Print);
            G_Arme.displayAllWeapon();


            Console.WriteLine(G_Joueur.allPlayers[0].vaisseau);
            G_Joueur.allPlayers[0].vaisseau.PrintListeDArme();
            G_Joueur.allPlayers[0].vaisseau.PrintDegatsMoyen();

            try {
                G_Joueur.allPlayers[0].vaisseau.Equipe(G_Arme.getWeaponList()[0]);
            } catch (ArmurerieException ex) {
                throw ex;
            }

            Console.WriteLine(G_Joueur.allPlayers[0].vaisseau);
            G_Joueur.allPlayers[0].vaisseau.PrintListeDArme();
            G_Joueur.allPlayers[0].vaisseau.PrintDegatsMoyen();

            int res = 0;
            while ((res = G_Joueur.Tour()) == 0) ;
            
            Console.WriteLine("You" + ((res == 1) ? "Lost." : "Won !!"));
        }
    }
}
