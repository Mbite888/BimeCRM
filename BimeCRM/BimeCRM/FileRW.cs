using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BimeCRM
{
    class FileRW
    {
        public string path;

        public FileRW(string path)
        {
            this.path = path;
        }

        public bool Exist()
        {
            if (File.Exists(path))
                return true;
            else
                return false;
            
        }

        public string ReadFile()
        {
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                return text;
            }
            else
            {
                return "";
            }
        }
        public void WriteOnFile(string text)
        {
            File.WriteAllText(path, text);
            
        }
    }
}
