using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic06
{
    public class Mobil
    {
        public double kecepatan; // Ini merupakan field 
        public double bensin;
        public double posisi;
        public string nama;
        public string platno;

        //Contructor
        public Mobil(string _platno) 
        {
            platno = _platno;
        
        }

        // Constructor 2
        public Mobil() 
        {
            
        }

        public string getPlatNo()
        {
            return platno;
        }

        public void utama()
        {
            Console.WriteLine("Start");
            Console.WriteLine($"Nama = {nama}");
            Console.WriteLine($"PlatNo = {platno}");
            Console.WriteLine($"Bensin = {bensin}");
            Console.WriteLine($"Kecepatan = {kecepatan}");
            Console.WriteLine($"posisi = {posisi}");
        }

        public void percepat()
        {
            this.kecepatan += 10;
            this.bensin -= 5;
        }

        public void maju()
        {
            this.posisi += this.kecepatan;
            this.bensin -= 2;
        }

        public void isiBensin(double bensin)
        {
            this.bensin += bensin;
        }
    }
}
