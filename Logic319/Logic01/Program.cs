// 

//Konversi();
//OperatorAritmatika();
//modulus();
//OperatorPenugasan();
//OperatorPerbandingan();
//OperatorLogika();
//MethodeReturnType();


Console.ReadKey();

static void MethodeReturnType()
{
    Console.WriteLine("-----Method Return Type");
    Console.Write("Masukan Mangga : ");
    int mangga = int.Parse(Console.ReadLine());

    Console.Write("Masukan apel : ");
    int apel = int.Parse(Console.ReadLine());

    int jumlah = hasil(mangga, apel);

    Console.WriteLine($"Hasilnya adalah : {jumlah}");
}

static int hasil(int mangga, int apel)
{
    int hasil = 0;

    hasil = mangga + apel;
    return hasil;
}

static void OperatorLogika()
{

    Console.WriteLine("-----Operator Logika-----");

    Console.Write("Masukan Umur Kamu : ");
    int age = int.Parse(Console.ReadLine());

    Console.Write("Masukan Password : ");
    string password = Console.ReadLine();

    bool isAdult = age > 18;
    bool isPasswordValid = password == "admin";

    if(isAdult && isPasswordValid)
    {
        Console.WriteLine("Selmat Datang Kamu");
    }
    else
    {
        Console.WriteLine("Sorry, Silahkan Kenbali");
    }
}

static void OperatorPerbandingan()
{
    int mangga, apel = 0;

    Console.WriteLine("-----Operator Perbandingan-----");
    
    Console.Write("Masukan Mangga : ");
    mangga = int.Parse(Console.ReadLine());

    Console.Write("Masukan Apel : ");
    apel = int.Parse(Console.ReadLine());

    Console.WriteLine("Hasil Perbandingan : ");
    Console.WriteLine($"Mangga > Apel : {mangga > apel}");
    Console.WriteLine($"Mangga >= Apel : {mangga >= apel}");
    Console.WriteLine($"Mangga < Apel : {mangga < apel}");
    Console.WriteLine($"Mangga <= Apel : {mangga <= apel}");
    Console.WriteLine($"Mangga == Apel : {mangga == apel}");
    Console.WriteLine($"Mangga != Apel : {mangga != apel}");

}

static void OperatorPenugasan()
{
    int mangga = 15, apel = 8;

    Console.WriteLine("-----Operator Penugasan-----");

    // isi ualang variable
    mangga = 15;

    Console.Write("Masukan Mangga : ");
    mangga = int.Parse(Console.ReadLine());
    Console.WriteLine($"Mangga = {mangga}");

    Console.Write("Masukan Apel : ");
    apel = int.Parse(Console.ReadLine());

    //operator penugasan
    apel += 6;
    Console.WriteLine($"Apel +=6 : {apel}");
}

static void modulus()
{
    int mangga, orang, hasil = 0;

    Console.WriteLine("-----Modulus-----");
    Console.Write("Masukan Mangga : ");
    mangga = int.Parse(Console.ReadLine());
    Console.Write("Masukan Orang : ");
    orang = int.Parse(Console.ReadLine());

    hasil = mangga % orang;

    Console.WriteLine($"Hasil Mangga % Orang = {hasil}");
}

static void OperatorAritmatika()
{
    int mangga, apel, hasil = 0;

    Console.WriteLine("-----Operator Aritmatika-----");
    Console.Write("Masukan Mangga : ");
    mangga = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Masukan Apel : ");
    apel = int.Parse(Console.ReadLine());

    hasil = mangga + apel;

    Console.WriteLine($"Hasil Mangga + Apel = {hasil}");
}

static void Konversi()
{
    Console.WriteLine("----- Konversi -----");
    int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;

    string strMyInt = Convert.ToString(myInt); //Convert Int Ke String
    string strMyInt2 = myInt.ToString();

    Console.WriteLine(strMyInt);
    Console.WriteLine(strMyInt2);
    Console.WriteLine(Convert.ToDouble(myInt));
    Console.WriteLine(Convert.ToInt32(myDouble));
    Console.WriteLine(Convert.ToString(myBool));

}



