
//quiz01();
//quiz02();
//quiz03();
//quiz04();
//quiz05();
//quiz06();
//quiz07();
//quiz08();

Console.ReadKey();


static void quiz01()
{
    Console.WriteLine("----- Quiz 01 -----");

    Console.Write("Masukan Nilai (0-100) : ");
    string input = Console.ReadLine();

    if (input =="")
    {
        Console.WriteLine("Masukan Nilai, Tidak Boleh Kodong !!!");
    }
    else if (!input.All(char.IsDigit))
    {
        Console.WriteLine("Tolong Masukan angka");
    }
    else
    {
        int nilai = 0;
        nilai = Convert.ToInt32(input);
        if (nilai >= 90 && nilai <= 100)
        {
            Console.WriteLine($"Nilai {nilai} Memiliki Grade A");
        }
        else if (nilai >= 70 && nilai < 90)
        {
            Console.WriteLine($"Nilai {nilai} Memiliki Grade B");
        }
        else if (nilai >= 50 && nilai < 70)
        {
            Console.WriteLine($"Nilai {nilai} Memiliki Grade C");
        }
        else if (nilai < 50)
        {
            Console.WriteLine($"Nilai {nilai} Memiliki Grade E");
        }
        else
        {
            Console.WriteLine("Nilai Tidak Valid");
        }
    }

}

static void quiz02()
{
    Console.WriteLine("----- Quiz 02 -----");

    bool ulangi = true;

    while (ulangi)
    {
        Console.Write("Masukan Jumlah Pulsa : ");
        int pulsa = int.Parse(Console.ReadLine());

        if (pulsa >= 10000 && pulsa < 25000)
        {
            Console.WriteLine($"Point Yang didapat dari isi pulsa {pulsa} adalah : 80");
        }
        else if (pulsa >= 25000 && pulsa < 50000)
        {
            Console.WriteLine($"Point Yang didapat dari isi pulsa {pulsa} adalah : 200");
        }
        else if (pulsa >= 50000 && pulsa < 100000)
        {
            Console.WriteLine($"Point Yang didapat dari isi pulsa {pulsa} adalah : 400");
        }
        else if (pulsa >= 100000)
        {
            Console.WriteLine($"Point Yang didapat dari isi pulsa {pulsa} adalah : 400");
        }
        else
        {
            Console.WriteLine("Pulsa Anda Tidak Masuk Kekategori Point");
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
        Console.Write("Masukan Total Belanja Anda : ");
        int belanja = int.Parse(Console.ReadLine());
        Console.Write("Masukan Jarak : ");
        int jarak = int.Parse(Console.ReadLine());
        Console.Write("Masukan Promo : ");
        string promo = Console.ReadLine();

        if (belanja >= 30000)
        {
            if (promo == "JKTOVO")
            {
                if (jarak <= 5)
                {
                    int ongkir = 5000;
                    int diskon1 = belanja * 40 / 100;
                    int total = belanja - diskon1 + ongkir;

                    Console.WriteLine($"Jarak \t : {jarak}");
                    Console.WriteLine($"Belanja \t : {belanja}");
                    Console.WriteLine($"Diskon 40% \t : {diskon1}");
                    Console.WriteLine($"Ongkir \t : {ongkir}");
                    Console.WriteLine($"Total \t : {total}");
                }
                else if (jarak > 5)
                {
                    int ongkir = jarak * 1000;
                    int diskon1 = belanja * 40 / 100;
                    int total = belanja - diskon1 + ongkir;

                    Console.WriteLine($"Jarak \t : {jarak}");
                    Console.WriteLine($"Belanja \t : {belanja}");
                    Console.WriteLine($"Diskon 40% \t : {diskon1}");
                    Console.WriteLine($"Ongkir \t : {ongkir}");
                    Console.WriteLine($"Total \t : {total}");

                }

            }
            else
            {
                int ongkir = jarak * 1000;
                int total = belanja + ongkir;

                Console.WriteLine($"Belanja \t : {belanja}");
                Console.WriteLine($"Diskon 40% \t : - ");
                Console.WriteLine($"Ongkir \t : {ongkir}");
                Console.WriteLine($"Total \t : {total}");
            }

        }
        else if (jarak <= 5)
        {
            int ongkir = 5000;
            int total = belanja + jarak;

            Console.WriteLine($"Belanja \t : {belanja}");
            Console.WriteLine($"Diskon 40% \t : - ");
            Console.WriteLine($"Ongkir \t : {ongkir}");
            Console.WriteLine($"Total \t : {total}");
        }
        else
        {
            int ongkir = jarak * 1000;
            int total = belanja + jarak;

            Console.WriteLine($"Belanja \t : {belanja}");
            Console.WriteLine($"Diskon 40% \t : - ");
            Console.WriteLine($"Ongkir \t : {ongkir}");
            Console.WriteLine($"Total \t : {total}");
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

    try
    {
        bool ulangi = true;

        while (ulangi)
        {
            Console.Write("Masukan Total Belanja : ");
            int belanja = int.Parse(Console.ReadLine());
            Console.Write("Masukan Ongkos Kirim : ");
            int ongkos = int.Parse(Console.ReadLine());
            Console.Write("Pilih Voucer (1/2/3/) : ");
            int voucer = int.Parse(Console.ReadLine());

            int diskon_ongkir = 0;
            int diskon_belanja = 0;

            switch (voucer)
            {
                case 1:
                    if (belanja >= 30000)
                    {

                        diskon_ongkir = 5000;
                        diskon_belanja = 5000;

                        diskon_ongkir = diskon_ongkir > ongkos ? ongkos : diskon_ongkir;

                    }
                    else
                    {
                        Console.WriteLine("Maaf Anda Tidak Mendapatkan Diskon");
                    }

                    break;
                case 2:
                    if (belanja >= 50000)
                    {
                        diskon_ongkir = 10000;
                        diskon_belanja = 10000;

                        diskon_ongkir = diskon_ongkir > ongkos ? ongkos : diskon_ongkir;
                    }
                    else
                    {
                        Console.WriteLine("Maaf Anda Tidak Mendapatkan Diskon");
                    }
                    break;
                case 3:
                    if (belanja >= 100000)
                    {
                        diskon_ongkir = 25000;
                        diskon_belanja = 10000;

                        diskon_ongkir = diskon_ongkir > ongkos ? ongkos : diskon_ongkir;
                    }
                    else
                    {
                        Console.WriteLine("Maaf Anda Tidak Mendapatkan Diskon");
                    }
                    break;
                default:
                    Console.WriteLine("Maaf Anda Tidak Mendapatkan Diskon");
                    break;

            }
            Console.WriteLine($"Belanja \t\t : {belanja}");
            Console.WriteLine($"Ongkos Kirim \t\t : {ongkos}");
            Console.WriteLine($"Diskon Ongkir  \t\t : {diskon_ongkir}");
            Console.WriteLine($"Diskon Belanja  \t : {diskon_belanja}");
            Console.WriteLine($"Total Belanja  \t\t : {(belanja - diskon_belanja) + (ongkos - diskon_ongkir)}");

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

        Console.WriteLine("Harus Angka dan Tidak Boleh Kosong");
        Console.WriteLine(e.Message);
    }

    

    
}

static void quiz05()
{
    Console.WriteLine("----- Quiz 05 -----");
    atas:
   
        Console.Write("Masukan Nama Anda : ");
        string nama = Console.ReadLine();
        Console.WriteLine("Tahun Berapa Anda Lahir : ");
        int umur = int.Parse(Console.ReadLine());

        if (umur >= 1944 && umur <= 1964)
        {
            Console.WriteLine($"{nama}, Berdasarkan tahun lahir anda tergolong Generasi Baby Boomer");
            goto atas;
        }
        else if (umur >= 1965 && umur <= 1979)
        {
            Console.WriteLine($"{nama}, Berdasarkan tahun lahir anda tergolong Generasi X");
            goto atas;
        }
        else if (umur >= 1980 && umur <= 1994)
        {
            Console.WriteLine($"{nama}, Berdasarkan tahun lahir anda tergolong Generasi Y");
            goto atas;
        }
        else if (umur >= 1995 && umur <= 2015)
        {
            Console.WriteLine($"{nama}, Berdasarkan tahun lahir anda tergolong Generasi Z");
            goto atas;
        }

        else
        {
            Console.WriteLine($"{nama}, Berdasarkan tahun lahir anda Belum Tergenerasi");
            goto atas;
        }

}

static void quiz06()
{
    Console.WriteLine("----- Quiz 06 -----");

    bool ulangi = true;

    while (ulangi)
    {
        Console.Write("Masukan Nama : ");
        string nama = Console.ReadLine();
        Console.Write("Masukan Tunjangan : ");
        int tunjangan = int.Parse(Console.ReadLine());
        Console.Write("Masukan Gapok : ");
        int gapok = int.Parse(Console.ReadLine());
        Console.Write("Masukan Banyak Bulan : ");
        int bulan = int.Parse(Console.ReadLine());


        double total_pajak = 0;
        double pendapatan = gapok + tunjangan;

        if (gapok >= 0 && gapok <= 5000000 && tunjangan <= 5000000)
        {
            total_pajak = 0.05 * pendapatan;
        }
        else if (gapok > 5000000 && gapok <= 10000000)
        {
            double p = 0.1;
            total_pajak = 0.1 * pendapatan;
        }
        else if (gapok > 10000000)
        {
            double p = 0.15;
            total_pajak = 0.15 * pendapatan;
            
        }
        else
        {
            Console.WriteLine("Mohon Maaf Gaji Pokok Yang Anda Masukan Tidak Valid");
        }
        double bpjs = 0.03 * pendapatan;
        double gaji = pendapatan - (total_pajak + bpjs);
        double totalgaji = gaji * bulan;

        Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut: ");
        Console.WriteLine($"Pajak \t\t\t\t: Rp. {total_pajak}");
        Console.WriteLine($"BPJS \t\t\t\t: Rp. {bpjs}");
        Console.WriteLine($"Gaji/Bln \t\t\t: Rp. {gaji}");
        Console.WriteLine($"Total Gaji/Banyaknya Bulan \t: Rp. {totalgaji}");

        Console.WriteLine();
        Console.WriteLine("Ulangi Proses ? (y/n) ");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            ulangi = false;
        }
    }

}
static float HitungBmi(int berat, float tinggi2)
{
    float bmi = berat / (tinggi2 * tinggi2);
    return bmi;
}
static void quiz07()
{
    Console.WriteLine("----- Quiz 07 -----");
    try
    {
        bool ulangi = true;

        while (ulangi)
        {
            Console.Write("Masukan Berat Badan Anda : ");
            int berat = int.Parse(Console.ReadLine());
            Console.Write("Masukan Tinggi Badan Anda : ");
            int tinggi = int.Parse(Console.ReadLine());

            float tinggi2 = (float)tinggi / 100;

            float bmi = HitungBmi(berat, tinggi2);

            if (bmi >= 0 && bmi < 18.5)
            {
                Console.WriteLine($"Nilai BMI Anda Adalah : {bmi}");
                Console.WriteLine("Anda Termasuk Berbadan Terlalu Kurus");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine($"Nilai BMI Anda Adalah : {bmi}");
                Console.WriteLine("Anda Termasuk Berbadan Langsing");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine($"Nilai BMI Anda Adalah : {bmi}");
                Console.WriteLine("Anda Termasuk Berbadan Gemuk");
            }
            else
            {
                Console.WriteLine($"Nilai BMI Anda Adalah : {bmi}");
                Console.WriteLine("Anda Belum masuk kedalam kategori");
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

        Console.WriteLine("Masukan Harus angka dan tidak boleh kosong");
        Console.WriteLine(e.Message); 
    }

    

}

static void quiz08()
{
    Console.WriteLine("----- Quiz 08 -----");

    //try
    //{
        bool ulangi = true;

        while (ulangi)
        {
            Console.Write("Masukan Nilai MTK : ");
            int mtk = int.Parse(Console.ReadLine());
            Console.Write("Masukan Nilai Fisika : ");
            int fisika = int.Parse(Console.ReadLine());
            Console.Write("Masukan Nilai Kimia : ");
            int kimia = int.Parse(Console.ReadLine());

        float rata = (float)(mtk + fisika + kimia) / 3f;
        //double rata = (mtk + fisika + kimia) / 3d;
        Console.WriteLine($"Nilai Rata-Rata = {rata}");

            if (rata >= 50 && rata <= 100)
            {
                Console.WriteLine("Selamat \nKamu Berhasil\n");
            }
            else if (rata >= 0 && rata < 50)
            {
                Console.WriteLine("Maaf \nKamu Gagal");
            }
            else
            {
                Console.WriteLine("Nilai Rata Rata Kamu Tidak Termasuk Kategori");
            }

            Console.WriteLine();
            Console.WriteLine("Ulangi Proses ? (y/n) ");
            string input = Console.ReadLine();

            if (input.ToLower() == "n")
            {
                ulangi = false;
            }
        }
    //}
    //catch (Exception e)
    //{
    //    Console.WriteLine("Masukan Harus Angka dan tidak boleh kosong !!!");
    //}

}
    
