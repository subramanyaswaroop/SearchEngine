using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitPath
{
    public class SPlitPath:ISplitPath
    {
        public string SplitPath(string path) 
        {
            string filename = null;
            string[] file=path.Split(@"\");
            foreach(string s in file)
            {
                filename = s;   
            }
            return filename;
        }
    }
}
