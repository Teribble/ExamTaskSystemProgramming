﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamTask
{
    public partial class MainForm : Form
    {
        public ForbiddenDictionary ForbiddenDictionary;

        public MainForm()
        {
            InitializeComponent();

            ForbiddenDictionary = new ForbiddenDictionary();
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
            ForbiddenListBox.Items.Add(AddTextBox.Text);

            ForbiddenListBox.Enabled = true;
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
    }
}
