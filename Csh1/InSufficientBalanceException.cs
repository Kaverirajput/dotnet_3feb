//class InSufficientBalanceException : Exception 
//    {
//    public InSufficientBalanceException(String msg) : base(msg) 
//    {
//    }
//    }

//class ATMUser
//{
//    public static void Main(String[] args)
//    {
//        Console.WriteLine("Enter Amount to Withdraw");
//        int am = int.Parse(Console.ReadLine());

//        if (am < 5000)
//        {
//            Console.WriteLine("Amount Withdraw Successfully");
//        }
//        else
//        {
//            throw new InSufficientBalanceException("Insufficient Balance");
//        }
//    }
//}