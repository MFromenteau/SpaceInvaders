using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{

    abstract class Vaisseau
    {
        public string nom { get; }
        public int ptBouclier { get; private set; }
        public int ptStruct { get; private set; }
        protected int ptStructMax { get; }
        protected int ptBouclierMax { get; }
        public List<Arme> armes { get; }

        public Vaisseau(string nom, int ptStructMax, int ptBouclier, int ptBouclierMax)
        {
            this.nom = nom;
            this.ptStruct = ptStructMax;
            this.ptStructMax = ptStructMax;
            this.ptBouclier = ptBouclier;
            this.ptBouclierMax = ptBouclierMax;
            this.armes = new List<Arme>();
        }

        public abstract void Attaque(Vaisseau v);


        virtual public void Equipe(Arme a)
        {
            if (EstDetruit())
                return;

            if (armes.Count() > 3)
                throw new ArmurerieException("Nombre d'arme possible pour le vaisseau excédé");

            if (!Armurerie.Instance.getWeaponList().Contains(a))
                throw new ArmurerieException("Arme non disponible dans l'armurerie");

            this.armes.Add(a);
        }

        public void Lache(Arme a)
        {
            if (EstDetruit())
                return;

            if (armes.Count() < 0)
                throw new ArmurerieException("Aucune arme à lacher");


            this.armes.Remove(a);
        }

        public String PrintListeDArme()
        {
            string str = "Liste d'arme de " + this.nom + " : [";
            foreach (Arme a in this.armes) {
                str += " " + a + ",";
            }
            str += "]";

            Console.WriteLine(str);

            return str;
        }

        public int PrintDegatsMoyen()
        {
            string str = "Dégats moyen de " + this.nom + " : ";
            int deg = 0;
            foreach (Arme a in this.armes) {
                deg += (int)(a.damageMin + a.damageMax) / 2;
            }
            str += deg;

            Console.WriteLine(str);

            return deg;
        }

        public void Endommage(int pt)
        {
            if (EstDetruit())
                return;

            this.ptBouclier -= pt;

            if (this.ptBouclier < 0) {
                this.ptStruct += this.ptBouclier;
                this.ptBouclier = 0;
            }
        }

        public void Protege(int pt)
        {
            if (EstDetruit())
                return;

            this.ptBouclier += pt;
            if (this.ptBouclier >= this.ptBouclierMax) {
                this.ptBouclier = this.ptBouclierMax;
            }
        }

        public void Repare(int pt)
        {
            if (EstDetruit())
                return;

            this.ptStruct += pt;
            if (this.ptStruct >= this.ptStructMax) {
                this.ptStruct =  this.ptStructMax;
            }
        }

        public bool EstDetruit()
        {
            return this.ptStruct <= 0;
        }

        public string SmallDesc()
        {
            return (nom.Substring(0,2));
        }

        public override string ToString()
        {
            if (EstDetruit())
                return (("V[" + this.nom).PadRight(15, ' ') + "] : DESTROYED").PadRight(40, ' ');

            return (("[" + this.nom ).PadRight(11, ' ') + "]:H" + (this.ptStruct + "/" + this.ptStructMax).PadRight(5,' ') + "||B" + (this.ptBouclier + "/" + this.ptBouclierMax).PadRight(5, ' ')).PadRight(40,' ');
        }

    }
}
