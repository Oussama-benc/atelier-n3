using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_N1_G12
{
    public class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        private List<Compte> listeComptes;


        public Client(string n, string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = a;
            this.listeComptes = new List<Compte>();
        }

        public void afficherClient()
        {
            Console.WriteLine("le nom est : " + this.nom);
            Console.WriteLine("le prenom est : " + this.prenom);
            Console.WriteLine("l'adresse est : " + this.adresse);
        }
    }
}
