using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamTask
{
    public class SearchFiles
    {
        List<DriveInfo> AllDrives;

        List<string> AllFiles;

        public SearchFiles()
        {
            AllDrives = DriveInfo.GetDrives().ToList();

            AllFiles = new List<string>();
        }

        public void WorkWork()
        {
            AllFiles = GetRecursFiles(AllDrives[1].Name);
        }

        private List<string> GetRecursFiles(string path)
        {
            List<string> ls = new List<string>();

            try
            {
                List<string> folders = Directory.GetDirectories(path).ToList();

                foreach (string folder in folders)
                {
                    ls.AddRange(GetRecursFiles(folder));
                }

                List<string> files = Directory.GetFiles(path).ToList();

                foreach (string filename in files)
                {
                    if (filename.Contains(".txt"))
                        ls.Add(filename);
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ls;
        }
    }
}
