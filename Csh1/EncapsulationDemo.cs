//// Encapsulation is the process of wrapping data and methods that operate on that data within a single unit, such as a class. It helps to protect the data from unauthorized access and modification by making the data members private and providing public methods to access and modify them.
////rule 1 : data members should be private
////rule 2 : it is access using public setter and getter methods
//class fb_create_ac
//{
//    private string name;  //Data members are private
//    private long mobilenumber;

//    public void setname(string name)  //Public method to set the value of name
//    {
//        this.name = name;
//    }
//    public string getname()  //Public method to get the value of name
//   {
//        return this.name;
//    }
//    public void setmobilenumber(long mobilenumber)  //Public method to set the value of mobilenumber
//    {
//        this.mobilenumber = mobilenumber;
//    }
//    public long getmobilenumber()
//    {
//        return this.mobilenumber;
//    }
//}
//class EncapsulationDemo
//    {
//    public static void Main(String[] args)
//    {
//        fb_create_ac f = new fb_create_ac();
//        f.setname("Kaveri");  //Setting the name
//      Console.WriteLine(f.getname());  //Getting the name
//        f.setmobilenumber(1234567890);  //Setting the mobile number
//       Console.WriteLine(f.getmobilenumber());
//    }
//    }

