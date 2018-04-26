using System;
using System.IO;

namespace DirectoryCreate
{
    class Directory{
    public static void Main(){
        string path = @"C:\MyDir";

        try
        {
            if(Directory.Exists(path)){
                Console.WriteLine("This path already exists.");
                return;
            }

            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("Directory has been created successfully at {0}." , Directory.GetCreationTime(path));
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}" , e.ToString());
            throw;
        }
        finally{}
    }
}
}
