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

        private static readonly Lazy<Armurerie> lazy = new Lazy<Armurerie>(() => new Armurerie());
        public static Armurerie Instance { get { return lazy.Value; } }

        private List<Arme> weaponList = new List<Arme>();

        private Armurerie()
        {
            Init();
        }

        private void Init()
        {
            weaponList.Add(new Arme("L4Z3R",2,3,Arme.Type.Direct,1));
            weaponList.Add(new Arme("B0MB3",1,8,Arme.Type.Explosif,1.5));
            weaponList.Add(new Arme("M1551L3",3,3,Arme.Type.Guide,2));
        }

        public List<Arme> getWeaponList(){
            return weaponList;
        }

        public string displayAllWeapon()
        {
            string result="";
            foreach (var weapon in weaponList)
            {
                result = result + " " + weapon.nom;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
