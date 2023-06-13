
//IfStatement();
//IfElseStatement();
//IfElseIfStatement();
//IfNested();
//Ternary();
//Switch();



Console.ReadKey();

static void Switch()
{
    Console.WriteLine("----- Switch -----");

    Console.Write("Pilih buah kesukaan anda (apel/jeruk/pisang) : ");
    string pilihan = Console.ReadLine().ToLower();

    switch (pilihan)
    {
        case "apel":
            Console.WriteLine("Anda Memilih Buah Apel");
            break;
        case "jeruk":
            Console.WriteLine("Anda Memilih Buah Jeruk");
            break;
        case "pisang":
            Console.WriteLine("Anda Memilih Buah Pisang");
            break;
        default:
            Console.WriteLine("Anda Memilih Buah Yang Tidak ada");
            break;
    }
}

static void Ternary()
{
    Console.WriteLine("----- Ternary -----");

    Console.Write("Masukan Nilai x : ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Masukan Niali y : ");
    int y = int.Parse(Console.ReadLine());

    if ( y > x )
    {
        Console.WriteLine("y Lebih Besar daripada x");
    }
    else if (x>y)
    {
        Console.WriteLine("X Lebih Besar daripada y");
    }
    else
    {
        Console.WriteLine("X sama dengan y");
    }

    string z = (y > x) ? "y Lebih Besar daripada x" : (x > y) ? "x Lebih Besar daripada y" : "x sama dengan y";
    Console.WriteLine(z);
}

static void IfNested()
{
    Console.WriteLine("----- IF NESTED -----");

    Console.Write("Masukan Nilai : ");
    decimal nilai = decimal.Parse(Console.ReadLine());

    if (nilai >= 50)
    {
        Console.WriteLine("Kamu Berhasil");

        if (nilai == 100)
        {
            Console.WriteLine("Kamu Keren");
        }
    }
    else
    {
        Console.WriteLine("Kamu Gagal");
    }
}

static void IfElseIfStatement()
{
    Console.WriteLine("----- LOGIKA IF ELSE IF -----");

    Console.Write("Masukan Nilia x :");
    int x = int.Parse(Console.ReadLine());

    if (x == 10)
    {
        Console.WriteLine("Nilai X Sama Dengan 10 ");
    }
    else if (x > 10)
    {
        Console.WriteLine("Nilai X Lebih Besar Dari 10");
    }
    else
    {
        Console.WriteLine("Nnilai X Lebih Kecil Dari 10");
    }
}

static void IfElseStatement()
{
    Console.WriteLine("----- Logika IF ELSE -----");

    Console.Write("Masukan Nilai X : ");
    int x = int.Parse(Console.ReadLine());

    if (x >= 10)
    {
        Console.WriteLine("Nilai X Lebih Dari 10");
    }
    else
    {
        Console.WriteLine("Nilai X Kurang Dari 10");
    }
}

static void IfStatement()
{
    Console.WriteLine("-----Logika IF-----");

    Console.Write("Masukan Nilai X : ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Masukan Nilai Y : ");
    int y = int.Parse(Console.ReadLine());

    if(x>= 10)
    {
        Console.WriteLine("X is greater than or 10");
    }
    if(y <= 5)
    {
        Console.WriteLine("Y is less than or equals 5");
    }
    Console.WriteLine("Press Enter");
}