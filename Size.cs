﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilinetoo
{
   public  class Size
    {

        int suurus;
        string status { get; set; }
        int aken;

        public Size()
        {

        }

        public Size( int Suurus, int Aken)
        {
            suurus = Suurus;
           
            aken = Aken;

        }

        public int Suurus
        {
            set
            {
                suurus = value;
                if (suurus < 7)  status = "vaike maja";
                else if (suurus < 17) status = "keskmine maja";
                else if (suurus < 22) status = "suur maja";
                else status = "liiga suur maja";

            }

            get { return (suurus); }
        }

        public string Status
        {

            get { return status; }
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Suurus on {suurus} ");
            Console.WriteLine($"Aken Numbrit {aken} ");
            Console.WriteLine($"Status {status} ");
        }



    }
}
