// class BinaryFile_Handling
//    {
//    void write_data()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\User.bin";
//        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
//        BinaryWriter bw = new BinaryWriter(fs);
//        bw.Write(556);
//        bw.Write("Hello everyone");
//        bw.Write(89.1);
//        bw.Write(true);
//        bw.Close();
//        fs.Close();

//    }

//    void read_data()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\User.bin";
//        FileStream fs = new FileStream(path, FileMode.Open);
//        BinaryReader br = new BinaryReader(fs);
//        int num = br.ReadInt32();
//        string str = br.ReadString();
//        double d = br.ReadDouble();
//        bool b = br.ReadBoolean();

//        Console.WriteLine("Integer : "+num);
//        Console.WriteLine("String : " + str);
//        Console.WriteLine("Double : " + d);
//        Console.WriteLine("Boolean : " + b);

//        br.Close();
//        fs.Close();
//    }
//    public static void Main(String[] args)
//    {
//        BinaryFile_Handling obj = new BinaryFile_Handling();
//        obj.write_data();
//        obj.read_data();
//    }
//}