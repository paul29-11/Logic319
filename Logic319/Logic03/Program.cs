
//PerulanganWhile();
//PerulanganWhile2();
//PerulanganDoWhile();
//PerulanganFor();
//PerulanganBreak();
//PerulanganContinue();
//PerulanganForBersarang();
//PerulanganForeach();
//Length();
//Remove();
//Insert();
//Replace();
//ContainString();
//SplitAndJoin();
//SubString();
//ToCharArray();
//ConvertStringArrayToInt();
//ConvertAll();

Console.ReadKey();


static void PerulanganWhile()
{
    Console.WriteLine("-----Perulangan While-----");

    Console.Write("Masukan Nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    while (nilai < 6)
    {
        Console.WriteLine(nilai);
        nilai++;
    }

}

static void PerulanganWhile2()
{
    Console.WriteLine("----- Perulangan While 2 ------");

    bool ulangi = true;

    Console.Write("Masukan Nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    while(ulangi)
    {
        Console.WriteLine($"Proses ke {nilai}");
        nilai++;

        Console.WriteLine("Ulangi Proses ? (y/n) ");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            ulangi = false;
        }
    }

}

static void PerulanganDoWhile()
{
    Console.WriteLine("----- Perulangan Do While -----");

    Console.Write("Masukan Nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine(nilai);
        nilai++;
    } while (nilai < 6);
}

static void PerulanganFor()
{
    Console.WriteLine("----- Perulangan For -----");


    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(i + "\t");
    }

    Console.WriteLine(); //Console.Write("\n"); 

    for (int i = 9; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
}

static void PerulanganBreak()
{
    Console.WriteLine("----- Break -----");

    for (int i = 0; i < 10; i++)
    {
        //Console.WriteLine(i);
        if (i == 6)
        {
            break;
        }
        Console.WriteLine(i);
    }
}

static void PerulanganContinue()
{
    Console.WriteLine("----- Break -----");

    for (int i = 0; i < 10; i++)
    {
        if (i == 7)
        {
            continue;
        }
        Console.WriteLine(i);
    }
}

static void PerulanganForBersarang() //For Nested
{
    Console.WriteLine("----- Perulangn For Bersarang -----");

    for (int i = 0; i < 3; i++) //Iterasi Baris
    {
        for (int j = 0; j < 3; j++) //Iterasi Kolom
        {
            for (int z = 0; z < 3; z++)
            {
                Console.Write($"({i},{j},{z})");
            }
            //Console.Write($"({i},{j})");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

static void PerulanganForeach()
{
    int[] array = { 89, 90, 91, 92 , 93};
    int sum = 0;

    foreach (int x in array)
    {
        sum += x;
        Console.WriteLine(x);
    }
    Console.WriteLine($"Jumlah {sum}");

    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
        Console.WriteLine(array[i]);
    }
    Console.WriteLine($" Jumlah {sum}");
}

static void Length()
{
    Console.WriteLine("----- Length -----");
    Console.Write("Masukan Kata : ");
    string kata = Console.ReadLine();

    Console.WriteLine($"Kata {kata} Mempunya panjang karakter = {kata.Length}");
    Console.WriteLine($"Kata {kata} Mempunya panjang karakter = {kata.ToUpper()}");
    Console.WriteLine($"Kata {kata} Mempunya panjang karakter = {kata.ToLower()}");

}

static void Remove()
{
    Console.WriteLine("----- Remove -----");

    Console.Write("Masukan Kata : ");
    string kata = Console.ReadLine();
    Console.Write("Masukan Index Remove : ");
    int i = int.Parse(Console.ReadLine());
    

    Console.WriteLine($"{kata.Remove(i)}");
}

static void Insert()
{
    Console.WriteLine("----- Insert -----");

    Console.Write("Masukan Kata : ");
    string kata = Console.ReadLine();
    Console.Write("Masukan Index Insert : ");
    int i = int.Parse(Console.ReadLine());
    Console.Write("Masukan Kata Yang di Insert : ");
    string kata1 = Console.ReadLine();

    Console.WriteLine($"{kata.Insert(i, kata1)}");
}

static void Replace()
{
    Console.WriteLine("----- Replace -----");

    Console.Write("Masukan Kata : ");
    string kata = Console.ReadLine();
    Console.Write("Masukan Kata Lama : ");
    string katalama  = Console.ReadLine();
    Console.Write("Masukan Kata baru : ");
    string katabaru = Console.ReadLine();

    Console.WriteLine($"{kata.Replace(katalama, katabaru)}");
}

static void ContainString()
{
    Console.WriteLine("----- Contains String -----");

    Console.Write("Masukan Kata : ");
    string kata = Console.ReadLine();
    Console.Write("Masukan Contain : ");
    string contain = Console.ReadLine();

    if (kata.Contains(contain))
    {
        Console.WriteLine($"Kata {kata} Mengandung {contain}");
    }
    else
    {
        Console.WriteLine($"Kata {kata} Tidak Mengandung {contain}");
    }

}

static void SplitAndJoin()
{
    Console.WriteLine("----- Split AND Join -----");

    Console.Write("Masukan Kalimat Mutiara : ");
    string kalimat = Console.ReadLine();
    Console.Write("Masukan Split nya : ");
    string split = Console.ReadLine();

    string[] KataKata = kalimat.Split(split);

    foreach (string kata in KataKata)
    {
        Console.WriteLine(kata);
    }

    Console.WriteLine(string.Join(" + ", KataKata));

    Console.WriteLine();

    int[] deret = { 1, 2, 3, 4, 5, 6 };
    string strDeret = string.Join(" + ", deret);
    Console.WriteLine(strDeret);
}

static void SubString()
{
    Console.WriteLine("----- Substring -----");

    Console.Write("Masukan Kode : ");
    string kode = Console.ReadLine();
    Console.Write("Masukan Parameter 1 : ");
    int par1 = int.Parse(Console.ReadLine());
    Console.Write("Masukan Parameter 2 : ");
    int par2 = int.Parse(Console.ReadLine());

    if (par2 == 0)
    {
        Console.WriteLine($"Hasil Subtring {kode.Substring(par1)}");
    }
    else if (par1 == 0)
    {
        Console.WriteLine($"Hasil Subtring {kode.Substring(par2)}");
    }
    else
    {
        Console.WriteLine($"Hasil Subtring {kode.Substring(par1, par2)}");
    }


}

static void ToCharArray()
{
    Console.WriteLine("----- Sring To Char Array -----");
    Console.Write("Masukan Kalimat : ");
    string kalimat = Console.ReadLine();

    char[] array = kalimat.ToCharArray();

    foreach (char x in array)
    {
        Console.WriteLine(x);
    }

    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

}

static void ConvertStringArrayToInt()
{
    Console.WriteLine("----- Convert String Array to Int -----");
    Console.Write("Masukan Input Number (Pakai Spasi) : ");
    string input = Console.ReadLine();

    int sum = 0;

    string[] array = input.Split(" ");

    foreach (string str in array)
    {
        sum += int.Parse(str);
    }
    Console.WriteLine($"Jumlah = {sum}");

}

static void ConvertAll()
{
    Console.WriteLine("----- Convert All -----");
    Console.Write("Masukan Input Number (Pakai Spasi) : ");
    string[] input = Console.ReadLine().Split(" ");

    int sum = 0;

    int[] array =Array.ConvertAll(input, int.Parse);

    foreach (int x in array)
    {
        sum += x;
    }
    Console.WriteLine($"Jumlah = {sum}");
    
}


