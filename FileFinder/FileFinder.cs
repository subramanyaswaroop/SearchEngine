using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace FileFinder
{
    public class FileFinder : IFIleFinder
    {
        public List<string> GetFiles(string Drive)
        {
            List<string> files = new List<string>();
            foreach (var file in Directory.GetFiles(Drive))
            {
                files.Add(file);
            }
            return files;
         }

    }
}
