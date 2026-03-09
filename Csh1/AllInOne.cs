// class AllInOne
//    {

//    //instance variables
//    int id;
//    string name;

//    //static variable
//    static string college = "ABC College";

//    //constructor...parameterized)
//    public AllInOne(int i, string n)
//    {
//        id = i;
//        name = n;
//    }

//    //method with parameters
//    public void Display(int marks)
//    {
//        //local variable
//        int total = marks;

//        Console.WriteLine("ID: " + id);
//        Console.WriteLine("Name: " + name);
//        Console.WriteLine("College: " + college);
//        Console.WriteLine("Marks: " + total);

//        //conditional Statements
//        if (total >= 90)
//            Console.WriteLine("Grade: A");
//        else if (total >= 60)
//            Console.WriteLine("Grade: B");
//        else
//            Console.WriteLine("Grade: C");

//        //switch Case
//        switch (total / 10)
//        {
//            case 10:
//            case 9:
//                Console.WriteLine("Excellent");
//                break;
//            case 8:
//            case 7:
//                Console.WriteLine("Very Good");
//                break;
//            default:
//                Console.WriteLine("Good");
//                break;
//        }
//    }

//    static void Main()
//    {
//        //Data types & variables
//        int age = 20;
//        double percentage = 85.5;
//        char grade = 'A';
//        bool isPassed = true;

//        Console.WriteLine("Age: " + age);
//        Console.WriteLine("Percentage: " + percentage);
//        Console.WriteLine("Grade: " + grade);
//        Console.WriteLine("Passed: " + isPassed);

//        //Array
//        int[] marks = { 70, 80, 90 };

//        Console.WriteLine("Array using for loop:");
//        for (int i = 0; i < marks.Length; i++)
//        {
//            Console.WriteLine(marks[i]);
//        }

//        Console.WriteLine("Array using foreach loop:");
//        foreach (int m in marks)
//        {
//            Console.WriteLine(m);
//        }

//        //While loop
//        int j = 0;
//        Console.WriteLine("While Loop:");
//        while (j < 3)
//        {
//            Console.WriteLine(j);
//            j++;
//        }

//        //Do-While loop
//        int k = 1;
//        Console.WriteLine("Do While Loop:");
//        do
//        {
//            Console.WriteLine(k);
//            k++;
//        } while (k <= 3);

//        //string & String Methods
//        string msg = "Hello Guys";
//        Console.WriteLine("\nString Length: " + msg.Length);
//        Console.WriteLine("Upper Case: " + msg.ToUpper());
//        Console.WriteLine("Lower Case: " + msg.ToLower());
//        Console.WriteLine("Contains 'Guys': " + msg.Contains("Guys"));

//        //object creation...constructor call
//        AllInOne s1 = new AllInOne(101, "Kaveri");
//        s1.Display(85);
//    }
//}



