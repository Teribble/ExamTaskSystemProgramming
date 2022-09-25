using ExamTask.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask
{
    public class SearchWord
    {
        public delegate void ForbiddenCounter(int x);

        public delegate void ProcessedFiles(int x);

        public delegate void ProcessedWords(int x);

        public event ProcessedWords OnProcWord;

        public event ProcessedFiles OnProcFile;

        public event ForbiddenCounter ForbiddenCounterer;

        private int _forbiddenCount = 0;

        private int _procFileCount = 0;

        private int _procWordCount = 0;

        public List<string> ForbiddenWords;

        public List<Report> Reports;

        public SearchWord(List<string> forbiddenWords)
        {
            ForbiddenWords = forbiddenWords;

            Reports = new List<Report>();
        }

        public async void SearchWordsInFile(string path)
        {
            OnProcFile(++_procFileCount);

            //Report report = new Report();

            if (File.Exists(path))
            {
                //report.Length = new FileInfo(path).Length / 1000;

                //report.Path = path;

                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string fileContent = await sr.ReadToEndAsync();

                        bool buffer = false;

                        foreach (var word in ForbiddenWords)
                        {
                            if (fileContent.Contains(word))
                            {
                                buffer = true;

                                break;
                            }
                        }
                        if (buffer)
                        {
                            ForbiddenCounterer(++_forbiddenCount);

                            string newPathFile = $@"..\..\ForbiddenFiles\{new FileInfo(path).Name}";

                            foreach (var word in ForbiddenWords)
                            {
                                if (fileContent.Contains(word))
                                {
                                    OnProcWord(++_procWordCount);

                                    //report.Substitutions += GetFoundWords(word, fileContent);

                                    fileContent = fileContent.Replace(word, "*******");
                                }
                            }

                            if (File.Exists(newPathFile))
                            {
                                using (StreamWriter sw = new StreamWriter(newPathFile))
                                {
                                    await sw.WriteLineAsync(fileContent);
                                }
                            }
                            else
                            {
                                File.Create(newPathFile).Close();

                                using (StreamWriter sw = new StreamWriter(newPathFile))
                                {
                                    await sw.WriteLineAsync(fileContent);
                                }
                            }

                            //report.GetReport(@"..\..\Report\Report.txt");
                        }
                    }
                }
                catch (Exception)
                {

                    
                }
            }
        }

        private int GetFoundWords(string word, string str)
        {
            int count = 0;

            int counter = 0;

            word = word.ToLower();

            str = str.ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                count = 0;

                if (word[i] == str[0])
                {
                    for (int j = i, k = 0; k < str.Length; j++, k++)
                    {
                        if (word[j] == str[k])
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (count == str.Length)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
