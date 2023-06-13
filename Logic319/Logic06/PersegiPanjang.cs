using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic06
{
    public class PersegiPanjang
    {
        public double panjang;
        public double lebar;
        public double LuasPersegiPanjang()
        {
            return panjang * lebar;
        }

        public void TampilkanData()
        {
            Console.WriteLine($"Luas = {LuasPersegiPanjang()}");
        }
    }
}
