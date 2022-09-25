namespace ExamTask
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.ForbiddenListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.FileCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ForbiddenCountLabel = new System.Windows.Forms.Label();
            this.ButtonSearchWords = new System.Windows.Forms.Button();
            this.ButtonOpenFolder = new System.Windows.Forms.Button();
            this.ProcessedFilesLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PaskudaCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найди паскуду";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(300, -57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClearButton);
            this.groupBox3.Controls.Add(this.DeleteButton);
            this.groupBox3.Controls.Add(this.AddButton);
            this.groupBox3.Controls.Add(this.AddTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(302, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 157);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить слово";
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(6, 125);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(188, 26);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Очистить список";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.OnClearButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(6, 81);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(188, 26);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(6, 53);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(188, 26);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTextBox.Location = new System.Drawing.Point(6, 25);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(188, 22);
            this.AddTextBox.TabIndex = 0;
            this.AddTextBox.TextChanged += new System.EventHandler(this.AddTextBoxChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PathTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DownloadButton);
            this.groupBox2.Controls.Add(this.ForbiddenListBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 386);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список запрещенных слов";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(11, 311);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(247, 26);
            this.PathTextBox.TabIndex = 3;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBoxChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите путь к файлу";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Enabled = false;
            this.DownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadButton.Location = new System.Drawing.Point(42, 343);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(185, 25);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "Загрузить из файла";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.OnDownloadButtonClick);
            // 
            // ForbiddenListBox
            // 
            this.ForbiddenListBox.Enabled = false;
            this.ForbiddenListBox.FormattingEnabled = true;
            this.ForbiddenListBox.ItemHeight = 20;
            this.ForbiddenListBox.Location = new System.Drawing.Point(11, 26);
            this.ForbiddenListBox.Name = "ForbiddenListBox";
            this.ForbiddenListBox.Size = new System.Drawing.Size(247, 264);
            this.ForbiddenListBox.TabIndex = 0;
            this.ForbiddenListBox.EnabledChanged += new System.EventHandler(this.EnabledChangedForbiddenListBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Найденные файлы: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PaskudaCountLabel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.ProcessedFilesLabel);
            this.groupBox4.Controls.Add(this.ButtonOpenFolder);
            this.groupBox4.Controls.Add(this.ButtonSearchWords);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.ForbiddenCountLabel);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.ButtonSearch);
            this.groupBox4.Controls.Add(this.FileCountLabel);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(526, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 236);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация о файлах";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearch.Location = new System.Drawing.Point(10, 54);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(119, 25);
            this.ButtonSearch.TabIndex = 6;
            this.ButtonSearch.Text = "Найти .txt файлы";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.OnButtonSearchClick);
            // 
            // FileCountLabel
            // 
            this.FileCountLabel.AutoSize = true;
            this.FileCountLabel.Location = new System.Drawing.Point(164, 27);
            this.FileCountLabel.Name = "FileCountLabel";
            this.FileCountLabel.Size = new System.Drawing.Size(18, 20);
            this.FileCountLabel.TabIndex = 5;
            this.FileCountLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Найденные файлы:";
            // 
            // ForbiddenCountLabel
            // 
            this.ForbiddenCountLabel.AutoSize = true;
            this.ForbiddenCountLabel.Location = new System.Drawing.Point(171, 87);
            this.ForbiddenCountLabel.Name = "ForbiddenCountLabel";
            this.ForbiddenCountLabel.Size = new System.Drawing.Size(18, 20);
            this.ForbiddenCountLabel.TabIndex = 8;
            this.ForbiddenCountLabel.Text = "0";
            // 
            // ButtonSearchWords
            // 
            this.ButtonSearchWords.Enabled = false;
            this.ButtonSearchWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearchWords.Location = new System.Drawing.Point(10, 141);
            this.ButtonSearchWords.Name = "ButtonSearchWords";
            this.ButtonSearchWords.Size = new System.Drawing.Size(172, 25);
            this.ButtonSearchWords.TabIndex = 9;
            this.ButtonSearchWords.Text = "Найти паскудные файлы";
            this.ButtonSearchWords.UseVisualStyleBackColor = true;
            this.ButtonSearchWords.Click += new System.EventHandler(this.OnButtonSearchWordsClick);
            // 
            // ButtonOpenFolder
            // 
            this.ButtonOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOpenFolder.Location = new System.Drawing.Point(10, 192);
            this.ButtonOpenFolder.Name = "ButtonOpenFolder";
            this.ButtonOpenFolder.Size = new System.Drawing.Size(172, 25);
            this.ButtonOpenFolder.TabIndex = 10;
            this.ButtonOpenFolder.Text = "Открыть папку";
            this.ButtonOpenFolder.UseVisualStyleBackColor = true;
            this.ButtonOpenFolder.Click += new System.EventHandler(this.OnButtonOpenFolderClick);
            // 
            // ProcessedFilesLabel
            // 
            this.ProcessedFilesLabel.AutoSize = true;
            this.ProcessedFilesLabel.Location = new System.Drawing.Point(196, 169);
            this.ProcessedFilesLabel.Name = "ProcessedFilesLabel";
            this.ProcessedFilesLabel.Size = new System.Drawing.Size(18, 20);
            this.ProcessedFilesLabel.TabIndex = 12;
            this.ProcessedFilesLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Обработанные файлы:";
            // 
            // PaskudaCountLabel
            // 
            this.PaskudaCountLabel.AutoSize = true;
            this.PaskudaCountLabel.Location = new System.Drawing.Point(171, 107);
            this.PaskudaCountLabel.Name = "PaskudaCountLabel";
            this.PaskudaCountLabel.Size = new System.Drawing.Size(18, 20);
            this.PaskudaCountLabel.TabIndex = 14;
            this.PaskudaCountLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Найдено паскуд:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ForbiddenListBox;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label FileCountLabel;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label ForbiddenCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonSearchWords;
        private System.Windows.Forms.Button ButtonOpenFolder;
        private System.Windows.Forms.Label ProcessedFilesLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PaskudaCountLabel;
        private System.Windows.Forms.Label label7;
    }
}

