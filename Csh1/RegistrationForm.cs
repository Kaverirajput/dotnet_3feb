// class RegistrationForm
//    {
//       void writetext()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Registration.txt";
//        FileStream fs = new FileStream(path,FileMode.Create);
//        StreamWriter sw = new StreamWriter(fs);
//        Console.WriteLine("----- Registration Form -----");
//        Console.Write("1. Enter First Name: ");
//        string fname = Console.ReadLine();
//        Console.Write("2. Enter Last Name: ");
//        string lname = Console.ReadLine();
//        Console.Write("3. Enter Age: ");
//        string age = Console.ReadLine();
//        Console.Write("4. Enter Gender: ");
//        string gender = Console.ReadLine();
//        Console.Write("5. Enter Email: ");
//        string email = Console.ReadLine();
//        Console.Write("6. Enter Phone: ");
//        string phone = Console.ReadLine();
//        Console.Write("7. Enter Address: ");
//        string address = Console.ReadLine();
//         Console.Write("8. Enter City: ");
//        string city = Console.ReadLine();
//         Console.Write("9. Enter State: ");
//        string state = Console.ReadLine();
//        Console.Write("10. Enter Password: ");
//        string password = Console.ReadLine();

//        sw.WriteLine("----- New Registration -----");
//        sw.WriteLine("First Name: " + fname);
//        sw.WriteLine("Last Name: " + lname);
//        sw.WriteLine("Age: " + age);
//        sw.WriteLine("Gender: " + gender);
//        sw.WriteLine("Email: " + email);
//        sw.WriteLine("Phone: " + phone);
//        sw.WriteLine("Address: " + address);
//        sw.WriteLine("City: " + city);
//        sw.WriteLine("State: " + state);
//        sw.WriteLine("Password: " + password);
//        sw.WriteLine("-----------------------------");

//        sw.Close();

//        Console.WriteLine("\nRegistration Saved Successfully!");
//    }
//    void readtext()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Registration.txt";
//        FileStream fs = new FileStream(path, FileMode.Open);
//        StreamReader sr = new StreamReader(fs);
//        string t = sr.ReadToEnd();
//        Console.WriteLine("File Content:");
//        Console.WriteLine(t);
//        sr.Close();
//    }
//    public static void Main(String[] args)
//    {
//        RegistrationForm rf = new RegistrationForm();
//        rf.writetext();
//        rf.readtext();
//    }

//}
