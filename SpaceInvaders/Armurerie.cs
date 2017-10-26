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
            weaponList.Add(new Arme("L4Z3R",1,20,Arme.Type.Direct));
            weaponList.Add(new Arme("B0MB3",10,30,Arme.Type.Explosif));
            weaponList.Add(new Arme("M1551L3",20,40,Arme.Type.Guidé));
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
