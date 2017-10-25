using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class SpaceInvaders
    {

        public static List<Joueur> allPlayers = new List<Joueur>();

        public SpaceInvaders()
        {
            Init();
        }

        public static void Main(string[] args)
        {
            SpaceInvaders G_Joueur = new SpaceInvaders();
            Armurerie G_Arme = new Armurerie();
            allPlayers.ForEach(Print);
            Console.ReadKey();
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
    }
}
