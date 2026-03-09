// class UserLogin
//    {
//    void Register()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Login.txt";
//        FileStream fs = new FileStream(path, FileMode.Create);
//        StreamWriter sw = new StreamWriter(fs);
//        Console.WriteLine("Registration");
//        Console.WriteLine("Enter Email : ");
//        string email = Console.ReadLine();
//        Console.WriteLine("Enter Password : ");
//        string pass = Console.ReadLine();
//        sw.WriteLine(email);
//        sw.WriteLine(pass);
//        sw.Close();
//        fs.Close();
//        Console.WriteLine("Register successfully");

//    }

//    void login()
//    {
//        string path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Login.txt";
//        FileStream fs = new FileStream (path, FileMode.Open);
//        StreamReader  sr = new StreamReader(fs);

//        Console.WriteLine("-----LOGIN---------");
//        Console.WriteLine("Enter Email : ");
//        string Lemail = Console.ReadLine();
//        Console.WriteLine("Enter Password : ");
//        string Lpass = Console.ReadLine();

//        string fileEmail = sr.ReadLine();
//        string filePass = sr.ReadLine();

//        sr.Close();
//        fs.Close();
//        if (Lemail == fileEmail && Lpass == filePass)
//        {
//            Console.WriteLine("Login Successful");
//        }
//        else
//        {
//            Console.WriteLine("Invalid Email or Password");
//        }


//    }

//    public static void Main(String[] args)
//    {
//        UserLogin ul = new UserLogin();
//        ul.Register();
//        ul.login();
//    }
//}
