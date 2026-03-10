//class Employee_Collection
//{
//    List<string> employees;
//    void employee_details()
//    {
//        employees = new List<string>();
//      Console.WriteLine("Enter number of employees:");
//        int n = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("Enter employee name:");
//            employees.Add(Console.ReadLine());
//        }
//    }
// void match_name()
//    {
//        int count = 0;
// for (int i = 0; i < employees.Count; i++)
//        {
//            if (employees[i].ToLower() == "tanvi")
//            {
//                Console.WriteLine("Tanvi found at index: " + i);
//                count++;
//            }
//        }
//     if (count == 0)
//        {
//            Console.WriteLine("Employee is not exist");
//        }
//    }

//    public static void Main(string[] args)
//    {
//        Employee_Collection e = new Employee_Collection();
//        e.employee_details();
//        e.match_name();
//    }
//}