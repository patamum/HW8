using System.IO;
namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\SJ\Test";
            string[] files = Directory.GetFileSystemEntries(path,"*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}