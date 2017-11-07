using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Vaisseaux
{
    class Assault : Vaisseau, IAptitude
    {
        public Assault() : base("ASS-AULT", 15, 0, 0)
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

        public override void Equipe(Arme a)
        {
            throw new ArmurerieException("Can't equip shit");
        }

        public List<Vaisseau> Utilise(List<Vaisseau> listEnnemies)
        {
            if (EstDetruit())
                return listEnnemies;

            if (listEnnemies.IndexOf(this) == 0) {
                SpaceInvaders.Instance.allPlayers[0].vaisseau.Endommage(10);
                this.Endommage(15);
            }

            return listEnnemies;
        }
    }
}
