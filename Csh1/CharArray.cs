
class CharArray
{
    public static void Main(String[] args)
    {
        int i;
        int count = 0;
        char[] arr = new char[5];
      Console.WriteLine("Enter 5 characters");
        for (i = 0; i < arr.Length; i++)
        {
            arr[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Array is");
        for (i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
      for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 'z')
            {
                count++;
            }
        }
 if (count > 0)
        {
            Console.WriteLine("z Found");
        }
        else
        {
            Console.WriteLine("z Not Found");
        }
    }
}
