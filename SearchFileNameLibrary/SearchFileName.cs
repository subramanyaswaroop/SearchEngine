using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveAllFilesAndDirectory;
using SplitPath;

namespace SearchFileNameLibrary
{
    public class SearchFileName:ISearchFileName
    {
        public void searchforfile(string filename)
        {
            int flag = 0;
                int f = 0;
            List<string> FilePath = new List<string>();
            IDriveAllFilesAndDirectory classDrive = new DRiveAllFilesAndDirectory();
            FilePath = classDrive.AllFilesAndDirectory();
            ISplitPath sp = new SPlitPath();
            foreach(string file in FilePath)
            {
                if(filename==sp.SplitPath(file))
                {
                    if (f == 0)
                        Console.WriteLine("File Found---->");
                    Console.WriteLine(file);
                    flag = 1;
                    f = 1;

                }
            }
            if (flag == 0)
                Console.WriteLine("File not Found  :(  ");
            
        }





    }
}
