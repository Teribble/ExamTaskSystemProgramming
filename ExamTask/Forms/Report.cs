using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Forms
{
    public class Report
    {
        public string Path { get; set; }

        public float Length { get; set; }

        public int Substitutions { get; set; }

        public void GetReport(string path)
        {
            if (File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    string buffer = $"Путь файла: {Path}" +
                        $"\nРазмер файла: {Length} kB" +
                        $"\nКоличество замен в файле: {Substitutions}";

                    sw.WriteLine(buffer);
                }
            }
            else
            {
                File.Create(path).Close();

                using (StreamWriter sw = new StreamWriter(path))
                {
                    string buffer = $"Путь файла: {Path}" +
                        $"\nРазмер файла: {Length} kB" +
                        $"\nКоличество замен в файле: {Substitutions}\n\n";

                    sw.WriteLine(buffer);
                }
            }
        }

        public void DeleteReport(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        ///ДОПИСАТЬ СОЗДАНИЕ ОТСЧЕТА, РАЗОБРАТЬСЯ ПОЧЕМУ ГЛЮЧИТ КЛАСС И НИХУЯ НЕ ЗАПИСЫВАЕт
    }
}
