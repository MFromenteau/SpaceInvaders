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
        public int damageMin { get; private set; }
        public int damageMax { get; private set; }
        public enum Type { Direct, Explosif, Guide };
        public Type instanceType { get; }
        public double tempsRecharge { get; private set; }
        public double nbTours { get; private set; }

        public Arme(string nom, int damageMin, int damageMax, Type instanceType, double tempsR)
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

        public void DecrementeUnTour(double i)
        {
            nbTours -= i;
        }

        public int Tir(int bonus = 1)
        {
            DecrementeUnTour(bonus);
            if (nbTours > 0)
            {
                return 0;
            }
            Random rand = new Random();
            nbTours = tempsRecharge;
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
                case Type.Guide:
                    return damageMin;
                default:
                    break;
            }
            return rand.Next(damageMin, damageMax);
        }
    }
}
