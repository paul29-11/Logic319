// ---------- Logic Day 04 ----------

using ConsoleApp8;


//InisialisasiArray();
//MengaksesElementArray();
//Array2Dimensi();
//InisialisasiList();
//PanggilClassStudent();
//MengaksesElementList();
//InsertList();
//RemoveList();
IndexElementList();

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
    intStaticArray[0] =1;
    intStaticArray[1] =2;
    intStaticArray[2] =3;

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

    int[,] array = new int[3,3]
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

static void PanggilClassStudent()
{
    Console.WriteLine("----- Panggil Class Student -----");
    List<Student> students = new List<Student>()
    {
        new Student(){Id = 1, Name = "John Doe"},
        new Student(){Id = 2, Name = "Jane Doe"},
        new Student(){Id = 3, Name = "Joe Doe"}
    };

    Console.WriteLine($"Panjang Data list Student = {students.Count}");

    foreach (Student item in students)
    {
        Console.WriteLine($"Id : {item.Id}, Name : {item.Name}");
    }

}

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
        Console.WriteLine($"Element is Found at index {index}");

    }

    
}
