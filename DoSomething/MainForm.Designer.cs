namespace DoSomething
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PlaceInfoPage = new System.Windows.Forms.TabPage();
            this.ApplyChangesButton = new System.Windows.Forms.Button();
            this.CurrentDataGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrentDataBox = new System.Windows.Forms.TextBox();
            this.UpdateCurrentDataButton = new System.Windows.Forms.Button();
            this.NewDataGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UploadNewDataFileButton = new System.Windows.Forms.Button();
            this.NewData5Box = new System.Windows.Forms.TextBox();
            this.NewData1Box = new System.Windows.Forms.TextBox();
            this.NewData4Box = new System.Windows.Forms.TextBox();
            this.NewData2Box = new System.Windows.Forms.TextBox();
            this.NewData3Box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DBConnectTestButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DBEncodingBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DBPasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DBUsernameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DBHostBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DBBrowseButton = new System.Windows.Forms.Button();
            this.DBPathBox = new System.Windows.Forms.TextBox();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveCurrentDataButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.PlaceInfoPage.SuspendLayout();
            this.CurrentDataGroupBox.SuspendLayout();
            this.NewDataGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.PlaceInfoPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(614, 541);
            this.MainTabControl.TabIndex = 0;
            // 
            // PlaceInfoPage
            // 
            this.PlaceInfoPage.Controls.Add(this.ApplyChangesButton);
            this.PlaceInfoPage.Controls.Add(this.CurrentDataGroupBox);
            this.PlaceInfoPage.Controls.Add(this.NewDataGroupBox);
            this.PlaceInfoPage.Controls.Add(this.groupBox1);
            this.PlaceInfoPage.Location = new System.Drawing.Point(4, 27);
            this.PlaceInfoPage.Name = "PlaceInfoPage";
            this.PlaceInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlaceInfoPage.Size = new System.Drawing.Size(606, 510);
            this.PlaceInfoPage.TabIndex = 0;
            this.PlaceInfoPage.Text = "Адрес и режим работы подразделения";
            this.PlaceInfoPage.UseVisualStyleBackColor = true;
            // 
            // ApplyChangesButton
            // 
            this.ApplyChangesButton.Location = new System.Drawing.Point(8, 474);
            this.ApplyChangesButton.Name = "ApplyChangesButton";
            this.ApplyChangesButton.Size = new System.Drawing.Size(584, 28);
            this.ApplyChangesButton.TabIndex = 3;
            this.ApplyChangesButton.Text = "Внести изменения на отделении";
            this.ApplyChangesButton.UseVisualStyleBackColor = true;
            this.ApplyChangesButton.Click += new System.EventHandler(this.ApplyChangesButton_Click);
            // 
            // CurrentDataGroupBox
            // 
            this.CurrentDataGroupBox.Controls.Add(this.SaveCurrentDataButton);
            this.CurrentDataGroupBox.Controls.Add(this.CurrentDataBox);
            this.CurrentDataGroupBox.Controls.Add(this.UpdateCurrentDataButton);
            this.CurrentDataGroupBox.Location = new System.Drawing.Point(8, 204);
            this.CurrentDataGroupBox.Name = "CurrentDataGroupBox";
            this.CurrentDataGroupBox.Size = new System.Drawing.Size(286, 230);
            this.CurrentDataGroupBox.TabIndex = 1;
            this.CurrentDataGroupBox.TabStop = false;
            this.CurrentDataGroupBox.Text = "Текущие данные подразделения";
            // 
            // CurrentDataBox
            // 
            this.CurrentDataBox.BackColor = System.Drawing.Color.White;
            this.CurrentDataBox.Location = new System.Drawing.Point(6, 23);
            this.CurrentDataBox.Multiline = true;
            this.CurrentDataBox.Name = "CurrentDataBox";
            this.CurrentDataBox.ReadOnly = true;
            this.CurrentDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CurrentDataBox.Size = new System.Drawing.Size(274, 167);
            this.CurrentDataBox.TabIndex = 6;
            // 
            // UpdateCurrentDataButton
            // 
            this.UpdateCurrentDataButton.Location = new System.Drawing.Point(6, 196);
            this.UpdateCurrentDataButton.Name = "UpdateCurrentDataButton";
            this.UpdateCurrentDataButton.Size = new System.Drawing.Size(130, 28);
            this.UpdateCurrentDataButton.TabIndex = 5;
            this.UpdateCurrentDataButton.Text = "Получить";
            this.UpdateCurrentDataButton.UseVisualStyleBackColor = true;
            this.UpdateCurrentDataButton.Click += new System.EventHandler(this.UpdateCurrentDataButton_Click);
            // 
            // NewDataGroupBox
            // 
            this.NewDataGroupBox.Controls.Add(this.label7);
            this.NewDataGroupBox.Controls.Add(this.UploadNewDataFileButton);
            this.NewDataGroupBox.Controls.Add(this.NewData5Box);
            this.NewDataGroupBox.Controls.Add(this.NewData1Box);
            this.NewDataGroupBox.Controls.Add(this.NewData4Box);
            this.NewDataGroupBox.Controls.Add(this.NewData2Box);
            this.NewDataGroupBox.Controls.Add(this.NewData3Box);
            this.NewDataGroupBox.Location = new System.Drawing.Point(306, 204);
            this.NewDataGroupBox.Name = "NewDataGroupBox";
            this.NewDataGroupBox.Size = new System.Drawing.Size(286, 230);
            this.NewDataGroupBox.TabIndex = 2;
            this.NewDataGroupBox.TabStop = false;
            this.NewDataGroupBox.Text = "Новые данные подразделения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Адрес и режим работы";
            // 
            // UploadNewDataFileButton
            // 
            this.UploadNewDataFileButton.Location = new System.Drawing.Point(6, 196);
            this.UploadNewDataFileButton.Name = "UploadNewDataFileButton";
            this.UploadNewDataFileButton.Size = new System.Drawing.Size(274, 28);
            this.UploadNewDataFileButton.TabIndex = 5;
            this.UploadNewDataFileButton.Text = "Загрузить из текстового файла";
            this.UploadNewDataFileButton.UseVisualStyleBackColor = true;
            this.UploadNewDataFileButton.Click += new System.EventHandler(this.UploadNewDataFileButton_Click);
            // 
            // NewData5Box
            // 
            this.NewData5Box.Location = new System.Drawing.Point(17, 159);
            this.NewData5Box.MaxLength = 28;
            this.NewData5Box.Name = "NewData5Box";
            this.NewData5Box.Size = new System.Drawing.Size(251, 24);
            this.NewData5Box.TabIndex = 4;
            // 
            // NewData1Box
            // 
            this.NewData1Box.Location = new System.Drawing.Point(17, 41);
            this.NewData1Box.MaxLength = 28;
            this.NewData1Box.Name = "NewData1Box";
            this.NewData1Box.Size = new System.Drawing.Size(251, 24);
            this.NewData1Box.TabIndex = 0;
            // 
            // NewData4Box
            // 
            this.NewData4Box.Location = new System.Drawing.Point(17, 131);
            this.NewData4Box.MaxLength = 28;
            this.NewData4Box.Name = "NewData4Box";
            this.NewData4Box.Size = new System.Drawing.Size(251, 24);
            this.NewData4Box.TabIndex = 3;
            // 
            // NewData2Box
            // 
            this.NewData2Box.Location = new System.Drawing.Point(17, 71);
            this.NewData2Box.MaxLength = 28;
            this.NewData2Box.Name = "NewData2Box";
            this.NewData2Box.Size = new System.Drawing.Size(251, 24);
            this.NewData2Box.TabIndex = 1;
            // 
            // NewData3Box
            // 
            this.NewData3Box.Location = new System.Drawing.Point(17, 101);
            this.NewData3Box.MaxLength = 28;
            this.NewData3Box.Name = "NewData3Box";
            this.NewData3Box.Size = new System.Drawing.Size(251, 24);
            this.NewData3Box.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DBConnectTestButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DBEncodingBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DBPasswordBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DBUsernameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DBHostBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DBBrowseButton);
            this.groupBox1.Controls.Add(this.DBPathBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения к БД";
            // 
            // DBConnectTestButton
            // 
            this.DBConnectTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DBConnectTestButton.Location = new System.Drawing.Point(6, 140);
            this.DBConnectTestButton.Name = "DBConnectTestButton";
            this.DBConnectTestButton.Size = new System.Drawing.Size(578, 28);
            this.DBConnectTestButton.TabIndex = 6;
            this.DBConnectTestButton.Text = "Тест подключения";
            this.DBConnectTestButton.UseVisualStyleBackColor = true;
            this.DBConnectTestButton.Click += new System.EventHandler(this.DBConnectTestButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кодировка";
            // 
            // DBEncodingBox
            // 
            this.DBEncodingBox.FormattingEnabled = true;
            this.DBEncodingBox.Items.AddRange(new object[] {
            "ASCII",
            "KOI8R",
            "KOI8U",
            "UTF8",
            "WIN1251"});
            this.DBEncodingBox.Location = new System.Drawing.Point(459, 99);
            this.DBEncodingBox.Name = "DBEncodingBox";
            this.DBEncodingBox.Size = new System.Drawing.Size(125, 26);
            this.DBEncodingBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль";
            // 
            // DBPasswordBox
            // 
            this.DBPasswordBox.Location = new System.Drawing.Point(308, 100);
            this.DBPasswordBox.MaxLength = 32;
            this.DBPasswordBox.Name = "DBPasswordBox";
            this.DBPasswordBox.Size = new System.Drawing.Size(145, 24);
            this.DBPasswordBox.TabIndex = 4;
            this.DBPasswordBox.Text = "masterkey";
            this.DBPasswordBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Логин";
            // 
            // DBUsernameBox
            // 
            this.DBUsernameBox.Location = new System.Drawing.Point(157, 100);
            this.DBUsernameBox.MaxLength = 32;
            this.DBUsernameBox.Name = "DBUsernameBox";
            this.DBUsernameBox.Size = new System.Drawing.Size(145, 24);
            this.DBUsernameBox.TabIndex = 3;
            this.DBUsernameBox.Text = "SYSDBA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Хост";
            // 
            // DBHostBox
            // 
            this.DBHostBox.Location = new System.Drawing.Point(6, 100);
            this.DBHostBox.MaxLength = 256;
            this.DBHostBox.Name = "DBHostBox";
            this.DBHostBox.Size = new System.Drawing.Size(145, 24);
            this.DBHostBox.TabIndex = 2;
            this.DBHostBox.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к файлу БД";
            // 
            // DBBrowseButton
            // 
            this.DBBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DBBrowseButton.Location = new System.Drawing.Point(496, 42);
            this.DBBrowseButton.Name = "DBBrowseButton";
            this.DBBrowseButton.Size = new System.Drawing.Size(88, 28);
            this.DBBrowseButton.TabIndex = 1;
            this.DBBrowseButton.Text = "Обзор";
            this.DBBrowseButton.UseVisualStyleBackColor = true;
            this.DBBrowseButton.Click += new System.EventHandler(this.DBBrowseButton_Click);
            // 
            // DBPathBox
            // 
            this.DBPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBPathBox.Location = new System.Drawing.Point(6, 44);
            this.DBPathBox.Name = "DBPathBox";
            this.DBPathBox.Size = new System.Drawing.Size(484, 24);
            this.DBPathBox.TabIndex = 0;
            this.DBPathBox.Text = "D:\\POSTITEM.IB";
            // 
            // SaveCurrentDataButton
            // 
            this.SaveCurrentDataButton.Location = new System.Drawing.Point(150, 196);
            this.SaveCurrentDataButton.Name = "SaveCurrentDataButton";
            this.SaveCurrentDataButton.Size = new System.Drawing.Size(130, 28);
            this.SaveCurrentDataButton.TabIndex = 6;
            this.SaveCurrentDataButton.Text = "Сохранить";
            this.SaveCurrentDataButton.UseVisualStyleBackColor = true;
            this.SaveCurrentDataButton.Click += new System.EventHandler(this.SaveCurrentDataButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 541);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Что сегодня?";
            this.MainTabControl.ResumeLayout(false);
            this.PlaceInfoPage.ResumeLayout(false);
            this.CurrentDataGroupBox.ResumeLayout(false);
            this.CurrentDataGroupBox.PerformLayout();
            this.NewDataGroupBox.ResumeLayout(false);
            this.NewDataGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PlaceInfoPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DBBrowseButton;
        private System.Windows.Forms.TextBox DBPathBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DBEncodingBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DBPasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DBUsernameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DBHostBox;
        private System.Windows.Forms.OpenFileDialog MainOpenFileDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NewData1Box;
        private System.Windows.Forms.GroupBox NewDataGroupBox;
        private System.Windows.Forms.TextBox NewData5Box;
        private System.Windows.Forms.TextBox NewData4Box;
        private System.Windows.Forms.TextBox NewData2Box;
        private System.Windows.Forms.TextBox NewData3Box;
        private System.Windows.Forms.GroupBox CurrentDataGroupBox;
        private System.Windows.Forms.Button DBConnectTestButton;
        private System.Windows.Forms.Button ApplyChangesButton;
        private System.Windows.Forms.Button UpdateCurrentDataButton;
        private System.Windows.Forms.Button UploadNewDataFileButton;
        private System.Windows.Forms.TextBox CurrentDataBox;
        private System.Windows.Forms.Button SaveCurrentDataButton;
    }
}

