//using System;
//using System.Collections;
//using System.Collections.Generic;

//class Non_Generic_Collection
//{
//    void ng_generic()
//    {
//        ArrayList al = new ArrayList(); //ArrayList is a non-generic collection that can hold any type of data
//        al.Add(10); //adds an integer to the ArrayList
//        al.Add("Hello"); //adds a string to the ArrayList
//        al.Add(3.14); //adds a double to the ArrayList
//        for (int i = 0; i < al.Count; i++)
//        {
//            Console.WriteLine(al[i]); //prints each element in the ArrayList

//        }
//        Console.WriteLine("contains 10 ?? " + al.Contains(10));

//        Console.WriteLine("index of Hello ?? " + al.IndexOf("Hello"));

//        Console.WriteLine("Count of elements in ArrayList: " + al.Count);

//        al.Insert(1, "World"); //inserts a string at index 1 in the ArrayList

//        al.Remove(3.14); //removes the double value from the ArrayList

//        al.RemoveAt(0); //removes the element at index 0 from the ArrayList

//        al.LastIndexOf("Hello"); //returns the last index of the string "Hello" in the ArrayList

//        al.Reverse(); //reverses the order of the elements in the ArrayList

//        Console.WriteLine("---------------------------");

//        for (int i = 0; i < al.Count; i++)
//        {
//            Console.WriteLine(al[i]); //prints each element in the ArrayList

//        }


//        al.Clear(); //clears all the elements from the ArrayList
//    }

//    public static void Main(string[] args)
//    {
//        Non_Generic_Collection c = new Non_Generic_Collection();
//        c.ng_generic();
//    }


//}
