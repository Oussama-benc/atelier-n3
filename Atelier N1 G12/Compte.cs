using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N1_G12
{
    public abstract class Compte
    {

        private readonly  int Numcompt;
        private static int cpt;
        protected MAD solde;
        private readonly Client Titulaire;
        private static MAD plafond;
        private List<Operation> listop;
        
        
        
       
        static Compte()
        {
            cpt = 0;
            plafond = new MAD(4000);
        }

      

        public Compte(MAD s,Client titu)
        {
            this.Numcompt = ++cpt;
            this.solde = s;
            this.Titulaire = titu;
            this.listop = new List<Operation>();

        }

        public  virtual void consulter()
        {
            Console.WriteLine("le num est : " + this.Numcompt);
            this.Titulaire.afficherClient();
            this.solde.afficherSolde();

            foreach(Operation o in listop)
            {
                o.afficher_operation();
            }

        }

        public bool crediter(MAD somme)
        {
            MAD nul_Val = new MAD(0);

            if (somme > nul_Val)
            {
                this.solde = this.solde + somme;
                this.listop.Add(new Operation(somme, "+"));
                return true;
            }
            else
                return false;
        }

        public  virtual bool debiter(MAD somme)
        {
            MAD nul_Val = new MAD(0);
            if (this.solde >= somme)
            {
                if (plafond >= somme)
                {
                    if (somme> nul_Val)
                    {
                        this.solde = this.solde - somme;
                        this.listop.Add(new Operation(somme, "-"));
                        return true;

                    }
                    else
                    {
                        Console.WriteLine("somme<0");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("plafond<somme");
                    return false;

                }
            }
            else
            {
                Console.WriteLine("solde<somme");
                return false;
            }
        }

        public virtual bool verser(Compte c,MAD somme)
        {
            if (this.debiter(somme) == true)
            {
                c.crediter(somme);
                return true;
            }
           else
                return false;
        }


     

        protected bool ComparerDecouvert(MAD somme, MAD decouvert)
        {
            if (this.solde - somme > decouvert)
            {
                return true;
            }
            else
                return false;
        }
       

        protected void AjouterInteret(double interet)=> this.crediter(this.solde * interet);
        



    }
}
