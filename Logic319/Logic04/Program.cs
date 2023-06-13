// ---------- Logic Day 04 ----------

//using ConsoleApp8;


//InisialisasiArray();
//MengaksesElementArray();
//Array2Dimensi();
//InisialisasiList();
//PanggilClassStudent();
//MengaksesElementList();
//InsertList();
//RemoveList();
//IndexElementList();
//Datetime();
//ParsingDatetime();
//DatetimeProperties();
//TimeSpan();

Console.ReadKey();


static void InisialisasiArray()
{
    Console.WriteLine("----- Iniliasisasi Arrary -----");

    // Cara 1
    int[] array = new int[5];
    //array = new int[] { 1,2,3,4,5};
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Masukan Data Ke {i + 1} : ");
        array[i] = int.Parse(Console.ReadLine());
    }
    //Cara 2 
    int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
    // Cara 3
    int[] array3 = new int[] { 1, 2, 3, 4, 5 };
    // Cara 4
    int[] array4 = { 1, 2, 3, 4, 5 };
    //Cara 5
    int[] array5;
    array5 = new int[5] { 1, 2, 3, 4, 5 };

    Console.WriteLine(string.Join(" , ", array));
    Console.WriteLine(string.Join(" , ", array2));
    Console.WriteLine(string.Join(" , ", array3));
    Console.WriteLine(string.Join(" , ", array4));
    Console.WriteLine(string.Join(" , ", array5));

}

static void MengaksesElementArray()
{
    Console.WriteLine("----- Mengakses Element Array -----");

    int[] intStaticArray = new int[3];
    intStaticArray[0] = 1;
    intStaticArray[1] = 2;
    intStaticArray[2] = 3;

    Console.WriteLine(intStaticArray[0]);
    Console.WriteLine(intStaticArray[1]);
    Console.WriteLine(intStaticArray[2]);

    int[] array = { 2, 4, 6 };
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

    string[] strArray = new string[]
    {
        "Mahesh Chand",
        "Mike Gold",
        "Dinesh Beniwal"
    };

    foreach (string item in strArray)
    {
        Console.WriteLine(item);
    }
}

static void Array2Dimensi()
{
    Console.WriteLine("----- Array 2 Dimensi -----");

    int[,] array = new int[3, 3]
    {
        { 1, 2, 3},
        { 4, 5, 6},
        { 7, 8, 9}
    };

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine(array[i, j]);
        }
        Console.WriteLine();
    }
}

static void InisialisasiList()
{
    Console.WriteLine("----- Inisialisasi List -----");

    List<string> list = new List<string>()
    {
        "John Doe",
        "Jane Doe",
        "Joe Doe"
    };

    list.Add("Joko Doe");

    Console.WriteLine(string.Join(" , ", list));

}

//static void PanggilClassStudent()
//{
//    Console.WriteLine("----- Panggil Class Student -----");
//    List<Student> students = new List<Student>()
//    {
//        new Student(){Id = 1, Name = "John Doe"},
//        new Student(){Id = 2, Name = "Jane Doe"},
//        new Student(){Id = 3, Name = "Joe Doe"}
//    };

//    Console.WriteLine($"Panjang Data list Student = {students.Count}");

//    foreach (Student item in students)
//    {
//        Console.WriteLine($"Id : {item.Id}, Name : {item.Name}");
//    }

//}

static void MengaksesElementList()
{
    Console.WriteLine("----- Mengakses Element List -----");

    //List<int> list = new List<int>() { 1, 2, 3 };
    List<int> list = new List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);

    Console.WriteLine(list[0]);
    Console.WriteLine(list[1]);
    Console.WriteLine(list[2]);

    foreach (int item in list)
    {
        Console.WriteLine(item);
    }

    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i]);
    }
}

static void InsertList()
{
    Console.WriteLine("----- Insert List -----");

    List<int> list = new List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);

    list.Insert(2, 4);

    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i]);
    }

}

static void RemoveList()
{
    Console.WriteLine("----- Remove List -----");

    List<string> list = new List<string>();
    list.Add("1");
    list.Add("2");
    list.Add("3");
    list.Add("3");

    list.Remove("3"); // Yang Di Remove Valuenya hanya 1 data
    list.RemoveAt(0); // Yang Di Remove Indexnya

    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i]);
    }

}

static void IndexElementList()
{
    Console.WriteLine("----- Index Element List -----");

    List<string> list = new List<string>();
    list.Add("1");
    list.Add("2");
    list.Add("3");
    list.Add("3");

    string item = "3";

    int index = list.IndexOf(item);

    if (index != -1)
    {
        Console.WriteLine($"Element {item} is Found at index {index}");

    }


}

static void Datetime()
{
    Console.WriteLine("----- Date Time ------");

    // 01/01/0001 00.00.000 (Default)
    DateTime dt1 = new DateTime();
    Console.WriteLine(dt1);

    // Tanggal dan Waktu Hari ini
    DateTime dtnow = DateTime.Now;
    Console.WriteLine(dtnow);

    // 
    DateTime dt2 = new DateTime(2023, 6, 2);
    Console.WriteLine(dt2);

    DateTime dt3 = new DateTime(2020, 6, 2, 13, 20, 45);
    Console.WriteLine(dt3);
}

static void ParsingDatetime()
{
    Console.WriteLine("----- Parsing Date Time -----");

    Console.Write("Masukan Date Time (dd/MM/yyyy) :  ");
    string dateString = Console.ReadLine();

    try
    {
        DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", null);
        Console.WriteLine(date);

    }
    catch (Exception e)
    {
        Console.WriteLine("Format Yang Anda Masukan salah");
        Console.WriteLine("Pesan Error : " + e.Message);
        throw;
    }
    //string dateString = "06/02/2023";
}

static void DatetimeProperties()
{
    Console.WriteLine("----- Date Time Properties -----");

    DateTime date = new DateTime(2023, 6, 2, 14, 49, 50);

    int tahun = date.Year; //Memanggil Tahun
    int bulan = date.Month; //Memanggil Bulan
    int hari = date.Day; // Memanggir hari
    int jam = date.Hour;
    int menit = date.Minute;
    int detik = date.Second;
    int weekday = (int)date.DayOfWeek;
    string haruString = date.ToString("dddd");
    string haruString2 = date.DayOfWeek.ToString();

    Console.WriteLine($"Tahun : {tahun}");
    Console.WriteLine($"Bulan : {bulan}");
    Console.WriteLine($"Hari : {hari}");
    Console.WriteLine($"Jam : {jam}");
    Console.WriteLine($"Menit : {menit}");
    Console.WriteLine($"Detik : {detik}");
    Console.WriteLine($"WeekDay : {weekday}");
    Console.WriteLine($"HariString : {haruString}");
    Console.WriteLine($"HariString : {haruString}");
}

static void TimeSpan()
{
    Console.WriteLine("----- Time Span -----");

    DateTime date1 = new DateTime(2016, 1, 10, 11, 20, 30);
    DateTime date2 = new DateTime(2016, 2, 20, 12, 25, 35);

    //Calculate The interval between the two dates
    TimeSpan interval = date2 - date1;
    Console.WriteLine("Nomor Of Days : " + interval.Days);
    Console.WriteLine("Total Nomor Of Days : " + interval.TotalDays);
    Console.WriteLine("Nomor Of Hours : " + interval.Hours);
    Console.WriteLine("Total Nomor Of Hours : " + interval.TotalHours);
    Console.WriteLine("Nomor Of Minutes : " + interval.Minutes);
    Console.WriteLine("Total Nomor Of Minutes : " + interval.TotalMinutes);
    Console.WriteLine("Nomor Of Seconds : " + interval.Seconds);
    Console.WriteLine("Total Nomor Of Seconds : " + interval.TotalSeconds);
    Console.WriteLine("Nomor Of Milliseconds : " + interval.Milliseconds);
    Console.WriteLine("Total Nomor Of Milliseconds : " + interval.TotalMilliseconds);
    Console.WriteLine("Ticks : " + interval.Ticks);


}
