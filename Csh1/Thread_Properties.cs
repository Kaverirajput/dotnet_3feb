//class Thread_Properties
//{
//    static void displayname()
//    {
//        Console.WriteLine("Both thread is executing");
//        Console.WriteLine("Name of the thread : " + Thread.CurrentThread.Name); //prints the name of the current thread
//        Console.WriteLine("ID of the thread : " + Thread.CurrentThread.ManagedThreadId); //prints the unique identifier of the current thread
//    }
//    public static void Main(String[] args)
//    {
//        Thread t1 = new Thread(displayname);
//        Console.WriteLine(t1.IsAlive); //checks if the thread is alive before starting it and prints the result
//        Console.WriteLine(t1.ThreadState); //prints the state of the thread before starting it
//        t1.Name = "fct"; //sets the name of the thread to "fct"
//        t1.Start();
//        Console.WriteLine(t1.IsAlive);
//        Console.WriteLine(t1.ThreadState); //prints the state of the thread after starting it
//        t1.Priority = ThreadPriority.Highest; //sets the priority of the thread to the same priority as the current thread
//        Console.WriteLine("Priority of the first thread : " + t1.Priority); //prints the priority of the thread
//        Console.WriteLine("Is the first thread a background thread? " + t1.IsBackground); //checks if the thread is a background thread and prints the result
//        Console.WriteLine("================================");

//        Thread t2 = new Thread(displayname);
//        Console.WriteLine(t2.ThreadState); //prints the state of the thread before starting it
//        t2.Name = "cravita"; //sets the name of the thread to "fct"
//        t2.Start();
//        t2.Priority = ThreadPriority.Lowest; //sets the priority of the thread to the same priority as the current thread

//        Console.WriteLine("Priority of the second thread : " + t2.Priority); //prints the priority of the thread
//        //Console.WriteLine(t2.ThreadState); //prints the state of the thread after starting it
   
//        Console.WriteLine("Thread 1 is alive: " + t1.IsAlive); //checks if the thread is still running and prints the result

//            Console.WriteLine("Thread 2 is alive: " + t2.IsAlive); //checks if the thread is still running and prints the result

//        Console.WriteLine(t2.IsBackground);//checks if the thread is a background thread and prints the result
//    }
//}
