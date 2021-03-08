using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_compte_et_client
{
    class Compte
    {
        private int rib;
        //private double solde;
        private Client titulaire;
        private MAD solde;
        private static int cmpt = 0;

      
        public Compte(Client titulaire , MAD solde)
        {
            cmpt++;
            this.rib = cmpt;
            this.solde = solde;
            this.titulaire = titulaire;
        }


        public bool Crediter(MAD somme)
        {
            MAD NU = new MAD(0);

            if(somme.comparer(NU)>=0)
            {

                this.solde.sommeMAD(somme);
                 Console.WriteLine("Vous avez ajouté une somme de " + somme + " MAD à votre compte ");
                return true;
            }
            else
            {

                Console.WriteLine("La somme doit être positive");

                return false;
            }
           
        }


        public bool Debiter(MAD somme)
        {
            MAD NU = new MAD(0);

            if (somme.comparer(NU) >= 0)
            {
               
                this.solde.soustractionMAD(somme);
                Console.WriteLine("Vous avez retiré une somme de " + somme + " MAD ");
                return true;
            }
            else
            {
                Console.WriteLine("Solde insuffisant");
                return false;
            }
                
        }

        public bool verser(Compte c22 , MAD somme)
        {
            MAD NU = new MAD(0);

            if (somme.comparer(NU) >= 0)
            {
                this.solde.soustractionMAD(somme);
                c22.solde.sommeMAD(somme);
                Console.WriteLine(" Bien versé");
                return true;
            }
            else
            {
                Console.WriteLine("Solde insuffisant");
                return false;
            }
        }

       
        public void Afficher()
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Numéro du Compte : \t " + this.rib);
            Console.WriteLine("Solde du compte : \t" + this.solde + " MAD");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Titulaire du compte : \t ");
            Console.ForegroundColor = ConsoleColor.Gray;

            titulaire.Afficher();     
        }

      
    }
}
