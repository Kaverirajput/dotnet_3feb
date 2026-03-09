//class ThreadMethodSleepJoin
//{
//    static void serialnum()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine(Thread.CurrentThread.Name + ":-" + i);
//            Thread.Sleep(1000);
//        }
//    }
//    public static void Main(String[] args)
//    {
//        Thread anita = new Thread(serialnum);
//        anita.Name = "first thread";
//        anita.Start();
//        anita.Join(); //waits for the thread to complete before moving to the next line of code


//        Thread kavita = new Thread(serialnum);
//        kavita.Name = "second thread";
//        kavita.Start();

//    }
//}
