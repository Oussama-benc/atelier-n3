using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N1_G12
{
    class CmptCourant : Compte
    {
        private MAD decouvert;
        private int numer_carte;
        private  MAD decouvertMaxi = new MAD(10);

        public CmptCourant(Client titu, MAD s, MAD dec , int carte) : base(s, titu)
        {
            this.numer_carte = carte;
            this.decouvert = dec;

        }

        
        public override bool debiter(MAD somme)
        {


            if (this.ComparerDecouvert(somme, this.decouvertMaxi))
            {

                return base.debiter(somme);

            }
            else
                return false;

        }


        public override void consulter()
        {
            base.consulter();
            Console.WriteLine("le decouvert est : ");
            this.decouvert.afficherSolde();
        }
    }
}
