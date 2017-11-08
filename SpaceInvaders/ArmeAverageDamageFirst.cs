using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class ArmeAverageDamageFirst : Comparer<Arme>
    {
        public override int Compare(Arme x, Arme y)
        {
            return x.AverageDamage().CompareTo(y.AverageDamage());
        }
    }
}
