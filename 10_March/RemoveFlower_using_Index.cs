//class RemoveFlower_using_Index
//{
//    List<string> flowers;

//    void flower_objects()
//    {
//        flowers = new List<string>();
//        Console.WriteLine("How many flowers do you want to add?");
//        int flowerCount = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter the names of " + flowerCount + " flowers:");
//        for (int i = 0; i < flowerCount; i++)
//        {

//            Console.WriteLine("Enter flower name: ");
//            flowers.Add(Console.ReadLine());
//        }
//        Console.WriteLine("================================");
//        display_flowers();

//        Console.WriteLine("================================");
//    }
//    void remove_flower()
//    {
//        Console.WriteLine("Enter the index of the flower you want to remove:");
//        int index = Convert.ToInt32(Console.ReadLine());

//        if (index >= 0 && index < flowers.Count)  //check for valid index means index is greater than 0 and less than the count of flowers
//        {
//            for (int i = index; i < flowers.Count - 1; i++) //loop to shift elements to the left means start  from the ind and go till the second last element
//            {
//                flowers[i] = flowers[i + 1];   //shift elements meaning assign the next element to the current index
//            }

//            flowers[flowers.Count - 1] = null;  //set last element to null meaning assign null to the last index
//        }
//        else
//        {
//            Console.WriteLine("Invalid index");
//        }
//    }
//    void display_flowers()
//    {
//        Console.WriteLine("The flowers are: ");
//        foreach (string f in flowers)
//        {

//            Console.WriteLine(f);
//        }
      
//    }
//    public static void Main(string[] args)
//    {
//        RemoveFlower_using_Index r = new RemoveFlower_using_Index();
//        r.flower_objects();
//        r.remove_flower();
//        r.display_flowers();
//    }
//}
