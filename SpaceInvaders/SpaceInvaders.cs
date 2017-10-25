using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class SpaceInvaders
    {

        public SpaceInvaders()
        {
            init();
        }

        void main()
        {
            SpaceInvaders si = new SpaceInvaders();

        }

        private void init()
        {
            Joueur player1 = new Joueur("aa", "aaa", "aaaa");
            Joueur player2 = new Joueur("bb", "bbb", "bbbb");
            Joueur player3 = new Joueur("cc", "ccc", "cccc");
        }
    }
}
