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
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(303, 259);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(488, 39);
            this.progressBar2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(435, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar2);
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
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button1;
    }
}

