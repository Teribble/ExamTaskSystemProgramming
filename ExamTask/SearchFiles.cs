using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamTask
{
    public class SearchFiles
    {
        private int count = 0;

        public delegate void MethodSearch(int number);

        public event MethodSearch OnSearch;

        public List<DriveInfo> AllDrives;

        public List<string> AllFiles;

        public SearchFiles()
        {
            AllDrives = DriveInfo.GetDrives().ToList();

            AllFiles = new List<string>();
        }

        public void SearchTxtFiles()
        {
            count = 0;

            AllFiles.Clear();

            OnSearch(count);
            
            foreach (var disk in AllDrives)
            {
                AllFiles.AddRange(GetRecursFiles(disk.Name));
            }
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
                    {
                        ls.Add(filename);

                        OnSearch(count++);
                    }
                }
            }
            catch (System.Exception e)
            {
                //MessageBox.Show(e.Message);
            }

            return ls;
        }
    }
}
