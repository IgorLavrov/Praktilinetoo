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

        public Aken aken;

        public KorteriteMaja korteriteMaja;

        public KorteriteMaja GetkorteriteMaja()
        {
            return korteriteMaja;
        }

        public Material material { get; set; }


        public Aken GetSize()
        {
            return aken;
        }
        public Arhitekt Getarhitekt()
        {
            return arhit;
        }
       public Hoone(int pindala=200)
        {
            Pindala = pindala;

  

        }
       
        public Hoone(Material Material)
        {
      

            material = Material;
            
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen { material} maja, minu pindala on {Pindala} m2");
        }

        public  Uks GetUks()
        {
            return uks;
        }

    }



}

