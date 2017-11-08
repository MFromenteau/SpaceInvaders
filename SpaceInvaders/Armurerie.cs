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
            weaponList.Add(new Arme("Torpille",3,3,Arme.Type.Guide,2));
            weaponList.Add(new Arme("Mitrailleuse", 2,3,Arme.Type.Direct,1));
            weaponList.Add(new Arme("EMG", 1, 7, Arme.Type.Explosif, 1.5));
            weaponList.Add(new Arme("Missile", 4, 100, Arme.Type.Guide, 4));
            weaponList.Add(new Arme("cheat", 6, 100, Arme.Type.Direct, 0));
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

        public void AddWeaponToList(Arme weapon)
        {
            weaponList.Add(weapon);
        }
    }
}
