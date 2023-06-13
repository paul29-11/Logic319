using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic06
{
    public class Mamalia
    {
        public virtual string pindah()
        {
            //Console.WriteLine("Lari ........");
            return "Berlari";
        }

    }

    public class Kucing : Mamalia 
    {

    }

    public class Paus : Mamalia
    {
        public override string pindah()
        {
            //Console.WriteLine("Berenang ......");
            return "Berenang";
        }
    }
}
