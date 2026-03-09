//using System;

//class ReverseNum
//{
//    public static void Main(String[] args)
//    {
//        Console.WriteLine("Enter number:");
//        int num = int.Parse(Console.ReadLine());

//        ReverseNum obj = new ReverseNum();   // object

//        int rev = obj.Reverse(num);   // method call

//        Console.WriteLine("Reverse = " + rev);
//    }

//    // non-static return type method
//    public int Reverse(int n)
//    {
//        int r = 0;

//        for (int i = n; i > 0; i = i / 10)
//        {
//            r = r * 10 + (i % 10);   
//        }

//        return r;
//    }
//}
