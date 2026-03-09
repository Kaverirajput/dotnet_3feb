// class Synchronization_Using_Three_Thread
//    {
//    static object o = new object();

//    static void increment()
//    {
//        lock (o) //lock the object to ensure that only one thread can access the critical section at a time
//                 //other thread will wait until the first thread is completed with the execution

//        {
//            for(int i = 0; i < 10; i++)
//            {
//                Console.WriteLine(Thread.CurrentThread.Name + "Thread is executing" + i);
//            }
          


//        }
//    }
//    public static void Main(String[] args)
//    {
//        Thread user1 = new Thread(increment);
//        Thread user2 = new Thread(increment);
//        Thread user3 = new Thread(increment);
//        user1.Name = "First user";
//        user2.Name = "Second user";
//        user3.Name ="Third user";
//        user1.Start();
//        user2.Start();
//        user3.Start();
//    }
//}
