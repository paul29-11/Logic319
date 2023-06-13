
//quiz01();
//quiz02();
//quiz03();
//quiz04();
//quiz05();
//quiz06();
//quiz07();
quiz08();



Console.ReadKey();


static void quiz01()
{
    Console.WriteLine("----- Quiz 01 -----");
    try
    {
        bool ulangi = true;

        while (ulangi)
        {
            Console.Write("Masukan Golongan \t: ");
            int golongan = int.Parse(Console.ReadLine());
            Console.Write("Masukan Jam Kerja \t: ");
            int jam = int.Parse(Console.ReadLine());

            int j = 40;
            int upah = 0;
            int lembur = 0;
            int sisa_jam = 0;
            int total_gaji = 0;
            int total_upah = 0;
            int upah_lembur = 0;


            switch (golongan)
            {
                case 1:
                    upah = 2000;
                    upah_lembur = 3000;
                    break;
                case 2:
                    upah = 3000;
                    upah_lembur = 4500;
                    break;
                case 3:
                    upah = 4000;
                    upah_lembur = 6000;
                    break;
                case 4:
                    upah = 5000;
                    upah_lembur = 7500;
                    break;
                default:
                    Console.WriteLine("Maaf, Silahkan Ulangi proses");
                    break;
            }

            if (jam > 40)
            {
                sisa_jam = jam - j; 
            }

            lembur = sisa_jam * upah_lembur;
            total_upah = upah * j;
            total_gaji = total_upah + lembur;

            Console.WriteLine($"Upah \t: {total_upah}");
            Console.WriteLine($"Lembur \t: {lembur}");
            Console.WriteLine($"Total \t: {total_gaji}");


            Console.WriteLine();
            Console.WriteLine("Ulangi Proses ? (y/n) ");
            string input = Console.ReadLine();

            if (input.ToLower() == "n")
            {
                ulangi = false;
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Inputan Salah Silahkan Ulangi");
    }

    
}

static void quiz02()
{
    Console.WriteLine("----- Quiz 02 -----");
    
        bool ulangi = true;
        

        while (ulangi)
        {
            //string kalimat = "";
            //if (string.IsNullOrEmpty(kalimat))
            //{
            //    Console.Write("Masukan Kalimat : ");
            //    kalimat = Console.ReadLine();
            //    if (string.IsNullOrEmpty(kalimat))
            //    {
            //        Console.WriteLine("Kalimat tidak boleh kosong");
            //        continue;
            //    }
            //}

        Console.Write("Masukan Kalimat : ");
        string kalimat = Console.ReadLine();
        if (kalimat == string.Empty)
        {
            Console.WriteLine("Kalimat TIdak Boleh Kosong");
        }
        else
        {
            string[] kata = kalimat.Split();

            for (int i = 0; i < kata.Length; i++)
            {
                string item = kata[i];
                Console.WriteLine($"Kata {i + 1} : {item}");
            }

            Console.WriteLine($"Total Kata Adalah : {kata.Count()}");
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
        string kalimat = "";
        if (string.IsNullOrEmpty(kalimat))
        {
            Console.Write("Masukan Kalimat : ");
            kalimat = Console.ReadLine();

            if (string.IsNullOrEmpty(kalimat))
            {
                Console.WriteLine("Kalimat tidak boleh kosong");
                continue;
            }
        }
        
        string[] kata = kalimat.Split();

        string hasil = "";

        for (int i = 0; i < kata.Length; i++)
        {
            string baru = "";
            for (int j = 0; j < kata[i].Length; j++)
            {
                if (j == 0 || j == kata[i].Length - 1)
                {
                    baru += kata[i][j];
                }
                else
                {
                    baru += "*";
                }

            }
            hasil += baru + " ";
        }

        Console.WriteLine(hasil);


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
        string kalimat = "";
        if (string.IsNullOrEmpty(kalimat))
        {
            Console.Write("Masukan Kalimat : ");
            kalimat = Console.ReadLine();
            if (string.IsNullOrEmpty(kalimat))
            {
                Console.Write("Kalimat Tidak boleh Kosong ");
            }
        }
        

        string[] kata = kalimat.Split();

        string hasil = "";

        for (int i = 0; i < kata.Length; i++)
        {
            string baru = "";
            for (int j = 0; j < kata[i].Length; j++)
            {
                if (j == 0 || j == kata[i].Length - 1)
                {
                    baru += "*";
                }
                else
                {
                    baru += kata[i][j];
                }

            }
            hasil += baru + " ";
        }

        Console.WriteLine(hasil);


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
        
      
            Console.Write("Masukan Kalimat : ");
            string kalimat = Console.ReadLine();
            if (string.IsNullOrEmpty(kalimat))
            {
                Console.Write("Kalimat Tidak boleh Kosong ");
            }
            else
            {
            string[] kata = kalimat.Split(' ');
            string hasil = "";
            //string baru = "";
            for (int i = 0; i < kata.Length; i++)
            {
                //baru = kata[i].Remove(0, 1);
                hasil += kata[i].Remove(0, 1) + " ";
                //Console.Write(kata[i]);
            }
            //for (int i = 0; i < kata.Length; i++)
            //{
            //    Console.WriteLine(kata[i]);
            //}
            Console.WriteLine(hasil);
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

static void quiz06()
{
    Console.WriteLine("---- Quiz 06 -----");

    Console.Write("Masukan Angka : ");
    int angka = int.Parse(Console.ReadLine());
    Console.Write("Masukan Perkalian : ");
    int kali = int.Parse(Console.ReadLine());
    int a = 1;
    

    for (int i = 0; i < angka; i++)
    {
        a *= kali;
        if (i % 2 == 0)
        {
            Console.Write($"{a}");
        }
        else
        {
            Console.Write(" * ");
        }
        
    }

}

static void quiz07()
{
    Console.WriteLine("----- Quiz 07 -----");
    try
    {
        bool ulangi = true;

        while (ulangi)
        {
            Console.Write("Masukan Angka : ");
            int angka = int.Parse(Console.ReadLine());

                int a1 = 1;
                int a2 = 1;

                for (int j = 0; j < angka; j++)
                {
                    Console.Write(a1 + ",");
                    int proses = a1;
                    a1 = a2;
                    a2 = proses + a2;
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
    catch (Exception e)
    {

        Console.WriteLine("Masukan Harus Angka ya dan tidak boleh kosong");
    }

    
}

static void quiz08()
{
    bool ulangi = true;
    Console.WriteLine("----- Quiz 08 -----");
    while (ulangi)
    {
        a:
        try
        {
            
            Console.Write("Masukan N : ");
            int n = int.Parse(Console.ReadLine());
            int a = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0)
                    {
                        Console.Write($"{j + 1}\t");
                    }
                    else if (i == n - 1)
                    {
                        Console.Write($"{a}\t");
                        a -= 1;
                    }
                    else if (j == 0 || j == n - 1)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            
        }
        catch (Exception)
        {
            Console.WriteLine("Masukan Angka dan tidak boleh kosong");
            goto a;
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