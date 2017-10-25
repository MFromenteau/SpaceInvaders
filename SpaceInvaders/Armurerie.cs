using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SpaceInvaders
{
    class Armurerie
    {
        private ArrayList weaponList = new ArrayList();

        public Armurerie()
        {
            Init();
        }

        private void Init()
        {
            weaponList.Add("Default");
            weaponList.Add("Bombe");
            weaponList.Add("Missile");
        }

        public ArrayList getWeaponList()
        {
            return weaponList;
        }
    }
}
