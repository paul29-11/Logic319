
//Quis1();
//Quis2();
//Quis3();
//Quis4();
Quis5();
//Quis6();

Console.ReadKey();

static void Quis6()
{
    Console.WriteLine("Program angaka Ganjil dan Genap");
    Console.Write("Masukan Angka : ");
    int angka = int.Parse(Console.ReadLine());

    if (angka %  2 == 0 )
    {
        Console.WriteLine($"Angka {angka} adalah Genap");
    }
    else
    {
        Console.WriteLine($"Angka {angka} adalah Ganjil");
    }
}

static void Quis5()
{
    Console.WriteLine("Program Grade Nilai");

    Console.Write("Masukan Nilai (0-100): ");
    int nilai = int.Parse(Console.ReadLine());

    if (nilai >= 80 && nilai <=100)
    {
        Console.WriteLine("Grade Nilai A");
    }
    else if (nilai >= 60 && nilai < 80)
    {
        Console.WriteLine("Grade Nilai B");
    }
    else if (nilai >= 0 && nilai < 60)
    {
        Console.WriteLine("Grade Nilai C");
    }
    else
    {
        Console.WriteLine("Nilai Tidak Valid");
    }
}

static void Quis4()
{
    Console.WriteLine("Program Mengitung Hasil Rokok");

    Console.Write("Masukan Jumlah Puntung Rokok : ");
    int puntung = int.Parse(Console.ReadLine());

    int hasil = puntung / 8;
    int mod = puntung % 8;
    int harga = hasil * 500;

    Console.WriteLine($"Hasil Rokok Rakitannya adalah {hasil} Batang Rokok dan Sisa {mod} Puntung Rokok");
    Console.WriteLine($"Pendapatan Roko Yang Berhasil Dikumpulkan adalah : Rp. {harga},-");
}

static void Quis3()
{
    Console.WriteLine("Program Mencari Hasil Modulus");

    Console.Write("Masukan Angka : ");
    int angka = int.Parse(Console.ReadLine());
    Console.Write("Masukan Pembagi : ");
    int pembagi = int.Parse(Console.ReadLine());

    int h = angka % pembagi;

    if (h == 0)
    {
        Console.WriteLine($"Angka {angka} % {pembagi} adalah 0");
    } 
    else
    {
        Console.WriteLine($"Angka {angka} % {pembagi} bukan 0 melaikan hasil mod {h}");
}    }


static void Quis2()
{
    Console.WriteLine("Program Menghitung Luas dan Keliling Persegi");

    Console.Write("Pilih Program (Luas/Keliling) Persegi : ");
    string pilih = Console.ReadLine().ToLower();

    switch (pilih)
    {
        case "luas":
            Console.WriteLine("Anda Memilih Program Menghitung Luas Persegi");
            Console.Write("Masukan Panjang Sisi Persegi : ");
            int s = int.Parse(Console.ReadLine());
            double luas = s * s;
            Console.Write($"Luas Persegi adalah {luas}");
            break;
        case "keliling":
            Console.WriteLine("Anda Memilih Program Menghitung Keliling Persegi");
            Console.Write("Masukan Panjang Sisi : ");
            int sisi = int.Parse(Console.ReadLine());
            double keliling = 4 * sisi;
            Console.Write($"Keliling Persegi adalah {keliling}");
            break;
        default:
            Console.WriteLine("Pilihan salah");
            break;
    }


    }

static void Quis11()
{
    const double phi = 3.14285714;
    double luas, keliling;

    Console.WriteLine("Program Menghitung Luas dan Keliling Lingkaran");
    int r = int.Parse(Console.ReadLine());
    double hasil = phi * r * r;
    Console.Write($"Hasilnya adalah {hasil}");
    luas = phi * r * r;
    Console.Write($"Luas adalah {luas}");

    keliling = 2 * phi * r;
    Console.Write($"Keliling adalah {keliling}");

}

static void Quis1()
{
    Console.WriteLine("Program Menghitung Luas dan Keliling Lingkaran");

    //const double phi = 3.142857142857143;
    Console.Write("Pilih Program (Luas/Keliling) : ");
    string pilihan = Console.ReadLine().ToLower();

    switch (pilihan)
    {
        case "luas":
            Console.WriteLine("Anda Memilih Program Menghitung Luas Lingkaran");
            Console.Write("Masukan Jari Jari Lingkaran : ");
            double r = Convert.ToDouble(Console.ReadLine());
            //double hasil = phi * r * r;
            double hasil = Math.PI * r * r;
            Console.Write($"Hasilnya adalah {Math.Round(hasil)}");
            break;
        case "keliling":
            Console.WriteLine("Anda Memilih Program Menghitung Keliling Lingkaran");
            Console.Write("Masukan Jari Jari Lingkaran : ");
            double rr = Convert.ToDouble(Console.ReadLine());
            double hasil1 = 2 * Math.PI * rr;
            Console.Write($"Hasilnya adalah {Math.Round(hasil1)}");
            break;
        default:
            Console.WriteLine("Pilihan salah");
            break;

    }
    

    
}