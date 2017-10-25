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
            SpaceInvaders si = new SpaceInvaders();
            allPlayers.ForEach(Print);
            Console.ReadKey();
        }

        private void Init()
        {
            allPlayers.Add(new Joueur("aa", "aaa", "aaaa"));
            allPlayers.Add(new Joueur("bb", "bbb", "bbbb"));
            allPlayers.Add(new Joueur("cc", "ccc", "cccc"));
        }

        private static void Print(Joueur player)
        {
            Console.WriteLine(player);
        }
    }
}
