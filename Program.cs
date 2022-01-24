using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilinetoo
{
   static class Program
    {
        static void Main(string[] args)
        {
                Hoone hoone = new Hoone( Material.PalkMaja);
            EraMaja majake = new EraMaja("", 140);
                Inimene mees = new Inimene("Juku");
                majake.uks = new Uks("must");
                majake.arhit = new Arhitekt("Ivanov", 1984);
                majake.aken = new Aken(4);
                
                majake.korteriteMaja = new KorteriteMaja(3, " ");
                majake.NaitaInfo();

                mees.hoone = majake;
                mees.NaitaInfo();

            Console.ReadLine();


        }
        }


    }
   
