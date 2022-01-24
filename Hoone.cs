using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilinetoo
{
    public class Hoone
    { 
        public int Pindala { get; set; }

        public  Uks uks;

        public Arhitekt arhit;

        public Size size;


        public Size GetSize()
        {
            return size;
        }
        public Arhitekt Getarhitekt()
        {
            return arhit;
        }

        public Hoone(int pindala = 200)
        {
            Pindala = pindala;
           
            
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
        }

        public  Uks GetUks()
        {
            return uks;
        }

    }



}

