using DriveFinderClassLibrary;
using FolderFinder;

namespace FileSearchEngineConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to our File Search Engine");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Available Drives in our System");
            IDriveFinder driveFinder = new DriveFinder();
            List<string> drives = driveFinder.GetDrive();
            foreach (string drive in drives)
            {
                Console.WriteLine(drive);
            }
            Console.WriteLine();
            Console.Write("Enter file name to search: ");
            string fileToSearch = Console.ReadLine();
            

            //???
        }
    }
}