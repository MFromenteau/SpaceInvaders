using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    interface IAptitude
    {

        List<Vaisseau> Utilise(List<Vaisseau> listVaisseau);
    }
}
