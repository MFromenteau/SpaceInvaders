using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Vaisseaux
{
    class Tardis : Vaisseau, IAptitude
    {
        public Tardis() : base("(re)Tardis", 1, 0, 0)
        {
        }

        public override void Attaque(Vaisseau v)
        {
            int degats = 0;

            foreach (Arme a in this.armes) {
                degats += a.Tir();
            }

            v.Endommage((int)(degats));
        }

        List<Vaisseau> IAptitude.Utilise(List<Vaisseau> listVaisseau)
        {
            if (EstDetruit())
                return listVaisseau;

            Random rnd = new Random();
            int v1 = rnd.Next(0, listVaisseau.Count());
            int v2 = rnd.Next(0, listVaisseau.Count());

            Vaisseau tmp = listVaisseau[v1];
            listVaisseau[v1] = listVaisseau[v2];
            listVaisseau[v2] = tmp;

            return listVaisseau;
        }
    }
}
