using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilinetoo
{
    public class Arhitekt
    { 
        string surname;
        int year;

        public Arhitekt()
        {

        }
        public Arhitekt(string Surname,int Year)
        {
            surname = Surname;
            year = Year;
            
        }
        public void NaitaInfo2()
        {
            Console.WriteLine($"Mina olen Arhitekt, nimu surname on {surname}");
            Console.WriteLine($" see maja ehitab {year} aastat ");
           
        }





    }
}
