//using System;
//using System.Collections;

//class CollectionMethods_Task
//{
//    public static void Main(string[] args)
//    {
//        ArrayList al = new ArrayList();

//        Console.WriteLine("Enter the number of elements you want to add:");
//        int n = int.Parse(Console.ReadLine());

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("Enter item: ");
//            string item = Console.ReadLine();
//            al.Add(item);
//        }

//        Console.WriteLine("Original ArrayList:");
//        for (int i = 0; i < al.Count; i++)
//        {
//            Console.WriteLine(al[i]);
//        }

//        // AddRange
//        string[] items1 = { "Pen", "Book" };  //item add using AddRange
//        al.AddRange(items1);  // add the items in the array to the end of the ArrayList

//        Console.WriteLine("After AddRange: ");
//        for (int i = 0; i < al.Count; i++)
//        {
//            Console.WriteLine(al[i]);
//        }

//        // InsertRange
//        string[] items2 = { "Kurkure", "chocolate" }; //items  inserted
//        al.InsertRange(1, items2);  // at index 1 

//        Console.WriteLine("After InsertRange: ");
//        for (int i = 0; i < al.Count; i++)
//        {
//            Console.WriteLine(al[i]);
//        }

//        // RemoveRange
//        al.RemoveRange(0, 2);

//        Console.WriteLine("After RemoveRange:");
//        for (int i = 0; i < al.Count; i++)
//        {
//            Console.WriteLine(al[i]);
//        }

//        // ToArray
//        object[] arr = al.ToArray();

//        Console.WriteLine("Elements in Array:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.WriteLine(arr[i]);
//        }

//        // ToString
//        Console.WriteLine("ToString Output:");
//        Console.WriteLine(al.ToString());
//    }
//}