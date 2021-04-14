using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N1_G12
{
    class CmpteEpargne : Compte
    {
        private double TauxInteret;
        public CmpteEpargne(Client titu, MAD solde): 
            base(solde, titu)
        {
            double Taux;
            bool res;
            do
            {
                Console.WriteLine("donnez un taux");
                res=double.TryParse(Console.ReadLine(), out Taux );

            } while (Taux <= 0 || Taux >= 100 || !res);

            this.TauxInteret = Taux;
            
        }


        public void CalculInteret()
        {
            this.AjouterInteret(this.TauxInteret / 100);
        }

        public override bool debiter(MAD somme)
        {
            if (somme <= this.solde / 2)
            {
                this.solde -= somme;
                
                return true;
                
            }
            else
                return false;        
            
        }

    }
    }
