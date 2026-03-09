//class StreamClass_handling
//{
//    void writeop()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Dhulivandan.txt";
//        StreamWriter sw = new StreamWriter(path);
//        sw.WriteLine("Today is Holi");
//        sw.WriteLine("Holi mostly celebrate in Vrindavan");
//        sw.Close();
//        Console.WriteLine("File Written Successfully");
//    }

//    void readop()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Dhulivandan.txt";
//        StreamReader sr = new StreamReader(path);
//        string text = sr.ReadToEnd();
//        Console.WriteLine("File Content:");
//        Console.WriteLine(text);
//        sr.Close();
//    }

//    public static void Main(string[] args)
//    {
//        StreamClass_handling sh = new StreamClass_handling();
//        sh.writeop();
//        sh.readop();
//    }
//}