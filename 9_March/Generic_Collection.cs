//remove 345 using index
//add 200 and 8 integer at index 0
// check weather 8787 object is present in the collection or not
//print the count of all objects in the collection 
//reverse the collection

class Generic_Collection
{
    static List<int> numbers;//declaring a list of integers
    public static void integerobjets()
    {
        numbers = new List<int>();//initializing the list of integers
        numbers.Add(744);
        numbers.Add(345);
        numbers.Add(7588);
        numbers.Add(982738);


    }
    static void printdata()
    {
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
    void generic()
    {
        integerobjets();
        printdata();

        Console.WriteLine("---------------------------");

        Console.WriteLine("Conatains : " + numbers.Contains(8787));

        Console.WriteLine("-----------------------------");

        Console.WriteLine("count of elements : " + numbers.Count);

        Console.WriteLine("---------------------------");
        Console.WriteLine("removing 345 ");
        numbers.RemoveAt(1);
        printdata();

        Console.WriteLine("---------------------------");
        Console.WriteLine("reverse the collection : ");
        numbers.Reverse();
        printdata();

        Console.WriteLine("------------------------------");
        Console.WriteLine("inserting 200");
        numbers.Insert(0, 200);
        printdata();

    }
    public static void Main(String[] args)
    {
        Generic_Collection g = new Generic_Collection();

        g.generic();

    }
}
