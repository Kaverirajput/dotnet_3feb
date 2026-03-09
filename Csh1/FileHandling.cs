//class FileHandling
//{
//    public static void Main(string[] args)
//    {
//        FileHandling f = new FileHandling();
//        f.filestaticclass();
//        f.fileinfoclass();

//    }

//    void fileinfoclass()
//    {
//        Console.WriteLine("-----------------File class info--------");
//        string file_dest = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\myfile.txt";
//        FileInfo fi = new FileInfo(file_dest);
//        fi.Create().Close();      //if you are going to delete file then use close method after create otherwise it will show exception that it is run on another 
//        if (fi.Exists)
//        {
//            fi.Delete();
//            if (fi.Exists)
//            {
//                Console.WriteLine("File is not deleted");
//            }
//            else
//            {
//                Console.WriteLine("file is deleted successfully");
//            }
//        }
//        else
//        {
//            Console.WriteLine("File is not existed");
//        }

//        Console.WriteLine("Name : " + fi.Name);
//        Console.WriteLine("FullName : " + fi.FullName);
//        Console.WriteLine("Creationtime : " + fi.CreationTime);
//        Console.WriteLine("DirectoryName :" + fi.DirectoryName);
//    }

//    void filestaticclass()
//    {
//        Console.WriteLine("-----------------File static class--------------");
//        string file_path = "C:\\Users\\kr561\\OneDrive\\Desktop\\Fortune Cloud\\WD 29 Sep\\Holi.txt";
//        File.Create(file_path);
//        //if file is existed then display message file created successfully
//        if (File.Exists(file_path))
//        {
//            Console.WriteLine("File created successfully!! Creation Time : " + File.GetCreationTime(file_path));
//        }
//        else
//        {
//            Console.WriteLine("file is not created");
//        }

//    }
//}
