

class GenericCollection1
{

    void adddata()
    {
        List<string> name = new List<string>();
        name.Add("kaveri");
        name.Add("gayatri");
        name.Add("Goldy");

        foreach (string s in name)
        {
            Console.WriteLine(s);
        }

    }
    public static void Main(String[] args)
    {
        GenericCollection1 a = new GenericCollection1();
        a.adddata();
    }
}
