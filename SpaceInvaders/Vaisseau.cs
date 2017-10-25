using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{

    class Vaisseau
    {
        public string cul;
        public string nom { get; }
        public int ptBouclier { get; private set; }
        public int ptStruct { get; private set; }
        private int ptStructMax { get; }
        private int ptBouclierMax { get; }
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

        public void Equipe(Arme a)
        {
            if (armes.Count() > 3)
                throw new InvalidOperationException();

            this.armes.Add(a);
        }

        public void Lache(Arme a)
        {
            if (armes.Count() < 0)
                throw new InvalidOperationException();

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

        public int pPrintDegatsMoyen()
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
            this.ptBouclier -= pt;

            if (this.ptBouclier < 0) {
                this.ptStruct += this.ptBouclier;
                this.ptBouclier = 0;
            }
        }

        public void Protege(int pt)
        {
            if (this.EstDetruit())
                throw new InvalidOperationException();

            this.ptBouclier += pt;
            if (this.ptBouclier >= this.ptBouclierMax) {
                this.ptBouclier = this.ptBouclierMax;
            }
        }

        public void Repare(int pt)
        {
            if (this.EstDetruit())
                throw new InvalidOperationException();

            this.ptStruct += pt;
            if (this.ptStruct >= this.ptStructMax) {
                this.ptStruct =  this.ptStructMax;
            }
        }


        public bool EstDetruit()
        {
            return this.ptStruct <= 0;
        }
    }
}
