using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkNameChanger
{
    public class FileRename
    {
        public string OldFileName { get; set; }
        public string NewFileName { get; set; }
        public void CheckFileExist()
        {
            if (File.Exists(NewFileName))
            {
                File.Delete(NewFileName);
            }
            File.Move(OldFileName, NewFileName);
        }
    }
}
