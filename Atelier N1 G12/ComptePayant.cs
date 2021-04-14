using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N1_G12
{
    class ComptePayant : Compte
    {           
        public ComptePayant(MAD s, Client titu) : base(s, titu)
        {

        }

        public override bool verser(Compte c, MAD somme)
        {
            MAD deb = new MAD(5); 

            if (this.debiter(somme) == true)
            {
                c.crediter(somme);
                c.debiter(deb * 1 / 100);
                return true;
            }
            else
                return false;
        }
    }
}
