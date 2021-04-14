using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N1_G12
{
    public class MAD
    {
        private double valeur; 
        public MAD(double val)
        {
            this.valeur = val;
        }

        public void afficherSolde()
        {
            Console.WriteLine("la valeur est : " + this.valeur);

        }

        public static bool operator>(MAD m1, MAD m2)
        {
            if (m1.valeur> m2.valeur)
            {
                return true;
            }
            else return false;

        }

        public static bool operator <(MAD m1, MAD m2)
        {
            if (m1.valeur < m2.valeur)
            {
                return true;
            }
            else return false;

        }
        public static bool operator >=(MAD m1, MAD m2)
        {
            if (m1.valeur >= m2.valeur)
            {
                return true;
            }
            else return false;

        }

        public static bool operator <=(MAD m1, MAD m2) => m1.valeur <= m2.valeur;
       
        public static MAD operator+(MAD m1, MAD m2)
        {
            MAD m3 = new MAD(0);
            m3.valeur = m1.valeur + m2.valeur;
            return m3;
        }

        public static MAD operator /(MAD m1, int a)
        {
            MAD m3 = new MAD(0);
            m3.valeur = m1.valeur / a;
            return m3;
        }

        public static MAD operator -(MAD m1, MAD m2) => new MAD(m1.valeur - m2.valeur);
      

        public static MAD operator *(MAD m1, double m2) => new MAD(m1.valeur * m2);
       

    }
}
