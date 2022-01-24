using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilinetoo
{
    
        public class EraMaja : Hoone
        {

        int Korteride_arv;
        int Elanikite_arv;
        
        String status = null;






        public EraMaja() : base()
        {
        }

        public EraMaja(int korv_arv,int E_arv)
        {
            Korteride_arv = korv_arv;
            Elanikite_arv = E_arv;

        }

        public EraMaja(int pindala = 50) : base(pindala)
        {
        }

        


        public int Pindala        {
            set
            {
                Pindala = value;
                if (Pindala < 7) status = "vaike maja";
                else if (Pindala < 17) status = "keskmine maja";
                else if (Pindala < 22) status = "suur maja";
                else status = "liiga suur maja";

            }

            get { return (Pindala); }
        }

        public String Status
        {

            get { return status; }
        }

        public void NaitaInfo()
        {
            
          
            Console.WriteLine($"Status {status} vaike  maja");
        }






    }


    
}
