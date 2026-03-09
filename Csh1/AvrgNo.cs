//using System;

//class AvrgNo
//{
//    public static void Main(String[] args)
//    {
//        Console.WriteLine("Enter number of values:");
//        int n = int.Parse(Console.ReadLine());

//        int[] numbers = new int[n];   // store numbers

//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("Enter Number:");
//            numbers[i] = int.Parse(Console.ReadLine());
//        }

//        AverageNu(numbers, n);
//    }

//    static void AverageNu(int[] arr, int n)
//    {
//        int sum = 0;

//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + arr[i];   // add actual numbers
//        }

//        double avg = sum / n;   // correct average
//        Console.WriteLine("Average = " + avg);
//    }
//}
