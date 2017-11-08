using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.Vaisseaux;

namespace SpaceInvaders
{
    class SpaceInvaders
    {

        public List<Joueur> allPlayers { get; private set; } = new List<Joueur>();
        public List<Vaisseau> allEnnemies { get; private set; } = new List<Vaisseau>();
        public List<IAptitude> allAptEnnemies { get; private set; } = new List<IAptitude>();
        private static readonly Lazy<SpaceInvaders> lazy = new Lazy<SpaceInvaders>(() => new SpaceInvaders());
        public static SpaceInvaders Instance { get { return lazy.Value; } }

        public SpaceInvaders()
        {
            Init();
        }

        private void Init()
        {
            allPlayers.Add(new Joueur("John", "Doe", "Raph"));
            AddEnnemyShip(new Slavel());
            AddEnnemyShip(new Tardis());
            AddEnnemyShip(new Dart());
            AddEnnemyShip(new Assault());
            AddEnnemyShip(new Alkesh());
        }

        public void AddEnnemyShip(Vaisseau v)
        {
            if (v is IAptitude) {
                allAptEnnemies.Add((IAptitude)v);
            }
            allEnnemies.Add(v);
        }

        static public int CountAlive(List<Vaisseau> lv)
        {
            int count = 0;

            foreach (Vaisseau v in lv) {
                if (!v.EstDetruit()) {
                    count++;
                }
            }

            return count;
        }

        static public int CountExplicitAlive(List<Vaisseau> lv)
        {
            int count = 0;

            foreach (Vaisseau v in lv) {
                if (!v.EstDetruit()) {
                    Console.WriteLine(v + "NOTDEAD SO +1");
                    count++;
                } else {

                    Console.WriteLine(v + "DEAD SO NOTHING");
                }
            }

            return count;
        }

        public int t = 0;
        //main game 0 if continue, 1 if lose, 2 if win
        public int Tour()
        {
            t++;
            Console.WriteLine("\n### Tour " + t + " : \n");
            //Console.ReadLine();
            int[] order = new int[allEnnemies.Count];

            //APTITUDE
            foreach (IAptitude ennemy in allAptEnnemies) {
                if ( !((Vaisseau)ennemy).EstDetruit() ) {
                    Console.WriteLine(ennemy + " : Specility used");
                    ennemy.Utilise(allEnnemies);
                }
            }
            
            //FIGHT
            int index = 0;
            Random rnd = new Random();

            foreach (Vaisseau v in allEnnemies) {
                index++;

                //do not treat already dead ship
                if (v.EstDetruit()) {
                    order[index - 1] = 0;
                } else {
                    Console.WriteLine();
                    //Who shoots first ?
                    if ((rnd.Next(0, 100)* CountAlive(this.allEnnemies) / index) / 100 < CountAlive(this.allEnnemies)/ index) {
                        order[index - 1] = 1;
                        //player shoots first
                        allPlayers[0].vaisseau.Attaque(v);
                        v.Attaque(allPlayers[0].vaisseau);
                    } else {
                        order[index - 1] = 2;
                        //ennemy shoots first
                        v.Attaque(allPlayers[0].vaisseau);
                        allPlayers[0].vaisseau.Attaque(v);
                    }

                    // "vaisseau dead ?"
                    if (v.EstDetruit()) {
                        order[index - 1]+= 2;
                    }
                    //player ded ?
                    if (allPlayers[0].vaisseau.EstDetruit())
                        order[index - 1] = 10;
                }
            }

            Console.Write("\nPlayer :" + allPlayers[0].vaisseau + "\n|V|-|");
            for (int i = 0; i < order.Length; i++) {
                int o = order[i];
                if (o == 1)
                    Console.Write("-->" + allEnnemies[i].SmallDesc() + "|");
                else if (o == 3)
                    Console.Write("-X>" + allEnnemies[i].SmallDesc() + "|");
                else if (o == 2)
                    Console.Write("<--" + allEnnemies[i].SmallDesc() + "|");
                else if (o == 4)
                    Console.Write("<X-" + allEnnemies[i].SmallDesc() + "|");
                else if (o == 0)
                    Console.Write("X" + allEnnemies[i].SmallDesc() + "X|");
                else if (o == 10)
                    Console.Write("K" + allEnnemies[i].SmallDesc() + "K|");
            }
            Console.WriteLine();
            Console.WriteLine("\nAlives : " + CountAlive(allEnnemies));

            if (CountAlive(this.allEnnemies) == 0)
                return 2;

            if (allPlayers[0].vaisseau.EstDetruit())
                return 1;

            return 0;
        }
    }
}
