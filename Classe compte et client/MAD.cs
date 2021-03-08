using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_compte_et_client
{
    class MAD
    {
        private double valeur;

        public MAD()
        {
        }

        public  MAD(double solde)
        {
            valeur = solde;
        }
         

        public int comparer(MAD a)
        {
            if(this.valeur > a.valeur)
            {
                return 1;
            }
            if(this.valeur < a.valeur)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
       
        public MAD sommeMAD(MAD a)
        {
            MAD m = new MAD(this.valeur);

            m.valeur = valeur + a.valeur;

            return m ;
        }

        public MAD soustractionMAD(MAD a)
        {
            MAD m = new MAD(this.valeur);

            m.valeur = valeur - a.valeur;

            return m;
        }


    }
}
