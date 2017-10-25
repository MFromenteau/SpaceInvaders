using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Arme
    {
        

        public string nom { get; }
        public int damageMin { get; }
        public int damageMax { get; }
        public enum Type { Direct, Explosif, Guidé };
        public Type instanceType { get; }

        public Arme(string nom, int damageMin, int damageMax, Type instanceType)
        {
            this.nom = nom;
            this.damageMin = damageMin;
            this.damageMax = damageMax;
            this.instanceType = instanceType;
        }

        public override string ToString()
        {
            return nom+ " ("+damageMin+","+damageMax+") "+instanceType;
        }
    }
}
