using ExamTask.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = System.IO.File;

namespace ExamTask
{
    public partial class MainForm : Form
    {
        public ForbiddenDictionary ForbiddenDictionary;

        public SearchFiles AllFiles;

        public SearchWord AllWords;

        public List<Report> Reports;

        public void OnSearchFilesHandle(int k)
        {
            FileCountLabel.Invoke(new Action(() =>
            {
                FileCountLabel.Text = Convert.ToString(k);
            }));
        }

        public void OnForbiddenCountLabelHandler(int x)
        {
            ForbiddenCountLabel.Invoke(new Action(() =>
            {

                ForbiddenCountLabel.Text = Convert.ToString(x);

            }));
        }

        public void OnProcessFilesCounterHandler(int x)
        {
            ForbiddenCountLabel.Invoke(new Action(() =>
            {

                ProcessedFilesLabel.Text = Convert.ToString(x);

            }));
        }

        public void OnProcessWordsCounterHandler(int x)
        {
            ForbiddenCountLabel.Invoke(new Action(() =>
            {

                PaskudaCountLabel.Text = Convert.ToString(x);

            }));
        }

        public MainForm()
        {
            InitializeComponent();

            ForbiddenDictionary = new ForbiddenDictionary();

            AllFiles = new SearchFiles();

            AllFiles.OnSearch += OnSearchFilesHandle;

            Reports = new List<Report>();

            ResetWords();
        }

        public void ResetWords()
        {
            AllWords = new SearchWord(ForbiddenDictionary.ForbiddenWords);

            AllWords.ForbiddenCounterer += OnForbiddenCountLabelHandler;

            AllWords.OnProcFile += OnProcessFilesCounterHandler;

            AllWords.OnProcWord += OnProcessWordsCounterHandler;

            ForbiddenCountLabel.Text = "0";

            PaskudaCountLabel.Text = "0";
        }



        private void OnDownloadButtonClick(object sender, EventArgs e)
        {
            if (File.Exists(PathTextBox.Text))
            {
                string path = PathTextBox.Text;

                ForbiddenDictionary.DownloadList(path);

                if (!ForbiddenDictionary.isNull())
                {
                    ForbiddenDictionary.ForbiddenWords.ForEach(n =>
                    {
                        ForbiddenListBox.Items.Add(n);
                    });
                }

                ForbiddenListBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Что-то пошло не так, нужно выбрать файл");
            }
        }

        private void PathTextBoxChanged(object sender, EventArgs e)
        {
            if (File.Exists(PathTextBox.Text))
            {
                DownloadButton.Enabled = true;
            }
            else
            {
                DownloadButton.Enabled = false;
            }
        }

        private void AddTextBoxChanged(object sender, EventArgs e)
        {
            if (AddTextBox.Text.Length is 0)
            {
                AddButton.Enabled = false;
            }
            else
            {
                AddButton.Enabled = true;
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            ForbiddenListBox.Items.Add(AddTextBox.Text.ToLower());

            ForbiddenDictionary.ForbiddenWords.Add(AddTextBox.Text);

            ForbiddenListBox.Enabled = true;

            AddTextBox.Clear();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (ForbiddenListBox.Items.Count is 0)
            {
                ForbiddenListBox.Enabled = false;
            }
            else
            {
                ForbiddenListBox.Items.Remove(ForbiddenListBox.SelectedItem as string);

                ForbiddenDictionary.ForbiddenWords.Remove(ForbiddenListBox.SelectedItem as string);

                if (ForbiddenListBox.Items.Count is 0)
                {
                    ForbiddenListBox.Enabled = false;
                }
            }
        }

        private void EnabledChangedForbiddenListBox(object sender, EventArgs e)
        {
            DeleteButton.Enabled = !DeleteButton.Enabled;

            ClearButton.Enabled = !ClearButton.Enabled;
        }

        private void OnClearButtonClick(object sender, EventArgs e)
        {
            if (ForbiddenListBox.Items.Count is 0)
            {

            }
            else
            {
                ForbiddenDictionary.ForbiddenWords.Clear();

                ForbiddenListBox.Items.Clear();

                ForbiddenListBox.Enabled = false;
            }
        }

        private void OnButtonSearchClick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                AllFiles.SearchTxtFiles();

                MessageBox.Show("Поиск файлов завершен");

                ButtonSearchWords.Invoke(new Action(() =>
                {
                    ButtonSearchWords.Enabled = true;
                }));
            });
        }

        private void OnButtonSearchWordsClick(object sender, EventArgs e)
        {
            ResetWords();

            foreach (var file in AllFiles.AllFiles)
            {
                Task.Run(() =>
                {
                    AllWords.SearchWordsInFile(file);
                });
            }
        }

        private void OnButtonOpenFolderClick(object sender, EventArgs e)
        {
            Process.Start("explorer", @"..\..\ForbiddenFiles");
        }
    }
}
