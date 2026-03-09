// class EmployeeExampleBinaryFile_Handling
//    {
//     void write_data()
//     {
//         string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Employee.bin";
//         FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
//         BinaryWriter bw = new BinaryWriter(fs);
//         Console.WriteLine("Enter Employee ID : ");
//        int id = Convert.ToInt32(Console.ReadLine());
//        bw.Write(id);
//        Console.WriteLine("Enter Employee Name : ");
//        string name = Console.ReadLine();
//        bw.Write(name);
//        Console.WriteLine("Enter Employee Salary : ");
//        double salary = Convert.ToDouble(Console.ReadLine());
//        bw.Write(salary);
//        Console.WriteLine("Enter Employee Department : ");
//        string dept = Console.ReadLine();
//        bw.Write(dept);
//        bw.Close();
//        fs.Close(); 

//    }

//    void read_data()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Employee.bin";
//        FileStream fs = new FileStream(path, FileMode.Open);
//        BinaryReader br = new BinaryReader(fs);
//        int id = br.ReadInt32();
//        string name = br.ReadString();
//        double salary = br.ReadDouble();
//        string dept = br.ReadString();

//        Console.WriteLine("---- Employee Data ----");
//        Console.WriteLine("ID: " + id);
//        Console.WriteLine("Name: " + name);
//        Console.WriteLine("Salary: " + salary);
//        Console.WriteLine("Department: " + dept);

//        br.Close();
//        fs.Close();

//    }

//    public static void Main(String[] args)
//    {
//        EmployeeExampleBinaryFile_Handling eb = new EmployeeExampleBinaryFile_Handling();
//        eb.write_data();
//        eb.read_data();
//    }
//}
