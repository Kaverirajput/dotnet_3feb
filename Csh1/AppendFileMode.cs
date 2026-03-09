//class AppendFileMode
//{
//    void write_data()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Append.bin";

//        FileStream fs = new FileStream(path, FileMode.Append);
//        BinaryWriter bw = new BinaryWriter(fs);
//        bw.Write(0);
//        bw.Write(1);
//        bw.Write(2);

//        fs.Close();
//        bw.Close();

//        Console.WriteLine("Data written successfully.");
//    }

//    void read_data()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Append.bin";
//        FileStream fs = new FileStream(path, FileMode.Open);
//        BinaryReader br = new BinaryReader(fs);
//        int data1 = br.ReadInt32();
//        int data2 = br.ReadInt32();
//        int data3 = br.ReadInt32();

//        fs.Close();
//        br.Close();


//    }
//    public static void Main(String[] args)
//    {
//        AppendFileMode afm = new AppendFileMode();
//        afm.write_data();
//        afm.read_data();
//    }
//}