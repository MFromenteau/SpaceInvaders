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

        private List<string> weaponList = new List<string>();

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

        public List<string> getWeaponList()
        {
            return weaponList;
        }

        public string displayAllWeapon()
        {
            string result="";
            foreach (var weapon in weaponList)
            {
                result = result + " " + weapon;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
