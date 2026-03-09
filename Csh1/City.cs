//class City
//{
//    public static void Main(String[] args)
//    {
//        // printing statement for taking input size
//        Console.WriteLine("Enter No. of Cities: ");

//        // taking input for size of array
//        int size = Int32.Parse(Console.ReadLine());

//        // array declaration for city 
//        string[] city = new string[size];

//        // loop for taking input for city name
//        Console.WriteLine("Enter City Names: ");
//        for (int i = 0; i < city.Length; i++)
//        {
//            city[i] = Console.ReadLine();
//        }

//        // printing statement for search city name
//        Console.WriteLine("Enter city name to search: ");
//        string c = Console.ReadLine();

//        // loop for search city name
//        int count = 0;
//        for (int i = 0; i < city.Length; i++)
//        {
//            if (city[i] == c)
//            {
//                count++;
//                break;   // stop searching once found
//            }
//        }

//        // final result (outside loop)
//        if (count == 0)
//        {
//            Console.WriteLine(c + " City is not found");
//        }
//        else
//        {
//            Console.WriteLine(c + " City is found");
//        }
//    }
//}
