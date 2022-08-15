using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderFinder
{
    public class FolderFinder : IFolderFinder
    {

        public List<string> GetDirectories(string drive)
        {
            List<string> folders = new List<string>();
            {

                foreach (var f in Directory.GetDirectories(drive))
                {
                    folders.Add(f);
                }
                return folders;
            }
        }
    }
}
