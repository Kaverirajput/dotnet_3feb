////using System.Security.Cryptography.X509Certificates;

//class ThreadValidation
//{
//    //    //Single thread = multiple task not valid
//    //    //void reversenum()
//    //    //{
//    //    //    for (int i = 20; i > 20; i--)
//    //    //    {

//    //    //        Console.WriteLine(i);
//    //    //    }
//    //    //    void oddnum()
//    //    //    {
//    //    //        int num = 90;
//    //    //        if (num % 2 == 0)
//    //    //        {
//    //    //            Console.WriteLine("Even number");
//    //    //        }
//    //    //        else
//    //    //        {
//    //    //            Console.WriteLine("odd number");
//    //    //        }
//    //    //    }
//    //    //}
//    //    //public static void Main(String[] args)
//    //    //{
//    //    //    ThreadValidation tc = new ThreadValidation();
//    //    //    Thread t1 = new Thread(tc.reversenum, tc.oddnum);
//    //    //    t1.Start();

//    //    //}

//    //    //Multiple thread = single task

//    //    void reversenum()
//    //    {
//    //        for (int i = 20; i > 20; i--)
//    //        {

//    //            Console.WriteLine(i);
//    //        }
//    //    }
//    //    public static void Main(String[] args)
//    //    {
//    //        ThreadValidation tc = new ThreadValidation();
//    //        Thread t1 = new Thread(tc.reversenum);
//    //        t1.Start();
//    //        Thread t2 = new Thread(tc.reversenum);
//    //        t2.Start();
//    //    }

//    //multiple thread = multiple task

   
//    void reversenum()
//    {
//        for (int i = 20; i >= 1; i--)
//        {
//            Console.WriteLine("Reverse: " + i);
//        }
//    }

//    void oddnum()
//    {
//        int num = 90;

//        if (num % 2 == 0)
//        {
//            Console.WriteLine("Even Number");
//        }
//        else
//        {
//            Console.WriteLine("Odd Number");
//        }
//    }

//    public static void Main(string[] args)
//    {
//        ThreadValidation tc = new ThreadValidation();

//        Thread t1 = new Thread(tc.reversenum);
//        Thread t2 = new Thread(tc.oddnum);

//        t1.Start();
//        t2.Start();
//    }
//}