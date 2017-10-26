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
        public int tempsRecharge { get; }
        public int nbTours { get; set; }

        public Arme(string nom, int damageMin, int damageMax, Type instanceType, int tempsR)
        {
            this.nom = nom;
            this.damageMin = damageMin;
            this.damageMax = damageMax;
            this.instanceType = instanceType;
            tempsRecharge = tempsR;
            nbTours = tempsRecharge;
        }

        public override string ToString()
        {
            return nom+ " ("+damageMin+","+damageMax+") "+instanceType;
        }

        public void DecrementeUnTour()
        {
            nbTours -= 1;
        }

        public int Tir()
        {
            DecrementeUnTour();
            if (nbTours > 0)
            {
                return 0;
            }
            Random rand = new Random();
            switch (instanceType)
            {
                case Type.Direct:
                    if (rand.Next(0, 40) < 10)
                        return 0;
                    break;
                case Type.Explosif:
                    if (rand.Next(0, 40) < 10)
                        return 0;
                    break;
                case Type.Guidé:
                    return damageMin;
                default:
                    break;
            }
            return rand.Next(damageMin, damageMax);
        }
    }
}
