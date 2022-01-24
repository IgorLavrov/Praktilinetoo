using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilinetoo
{
    public class Inimene
    {
        private string nimi;
        public Hoone hoone { get; set; }
      

        public Inimene(string nimi)
        {
            this.nimi = nimi;
        }

        public Inimene()
        {
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen inimene, nimu nimi on {nimi}");
            Console.WriteLine("Hoone info:");
            hoone.NaitaInfo();
            Console.WriteLine("Data of door:");
            hoone.GetUks().NaitaInfo();
            hoone.Getarhitekt().NaitaInfo2();
            hoone.GetSize().NaitaInfo();
            
      
        }

    }
}
