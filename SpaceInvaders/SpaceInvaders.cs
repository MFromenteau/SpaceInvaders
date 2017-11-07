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
            AddEnnemyShip(new ViperMKII());
        }

        public void AddEnnemyShip(Vaisseau v)
        {
            if (v is IAptitude) {
                allAptEnnemies.Add((IAptitude)v);
            }
            allEnnemies.Add(v);
        }

        public int CountAlive(List<Vaisseau> lv)
        {
            int count = 0;

            foreach (Vaisseau v in lv) {
                if(!v.EstDetruit())
                    count++;
            }

            return count;
        }

        //main game 0 if continue, 1 if lose, 2 if win
        public int Tour()
        {
            //APTITUDE
            foreach (IAptitude ennemy in allAptEnnemies) {
                    ennemy.Utilise(allEnnemies);
            }

            //ded ?
            if (allPlayers[0].vaisseau.EstDetruit())
                return 1;

            //FIGHT
            int index = 0;
            Random rnd = new Random();

            foreach (Vaisseau v in allEnnemies) {
                index++;

                //do not treat already dead ship
                if (v.EstDetruit()) {
                    break;
                }
                
                //Who shoots first ?
                if (rnd.Next(0, 100) / 100 < index / CountAlive(allEnnemies)) 
                {
                    //player shoots first
                    allPlayers[0].vaisseau.Attaque(v);
                    v.Attaque(allPlayers[0].vaisseau);
                } else {
                    //ennemy shoots first
                    v.Attaque(allPlayers[0].vaisseau);
                    allPlayers[0].vaisseau.Attaque(v);
                }

                //ded ?
                if (allPlayers[0].vaisseau.EstDetruit())
                    return 1;
                
            }

            if (allEnnemies.Count() == 0)
                return 2;
            
            return 0;
        }
    }
}
