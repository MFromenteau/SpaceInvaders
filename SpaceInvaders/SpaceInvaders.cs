using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class SpaceInvaders
    {

        public List<Joueur> allPlayers = new List<Joueur>();

        public SpaceInvaders()
        {
            Init();
        }

        private void Init()
        {
            allPlayers.Add(new Joueur("John", "Doe", "Raph"));
            allPlayers.Add(new Joueur("Eddie", "Tekken", "Edd"));
            allPlayers.Add(new Joueur("Charles", "Muntz", "Lerasch"));
        }

        private static void Print(Joueur player)
        {
            Console.WriteLine(player);
        }


        
        public static void Main(string[] args)
        {
            SpaceInvaders G_Joueur = new SpaceInvaders();
            Armurerie G_Arme = Armurerie.Instance;
            G_Joueur.allPlayers.ForEach(Print);
            G_Arme.displayAllWeapon();


            Console.WriteLine(G_Joueur.allPlayers[0].vaisseau);
            G_Joueur.allPlayers[0].vaisseau.PrintListeDArme();
            G_Joueur.allPlayers[0].vaisseau.PrintDegatsMoyen();

            try
            {
                G_Joueur.allPlayers[0].vaisseau.Equipe(G_Arme.getWeaponList()[0]);
            }
            catch (ArmurerieException ex)
            {
                throw ex;
            }
            
            Console.WriteLine(G_Joueur.allPlayers[0].vaisseau);
            G_Joueur.allPlayers[0].vaisseau.PrintListeDArme();
            G_Joueur.allPlayers[0].vaisseau.PrintDegatsMoyen();


        }
    }
}
