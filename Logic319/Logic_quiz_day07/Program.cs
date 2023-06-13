// Logic Quiz Day 07
using System;

//Exercise2();
//quiz01();
//quiz02();
//quiz03();
//quiz04();
//quiz05();
//quiz06();

Console.ReadKey();

static void quiz01()
{
    Console.WriteLine("----- Quiz 01 -----");
    bool ulangi = true;
    while (ulangi)
    {
    atas:
        try
        {
            Console.Write("Masukan N : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Masukan Angka : ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int angka = i % 2 == 0 ? i * -a : i * a;
                Console.Write(angka + " ");
            }
            Console.ReadLine();

        }
        catch (Exception)
        {

            Console.WriteLine("Inputan Harus Angka ya Pak/Ibu dan Tidak Boleh Kosong");
            goto atas;
        }
        Console.WriteLine();
        Console.WriteLine("Ulangi Proses ? (y/n) ");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            ulangi = false;
        }
    }

}

static void quiz02()
{
    Console.WriteLine("----- Quiz 02 -----");
    bool ulangi = true;

    while(ulangi)
    {
        Console.Write("Masukan Jam : ");
        string jam = Console.ReadLine();
        try
        {
            DateTime waktu = DateTime.ParseExact(jam, "hh:mm:ss tt", null);

            string waktu_baru = waktu.ToString("HH:mm:ss");
            Console.WriteLine(waktu_baru);

        }
        catch (Exception e)
        {
            Console.WriteLine("Format Yang Anda Masukan salah");
            Console.WriteLine("Pesan Error : " + e.Message);
        }

        Console.WriteLine();
        Console.WriteLine("Ulangi Proses ? (y/n) ");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            ulangi = false;
        }
    }
}

static void quiz03()
{
    Console.WriteLine("----- Quiz 03 -----");

    bool ulangi = true;
    while (ulangi)
    {
        atas:
        try
        {
            Console.Write("Masukan Kode Baju : ");
            int kode = int.Parse(Console.ReadLine());
            Console.Write("Masukan Ukuran Baju : ");
            string ukuran = Console.ReadLine().ToLower();
            if (string.IsNullOrEmpty(ukuran))
            {
                Console.WriteLine("Ukuran Tidak boleh Kosong ");
                continue;
            }
            else
            {
                int harga = 0;
                string merek = "";
                switch (kode)
                {
                    case 1:
                        merek = "IMP";
                        if (ukuran == "s")
                        {
                            harga = 200000;
                        }
                        else if (ukuran == "m")
                        {
                            harga = 220000;
                        }
                        else
                        {
                            harga = 250000;
                        }

                        break;
                    case 2:
                        merek = "Prada";
                        if (ukuran == "s")
                        {
                            harga = 150000;
                        }
                        else if (ukuran == "m")
                        {
                            harga = 160000;
                        }
                        else
                        {
                            harga = 170000;
                        }
                        break;
                    case 3:
                        merek = "Gucci";
                        if (ukuran == "s" || ukuran == "m")
                        {
                            harga = 200000;
                        }
                        else
                        {
                            harga = 200000;
                        }
                        break;
                    default:
                        Console.WriteLine("Maaf Kode yang anda Inputkan tidak ada");
                        break;

                }
                Console.WriteLine($"Merek Baju :  {merek}");
                Console.WriteLine($"Harga Baju : Rp. {harga}");
            }

        }
        catch (Exception e)
        {

            Console.WriteLine("Kode harus Angka dan tidak boleh kosong ingat");
            goto atas;
        }


        Console.WriteLine();
        Console.WriteLine("Ulangi Proses ? (y/n) ");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            ulangi = false;
        }

    }

}

static void quiz04()
{
    Console.WriteLine("----- Quiz 04 -----");
    bool ulangi = true;

    while (ulangi)
    {
        atas:
        try
        {
            Console.Write("Masukan Uang Anda : ");
            int uang = int.Parse(Console.ReadLine());

            Console.Write("Masukan Harga Baju : ");
            string harga_baju = Console.ReadLine();
            int[] b = Array.ConvertAll(harga_baju.Split(',') ,int.Parse);

            Console.Write("Masukan Harga Celana : ");
            string harga_celana = Console.ReadLine();
            int[] c = Array.ConvertAll(harga_celana.Split(','),int.Parse);

            int tampung = 0;

            for (int i = 0; i < b.Length; i++) // For Untuk Baju
            {
                for (int j = 0; j < c.Length; j++) // FOr Untuk Celana
                {
                    int hasil = b[i] + c[j];
                    if (hasil <= uang && hasil >= tampung)
                    {
                        tampung = hasil;
                        Console.WriteLine($"{tampung}");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Inputan Harus Angka ya Bapak/Ibu Dan Tidak Boleh Kosong");
            goto atas;
        }
       
        Console.WriteLine();
        Console.WriteLine("Ulangi Proses ? (y/n) ");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            ulangi = false;
        }
    }
}

static void quiz05()
{
    Console.WriteLine("----- Quiz 05 -----");
    bool ulangi = true;
    while (ulangi)
    {
        Console.Write("Masukan Arr : ");
        string arr = Console.ReadLine();
        Console.Write("Masukan Rot : ");
        int rot = int.Parse(Console.ReadLine());

        string[] arr_split = arr.Split(',');
        string[] x = new string[1];

        for (int i = 0; i < rot; i++)
        {
            x[0] = arr_split[0];
            for (int j = 0; j < arr_split.Length -1; j++)
            {
                arr_split[j] = arr_split[j+1];
            }
            arr_split[arr_split.Length -1] = x[0];
            Console.WriteLine($"{i +1}: {string.Join(",", arr_split)}"); 
        }

        Console.WriteLine();

        //Console.WriteLine("Ulangi Proses ? (y/n) ");
        //string input = Console.ReadLine();

        //if (input.ToLower() == "n")
        //{
        //    ulangi = false;
        //}
    }
}

static void quiz06()
{
    Console.WriteLine("----- Quiz 06 -----");
    bool ulangi = true;
    while (ulangi)
    {
        Console.Write("Masukan Angka yang Mau di urutkan : ");
        string angka = Console.ReadLine();
        string[] a = angka.Split(',');
        int[] b = Array.ConvertAll(a, int.Parse);
        int tampung;

        for (int i = 0;  i <= b.Length -2; i++)
        {
            for (int j = 0; j <= b.Length -2; j++)
            {
                if (b[j] > b[j + 1])
                {
                    tampung = b[j + 1];
                    b[j + 1] = b[j];
                    b[j] = tampung;
                }
            }
        }

        foreach (int z in b)
        {
            Console.Write(z + " ");
        }
                
        Console.WriteLine();
        Console.WriteLine("Ulangi Proses ? (y/n) ");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            ulangi = false;
        }
    }
}


//Fachri Kusnaini
static void Exercise2()
{
    string input;
    Console.WriteLine("-== EXERCISE 2 ==-");
    Console.Write("Insert time AM/PM : ");
    input = Console.ReadLine();

    DateTime time = DateTime.ParseExact(input, "HH.mm", null);

    Console.WriteLine(time.ToString("hh:mm:ss"));

}


