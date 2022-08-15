using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DriveFinderClassLibrary;

using ILoopToFindAllFIlesDirectories;

namespace DriveAllFilesAndDirectory
{
    public class DRiveAllFilesAndDirectory:IDriveAllFilesAndDirectory
    {
        public List<string> AllFilesAndDirectory()
        {
            IDriveFinder drivefinder = new DriveFinder();
            List<string> drives = drivefinder.GetDrive();
            List<string> allFile = new List<string>();
            foreach(string drive in drives)
            {
                if(drive==@"D:\")
                {
                    ILoopFileDirectory I= new LoopFileDirectory();
                    allFile=I.DirectoryAndFiles(drive);
                }
            }
            return allFile; 
        }
    }
}