﻿using System;
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
                EraMaja majake = new EraMaja();
                Inimene mees = new Inimene("Juku");
                majake.uks = new Uks("must");
                majake.arhit = new Arhitekt("Ivanov", 1984);
                majake.size = new Size(129, 4);

                mees.hoone = majake;
                mees.NaitaInfo();


        




                


            Console.ReadLine();


        }
        }


    }
   