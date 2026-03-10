//using System.Collections;

//class Vender_Collection
//{

//    ArrayList vendors;

//    void details()
//    {
//        vendors = new ArrayList();

//        Console.WriteLine("How many vendors do you want to add?");
//        int vendorscount = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter the details of " + vendorscount + "vendors");

//        for(int i = 0; i < vendorscount; i++)
//        {
//            Console.WriteLine("Enter Vendors Name : ");
//            vendors.Add(Console.ReadLine());
//            Console.WriteLine("Enter Vendors Age : ");
//            vendors.Add(Convert.ToInt32(Console.ReadLine()));
//            Console.WriteLine("Enter Vendors Phone Number : ");
//            vendors.Add(Console.ReadLine());
       
//        }
//        display_vendors();
// }
//    void display_vendors()
//    {
//        Console.WriteLine("The details of the vendors are : ");
//        foreach (object vendor in vendors)
//        {
//            Console.WriteLine(vendor);
//        }
//    }

//    public static void Main(string[] args)
//    {
//        Vender_Collection vc = new Vender_Collection();
//        vc.details();
       
//    }
//}
