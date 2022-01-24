using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilinetoo
{
    public class KorteriteMaja :Hoone
    {
        int korteri ;
        String building=null;


        public KorteriteMaja(int Korteri,String Building )
        {

            korteri = Korteri ;
            if (korteri > 2)
            {
                building = " flat house";
            }
            else 
            {
                building = "flat";
            }
        }






        public void NaitaInfo()
        {

          Console.WriteLine($" See on  {building } ");

        }

    }
}
