// class BookStore
//    {
    
//    void writetext()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\BookStore.txt";
//        FileStream fs = new FileStream(path, FileMode.Create);
//        StreamWriter sw = new StreamWriter(fs);
//        sw.WriteLine("RAMAN BOOK STORE");
//        sw.WriteLine("===========================");
//        Console.WriteLine("Enter how many items do you want : ");
//        int n = int.Parse(Console.ReadLine());
//        for(int i = 0; i < n; i++)
//        {
//            Console.Write("Enter item " + (i + 1) + ": ");
//            string item = Console.ReadLine();
//            sw.WriteLine(item);
//        }
//        sw.Close();
//        fs.Close();
//        Console.WriteLine("File writted successfully");

//    }

//    void readtext()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\BookStore.txt";
//        FileStream fs = new FileStream(path, FileMode.Open);
//        StreamReader sr = new StreamReader(fs);
//        string t= sr.ReadToEnd();
//        Console.WriteLine("File Content:");
//        Console.WriteLine(t);
//        sr.Close();
//    }

//    public static void Main(String[] args)
//    {
//        BookStore bk = new BookStore();
//        bk.writetext();
//        bk.readtext();
//    }
//}
