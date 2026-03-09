//class Synchronization
//{
//    static object o = new object();

//    static void increment()
//    {
//        lock (o) //lock the object to ensure that only one thread can access the critical section at a time
//                 //other thread will wait until the first thread is completed with the execution

//        {

//            Console.WriteLine(Thread.CurrentThread.Name + "Thread is executing");


//        }
//    }
//    public static void Main(String[] args)
//    {
//        Thread user1 = new Thread(increment);
//        Thread user2 = new Thread(increment);
//        user1.Name = "First user";
//        user2.Name = "Second user";
//        user1.Start();
//        user2.Start();
//    }

//}

