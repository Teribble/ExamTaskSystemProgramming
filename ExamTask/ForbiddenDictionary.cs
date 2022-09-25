using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExamTask
{
    public class ForbiddenDictionary
    {
        public List<string> ForbiddenWords;

        public ForbiddenDictionary()
        {
            ForbiddenWords = new List<string>();
        }

        public void DownloadList(string path)
        {
            string buffer = string.Empty;

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    buffer = sr.ReadToEnd().ToLower() ;
                }
            }

            ForbiddenWords.Clear();

            buffer.Split('\n', ' ').ToList().ForEach(n =>
            {
                ForbiddenWords.Add(n);
            });
        }

        public bool isNull()
        {
            if (ForbiddenWords.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
