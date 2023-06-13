
//PadLeft();
//Rekursif();
//RekursifDesc();
RekursifAsc();


Console.ReadKey();

static void PadLeft()
{
    Console.WriteLine("----- Pad Left -----");

    Console.Write("Masukan Input \t\t\t: ");
    int input = int.Parse(Console.ReadLine());
    Console.Write("Masukan Panjang Karakter \t: ");
    int panjang = int.Parse(Console.ReadLine());
    Console.Write("Masukan Karakternya \t\t: ");
    char chars = char.Parse(Console.ReadLine());
    //230600005 -> 2 Digit tahun + 2 digit bulan + generate lenght 

    DateTime date =DateTime.Now;
    string code = "";

    //code = date.ToString("yy") + date.ToString("MM") + input.ToString().PadLeft(panjang, chars);
    code = date.Year.ToString() + date.ToString("MM") + input.ToString().PadLeft(panjang, chars);
    //code = date.ToString("yy") + date.ToString("MM") + input.ToString().PadRight(panjang, chars);

    Console.WriteLine($"Hasil Dari PadLeft \t\t: {code}");

}

static void Rekursif()
{
    Console.WriteLine("----- Rekursif Fungsion (DESC) -----");
    Console.Write(" Masukan Input : ");
    int input = int.Parse(Console.ReadLine());

    // Panggil Fungsi
    Perulangan(input);
}

static int Perulangan(int input)
{
    if (input == 1)
    {
        Console.WriteLine(input);
        return input;
    }

    Console.WriteLine(input);
    return Perulangan(input - 1);

}

static void RekursifDesc()
{
    Console.WriteLine("----- Rekursif Fungsion (DESC) -----");
    Console.Write("Masukan Input Awal : ");
    int start = int.Parse(Console.ReadLine());
    Console.Write("Masukan Input Akhir : ");
    int end = int.Parse(Console.ReadLine());
    if(start <= end)
    {
        // Panggil Fungsi
        PerulanganDesc(start, end);
    }
    else
    {
        Console.WriteLine("Input Awal tidak boleh lebih besar dari input akhir");
    }
}

static int PerulanganDesc(int start, int end)
{
    if (end == start)
    {
        Console.WriteLine(end);
        return end;
    }

    Console.WriteLine(end);
    return PerulanganDesc(start,end - 1);

}

static void RekursifAsc()
{
    Console.WriteLine("----- Rekursif Fungsion (ASC) -----");
    Console.Write("Masukan Input Awal : ");
    int start = int.Parse(Console.ReadLine());
    Console.Write("Masukan Input Akhir : ");
    int end = int.Parse(Console.ReadLine());
    if (start <= end)
    {
        // Panggil Fungsi
        PerulanganAsc(start, end);
    }
    else
    {
        Console.WriteLine("Input Awal tidak boleh lebih besar dari input akhir");
    }
}

static int PerulanganAsc(int start, int end)
{
    if (end == start)
    {
        Console.WriteLine(start);
        return start;
    }

    Console.WriteLine(start);
    return PerulanganAsc(start + 1, end);

}

static void RekursifGabung()
{
    Console.WriteLine("----- Rekursif Fungsion (Gabung) -----");
    Console.Write("Masukan Input Awal : ");
    int start = int.Parse(Console.ReadLine());
    Console.Write("Masukan Input Akhir : ");
    int end = int.Parse(Console.ReadLine());
    if (start <= end)
    {
        // Panggil Fungsi
        PerulanganGabung(start, end, "ASC");
    }
    else
    {
        Console.WriteLine("Input Awal tidak boleh lebih besar dari input akhir");
    }
}

static int PerulanganGabung(int start, int end, string tipe)
{
    if (end == start)
    {
        Console.WriteLine(start);
        return start;
    }

    Console.WriteLine(start);
    return PerulanganGabung(start + 1, end, tipe);

}