// Logic Quiz Day 08

using System;
using System.Diagnostics.Contracts;

//quiz01();
//quiz02();
//quiz03();
//quiz04();
//quiz05();
//quiz06();
//quiz07();
//quiz08();
//quiz09();
quiz10();


Console.ReadLine();

static void quiz01()
{
    Console.WriteLine("----- Quiz 01 -----");

    Console.Write("Masukan Nilai x : ");
    int x = int.Parse(Console.ReadLine());

    string tampung = "";

    int faktorial = 1;

    for (int i = x; i >= 1; i--)
    {
        //if (i == 1)
        //{
        //    Console.Write($"{i}" );
        //}
        //else
        //{
        //    Console.Write($"{i} x ");
        //}
        faktorial *= i;
        tampung += i == 1 ? i.ToString() : i.ToString() + " x "; 
    }
    Console.WriteLine($"{tampung} = {faktorial} ");
}

static void quiz02()
{
    Console.WriteLine("----- Quiz 02 -----");

    Console.Write("Masukan Input : ");
    string x = Console.ReadLine().ToUpper();
    char[] xArr = x.ToCharArray();

    int hitung = 0;
    int hitungs = 0;
    string tampung = "";
    
    if (x.Length % 3 == 0) 
    {
        for (int i = 0; i < x.Length; i += 3)
        {
            if (x.Substring(i, 3) != "SOS")
            {
                tampung += "SOS";
                hitung++;
            }
            else
            {
                tampung += "SOS";
                hitungs++;

            }
        }
        Console.WriteLine("SOS yang salah Sebanyak : " + hitung);
        Console.WriteLine("SOS yang benar Sebanyak : " + hitungs);
        Console.WriteLine($"Sinyal Yang Benar : {tampung}");
        Console.WriteLine($"Sinyal Yang Masuk : {x}");

    }
    else
    {
        Console.WriteLine($"Gagal, Code Kurang");
    }

}

static void quiz03()
{
    Console.WriteLine("----- Quiz 03 -----");

    Console.Write("Masukan Tanggal Awal (dd--MM-yyyy) : ");
    string awal = Console.ReadLine();
    DateTime tgl_awal = DateTime.ParseExact(awal, "dd-MM-yyyy", null);
    string tgl_awal_baru = tgl_awal.ToString("dd/MM/yyyy");

    Console.Write("Masukan Tanggal AKhir (dd--MM-yyyy) : ");
    string akhir = Console.ReadLine();
    DateTime tgl_akhir = DateTime.ParseExact(akhir, "dd-MM-yyyy", null);
    string tgl_akhir_baru = tgl_awal.ToString("dd/MM/yyyy");

    Console.Write("Masukan Tanggal Toleransi : ");
    int toleransi = int.Parse(Console.ReadLine());

    TimeSpan ts = new TimeSpan();
    ts = tgl_akhir.Subtract(tgl_awal);
    string tss = ts.ToString("dd");    

    int tgl_lebih = int.Parse(tss);
    int denda = 500;
    int total_denda = 0;

    if (tgl_lebih > toleransi)
    {
        total_denda = (tgl_lebih - toleransi) * denda;
        Console.WriteLine("Anda Sudah Kelewatan Batas");
    }
    else
    {
        Console.WriteLine("Anda Tidak Terkena Denda");
    }

    Console.WriteLine($"Total Dendanya Adalah : {total_denda}");

    
}

static void quiz04()
{
    Console.WriteLine("----- Quiz 04 -----");

    Console.Write("Masukan Tanggal Mulai (dd/MM/yyyy) : ");
    int[] arrTglMulai = Array.ConvertAll(Console.ReadLine().Split('/'), int.Parse);
    DateTime tglMulai = new DateTime(arrTglMulai[2] , arrTglMulai[1], arrTglMulai[0]);

    Console.Write("Masukan Lama Kelas (hari) : ");
    int lamaKelas = int.Parse(Console.ReadLine());

    Console.Write("Masukan Hari libur (,) \t: ");
    int[] arrHariLibur = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

    DateTime tglTampung = tglMulai.AddDays(-1);

    for (int i = 0; i < lamaKelas; i++)
    {
     
        // Cek Hari Libur
        for (int j = 0; j < arrHariLibur.Length; j++)
        {
            if (tglTampung.Day == arrHariLibur[j])
            {
                tglTampung = tglTampung.AddDays(1);

                if (tglTampung.DayOfWeek == DayOfWeek.Saturday)
                {
                    tglTampung = tglTampung.AddDays(2);
                }
            }
        }

        tglTampung = tglTampung.AddDays(1);

        // Cek Sabtu & Minggu
        if (tglTampung.DayOfWeek == DayOfWeek.Saturday)
        {
            tglTampung = tglTampung.AddDays(2);
        }
    }

    DateTime tglUjianFT1 = tglTampung.AddDays(1);

    if (tglUjianFT1.DayOfWeek == DayOfWeek.Saturday)
    {
        tglUjianFT1 = tglUjianFT1.AddDays(2);

    }

    Console.WriteLine($"Kelas Akan Ujian FT1 Pada = {tglUjianFT1.ToString("dd/MM/yyyy")} ");


    //string mulai = Console.ReadLine();
    //DateTime tgl_mulai = DateTime.ParseExact(mulai, "dd/MM/yyyy", null);
    //string tgl_mulai_baru = tgl_mulai.ToString("dd");
    //string tgl_mulai_baru1 = tgl_mulai.ToString("dd//MM/yyyy");


    //Console.Write("Masukan hari libur : ");
    //string libur = Console.ReadLine();

    //int[] liburArr = Array.ConvertAll(libur.Split(','), int.Parse);

    //int tglMulai = int.Parse(tgl_mulai_baru);

    //int hasil = 0 ;

    //var ts = " ";
    //for (int i = 1; i <= 10; i++)
    //{
    //    for (int j = 1; j <= liburArr.Length; j++)
    //    {
    //        tgl_mulai.AddDays(i);
    //    }
    //}

    //Console.WriteLine("Kelas akan ujian pada : " + tgl_mulai.ToString("dd/MM/yyyy"));

}

static void quiz05()
{
    Console.WriteLine("----- Quiz 05 -----");

    Console.Write("Masukan Kalimat : ");
    string kalimat = Console.ReadLine();


    //string baru = kalimat.Replace(" ", "");
    
    //string vo = "aieuoAIEUO";
    //char[] namaArr = baru.ToCharArray();

    int hivo = 0;
    int konso = 0;

    for (int i = 0; i < kalimat.Length; i++)
    {
        char huruf = char.ToLower(kalimat[i]);

        if (huruf >= 'a' &&  huruf <= 'z')
        {
            if (huruf == 'a' || huruf == 'i' || huruf == 'u' || huruf == 'e' || huruf == 'o')
            {
                hivo++;
            }
            else
            {
                konso++;
            }
        }

        //if (vo.Contains(namaArr[i]))
        //{
        //    hivo += 1;
        //}
        //else 
        //{
        //    konso += 1;
        //}
       
    }
    Console.WriteLine();
    Console.WriteLine($"Jumlah Vokal \t\t: {hivo}");
    Console.WriteLine($"Jumlah konsonan \t: {konso}");

    Console.ReadKey();

}

static void quiz06()
{
    Console.WriteLine("----- Quiz 06 -----");

    Console.Write("Masukan Nama : ");
    string nama = Console.ReadLine().ToLower().Replace(" ", "");

    char[] namaArr = nama.ToCharArray();

    foreach (char x in namaArr)
    {
        Console.WriteLine($"***{x}***");
    }
    
}

static void quiz07()
{
    Console.WriteLine("----- Quiz 07 -----");

    Console.Write("Masukan Total Menu : ");
    int menu = int.Parse( Console.ReadLine() );

    Console.Write("Masukan Index Alergi : ");
    int alergi = int.Parse(Console.ReadLine());

    Console.Write("Masukan Harga Menu : ");
    string harga = Console.ReadLine();

    Console.Write("Masukan Uang Elsa : ");
    int uang_elsa = int.Parse(Console.ReadLine());

    //Console.WriteLine(hargaArr[1]);
    int[] h = Array.ConvertAll(harga.Split(','), int.Parse);

    int hasil = 0;
    int alerginya = h[alergi];
    int total = 0;

    foreach (int i in h)
    {
        hasil += i;
    }
    total = (hasil - alerginya)/2;
    int sisa = uang_elsa - total;

    Console.WriteLine($"Elsa Harus Membayar : {total} ");
    

    if (total == uang_elsa)
    {
        Console.WriteLine("Uang Elsa PAS BANGET");
    }
    else if (uang_elsa > total) 
    {
        Console.WriteLine($"Sisa Uang Elsa : {sisa} ");
    }
    else if(uang_elsa < total) 
    {
        Console.WriteLine($"Pembayaran Kurang {sisa}");
    }
}

static void quiz08()
{
    Console.WriteLine("----- Quiz 08 -----");

    Console.Write("Masukan Angka : ");
    int angka = int.Parse(Console.ReadLine());
    int a = angka;
    for (int i = 0; i < angka; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < angka; j++)
        {
            if (j == a-1)
            {
                Console.Write("*");
                a--;
            }
            else if (j >= a-1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        } 
    }
}

static void quiz09()
{
    Console.WriteLine("----- Quiz 09 -----");

    //Console.Write("Masukan 9 Bilangan Bulat: ");
    int[,] angkaArr = { 
        { 11, 2, 4 }, // (0,0) (0,1) (0,2)
        { 4, 5, 6 },  // (1,0) (1,1) (1,2)
        { 10, 8, -12 } //(2,0) (2,1) (2,2)
    };

    int diagonalPertama = 0;
    int diagonalKedua = 0;
    string dayaTampung1 = "";
    string dayaTampung2 = "";
    for (int i = 0; i < angkaArr.GetLength(0); i++)
    {
        for (int j = 0; j < angkaArr.GetLength(1); j++)
        {
            if (i == j)
            {
                diagonalPertama += angkaArr[i,j];
                dayaTampung1 += dayaTampung1 == "" ?  angkaArr[i, j].ToString() : " + " + angkaArr[i,j].ToString();
            }

            if (j == angkaArr.GetLength(1) - 1 - i )
            {
                diagonalKedua += angkaArr[i,j];
                dayaTampung2 += dayaTampung2 == "" ?  angkaArr[i, j].ToString() : " + " + angkaArr[i,j].ToString();

            }

            Console.Write($"{angkaArr[i,j]} \t");
        }
        Console.WriteLine(); 
    }
    int perbedaan = diagonalPertama - diagonalKedua;
   
    Console.WriteLine("------------------------------"); 
    Console.WriteLine($"Diagonal Pertama nya Adalah : {dayaTampung1} = {diagonalPertama}");
    Console.WriteLine($"Diagonal Pertama nya Adalah : {dayaTampung2} = {diagonalKedua}");
    Console.WriteLine($"Perbedaan | {diagonalPertama} - {diagonalKedua} | = {perbedaan} ");
    


}

static void quiz10()
{
    Console.WriteLine("----- Quiz 10 -----");

    Console.Write("Masukan Inputan :");
    string[] angka = Console.ReadLine().Split(' ');

    int[] baru = new int[angka.Length];

    for (int i = 0; i < angka.Length; i++)
    {
        baru[i] = int.Parse(angka[i]);
    }

    int tertinggi = baru[0];
    int angkaTinggi =  0;

    for (int i = 0; i < length; i++)
    {

    }
}