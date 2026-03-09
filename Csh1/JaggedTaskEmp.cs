//class JaggedTaskEmp
//{
//    public static void Main(String[] args)
//    {
//        //array for dpt
//        string[] dpt = { "Testing", "Development", "Management", "Operations" };

//        //jagged array for employee in each dpt
//        string[][] emp = new string[dpt.Length][];

//        //input no. of emp for each dpt and their name
//        //loop for each dpt
//        for (int i = 0; i < dpt.Length; i++)
//        {

//            Console.WriteLine("How many employee are in " + dpt[i] + " department?");
//            //taking input for emp and store in int ename
//            int enmae = int.Parse(Console.ReadLine());
//            //arr for emp of current dpt
//            emp[i] = new string[enmae];
//            //loop  for take emp name
//            for (int j = 0; j < enmae; j++)
//            {
//                Console.WriteLine("Enter name of employee  in " + dpt[i] + "department:");
//                //stored emp name for jagged arr
//                emp[i][j] = Console.ReadLine();
//            }
//        }

//        //print full matrix
//        Console.WriteLine("=====================================");

//        for (int i = 0; i < dpt.Length; i++)
//        {
//            // Print department name
//            Console.Write(dpt[i] + " ");

//            // Print employee for dept
//            for (int j = 0; j < emp[i].Length; j++)
//            {
//                Console.Write(emp[i][j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}


