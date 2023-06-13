

FungsiMath();



Console.ReadKey();


static void FungsiMath()
{
    Console.WriteLine("----- Fungsi Math -----");
    Console.Write("Masukan Input Angka : ");
    decimal angka = decimal.Parse(Console.ReadLine());

    Console.WriteLine($"Hasil Fungsi Abs : {Math.Abs(angka)}");
    Console.WriteLine($"Hasil Fungsi Round : {Math.Round(angka)}");
    Console.WriteLine($"Hasil Fungsi Round 2 Digit Decimal : {Math.Round(angka,2)}");
    Console.WriteLine($"Hasil Fungsi Round 2 Digit Decimal Bulatinnya kebawah : {Math.Round(angka,2, MidpointRounding.ToNegativeInfinity)}");
    Console.WriteLine($"Hasil Fungsi Round 2 Digit Decimal Bulatinnya keatas : {Math.Round(angka,2, MidpointRounding.ToPositiveInfinity)}");
    Console.WriteLine($"Hasil Fungsi Pow : {Math.Pow(Convert.ToDouble(angka), 2)}");
}