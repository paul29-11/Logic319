// OOP


using Logic06;

//AbstrakClass();
//ObjekClass();
//Constructor();
//Encapsulation();
//Inheritance();
//Overriding();

Console.ReadKey();

static void AbstrakClass()
{
    Console.WriteLine("----- Abstrak Class -----");

    Console.Write("Masukan Input x : ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Masukan Input y : ");
    int y = int.Parse(Console.ReadLine());
    TestTurunan calc = new TestTurunan();
    int jumlah = calc.jumlah(x, y);
    int kuraang = calc.kurang(x, y);

    Console.WriteLine($"Hasil {x} + {y} = {jumlah}");
    Console.WriteLine($"Hasil {x} - {y} = {kuraang}");
}

static void ObjekClass()
{
    Console.WriteLine("----- Objek Class -----");

    Mobil mobil = new Mobil() { nama = "SUPRA GTR", kecepatan = 0, bensin = 10, posisi =0 };
    mobil.platno = "B 123 GTR";

    mobil.percepat();
    mobil.maju();
    //mobil.isiBensin(mobil.bensin);
    mobil.isiBensin(20);
    mobil.utama();




}

static void Constructor()
{
    Console.WriteLine("----- Constructor -----");
    Mobil mobil = new Mobil("B 122 xXx");

    //string platno = mobil.platno;
    string platno = mobil.getPlatNo();

    Console.WriteLine($"Mobil dengan Nomor Polisi : {platno}");
}

static void Encapsulation()
{
    Console.WriteLine("----- Encapsulation ------");

    PersegiPanjang pp = new PersegiPanjang();

    pp.panjang = 4.5;
    pp.lebar = 3.5;

    pp.TampilkanData();

}

static void Inheritance()
{
    Console.WriteLine("----- Inheritance -----");

    TypeMobil typeMobil = new TypeMobil();
    typeMobil.Civic();
    //typeMobil.utama();

}

static void Overriding()
{
    Console.WriteLine("----- Overriding -----");

    Kucing kucing = new Kucing();
    Paus paus = new Paus();
    //Console.Write("Kucing"); kucing.pindah();
    kucing.pindah();
    Console.WriteLine($"Kucing {kucing.pindah()} ");
    Console.WriteLine($"Paus {paus.pindah()} ");
}