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
            this.PlaceInfo_ApplyChangesButton = new System.Windows.Forms.Button();
            this.PlaceInfo_CurrentDataGroupBox = new System.Windows.Forms.GroupBox();
            this.PlaceInfo_SaveCurrentDataButton = new System.Windows.Forms.Button();
            this.PlaceInfo_CurrentDataBox = new System.Windows.Forms.TextBox();
            this.PlaceInfo_UpdateCurrentDataButton = new System.Windows.Forms.Button();
            this.PlaceInfo_NewDataGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PlaceInfo_UploadNewDataFileButton = new System.Windows.Forms.Button();
            this.PlaceInfo_NewData5Box = new System.Windows.Forms.TextBox();
            this.PlaceInfo_NewData1Box = new System.Windows.Forms.TextBox();
            this.PlaceInfo_NewData4Box = new System.Windows.Forms.TextBox();
            this.PlaceInfo_NewData2Box = new System.Windows.Forms.TextBox();
            this.PlaceInfo_NewData3Box = new System.Windows.Forms.TextBox();
            this.PlaceInfo_DBParmsGroupBox = new System.Windows.Forms.GroupBox();
            this.PlaceInfo_DBHostBox = new System.Windows.Forms.ComboBox();
            this.PlaceInfo_DBConnectTestButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PlaceInfo_DBEncodingBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PlaceInfo_DBPasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PlaceInfo_DBUsernameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlaceInfo_DBBrowseButton = new System.Windows.Forms.Button();
            this.PlaceInfo_DBPathBox = new System.Windows.Forms.TextBox();
            this.PostItemParamPage = new System.Windows.Forms.TabPage();
            this.PostItemPar_SingleButton = new System.Windows.Forms.Button();
            this.PostItemPar_MultipleUsersButton = new System.Windows.Forms.Button();
            this.PostItemPar_ParamsGetButton = new System.Windows.Forms.Button();
            this.PostItemPar_ForAllBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PostItemPar_UsersGetButton = new System.Windows.Forms.Button();
            this.PostItemPar_UsersBox = new System.Windows.Forms.ComboBox();
            this.PostItemPar_UpdateParamBox = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.PostItemPar_ParamValBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PostItemPar_ParamGetValButton = new System.Windows.Forms.Button();
            this.PostItemPar_ParamsBox = new System.Windows.Forms.ComboBox();
            this.PostItemPar_DBParmsGroupBox = new System.Windows.Forms.GroupBox();
            this.PostItemPar_DBHostBox = new System.Windows.Forms.ComboBox();
            this.PostItemPar_DBConnectTestButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PostItemPar_DBEncodingBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PostItemPar_DBPasswordBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PostItemPar_DBUsernameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PostItemPar_DBBrowseButton = new System.Windows.Forms.Button();
            this.PostItemPar_DBPathBox = new System.Windows.Forms.TextBox();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainTabControl.SuspendLayout();
            this.PlaceInfoPage.SuspendLayout();
            this.PlaceInfo_CurrentDataGroupBox.SuspendLayout();
            this.PlaceInfo_NewDataGroupBox.SuspendLayout();
            this.PlaceInfo_DBParmsGroupBox.SuspendLayout();
            this.PostItemParamPage.SuspendLayout();
            this.PostItemPar_DBParmsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.PlaceInfoPage);
            this.MainTabControl.Controls.Add(this.PostItemParamPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(614, 541);
            this.MainTabControl.TabIndex = 0;
            // 
            // PlaceInfoPage
            // 
            this.PlaceInfoPage.Controls.Add(this.PlaceInfo_ApplyChangesButton);
            this.PlaceInfoPage.Controls.Add(this.PlaceInfo_CurrentDataGroupBox);
            this.PlaceInfoPage.Controls.Add(this.PlaceInfo_NewDataGroupBox);
            this.PlaceInfoPage.Controls.Add(this.PlaceInfo_DBParmsGroupBox);
            this.PlaceInfoPage.Location = new System.Drawing.Point(4, 27);
            this.PlaceInfoPage.Name = "PlaceInfoPage";
            this.PlaceInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlaceInfoPage.Size = new System.Drawing.Size(606, 510);
            this.PlaceInfoPage.TabIndex = 0;
            this.PlaceInfoPage.Text = "Адрес и режим работы подразделения";
            this.PlaceInfoPage.UseVisualStyleBackColor = true;
            // 
            // PlaceInfo_ApplyChangesButton
            // 
            this.PlaceInfo_ApplyChangesButton.Location = new System.Drawing.Point(8, 474);
            this.PlaceInfo_ApplyChangesButton.Name = "PlaceInfo_ApplyChangesButton";
            this.PlaceInfo_ApplyChangesButton.Size = new System.Drawing.Size(584, 28);
            this.PlaceInfo_ApplyChangesButton.TabIndex = 3;
            this.PlaceInfo_ApplyChangesButton.Text = "Внести изменения на отделении";
            this.PlaceInfo_ApplyChangesButton.UseVisualStyleBackColor = true;
            this.PlaceInfo_ApplyChangesButton.Click += new System.EventHandler(this.PlaceInfo_ApplyChangesButton_Click);
            // 
            // PlaceInfo_CurrentDataGroupBox
            // 
            this.PlaceInfo_CurrentDataGroupBox.Controls.Add(this.PlaceInfo_SaveCurrentDataButton);
            this.PlaceInfo_CurrentDataGroupBox.Controls.Add(this.PlaceInfo_CurrentDataBox);
            this.PlaceInfo_CurrentDataGroupBox.Controls.Add(this.PlaceInfo_UpdateCurrentDataButton);
            this.PlaceInfo_CurrentDataGroupBox.Location = new System.Drawing.Point(8, 204);
            this.PlaceInfo_CurrentDataGroupBox.Name = "PlaceInfo_CurrentDataGroupBox";
            this.PlaceInfo_CurrentDataGroupBox.Size = new System.Drawing.Size(286, 230);
            this.PlaceInfo_CurrentDataGroupBox.TabIndex = 1;
            this.PlaceInfo_CurrentDataGroupBox.TabStop = false;
            this.PlaceInfo_CurrentDataGroupBox.Text = "Текущие данные подразделения";
            // 
            // PlaceInfo_SaveCurrentDataButton
            // 
            this.PlaceInfo_SaveCurrentDataButton.Location = new System.Drawing.Point(150, 196);
            this.PlaceInfo_SaveCurrentDataButton.Name = "PlaceInfo_SaveCurrentDataButton";
            this.PlaceInfo_SaveCurrentDataButton.Size = new System.Drawing.Size(130, 28);
            this.PlaceInfo_SaveCurrentDataButton.TabIndex = 6;
            this.PlaceInfo_SaveCurrentDataButton.Text = "Сохранить";
            this.PlaceInfo_SaveCurrentDataButton.UseVisualStyleBackColor = true;
            this.PlaceInfo_SaveCurrentDataButton.Click += new System.EventHandler(this.PlaceInfo_SaveCurrentDataButton_Click);
            // 
            // PlaceInfo_CurrentDataBox
            // 
            this.PlaceInfo_CurrentDataBox.BackColor = System.Drawing.Color.White;
            this.PlaceInfo_CurrentDataBox.Location = new System.Drawing.Point(6, 23);
            this.PlaceInfo_CurrentDataBox.Multiline = true;
            this.PlaceInfo_CurrentDataBox.Name = "PlaceInfo_CurrentDataBox";
            this.PlaceInfo_CurrentDataBox.ReadOnly = true;
            this.PlaceInfo_CurrentDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PlaceInfo_CurrentDataBox.Size = new System.Drawing.Size(274, 167);
            this.PlaceInfo_CurrentDataBox.TabIndex = 6;
            // 
            // PlaceInfo_UpdateCurrentDataButton
            // 
            this.PlaceInfo_UpdateCurrentDataButton.Location = new System.Drawing.Point(6, 196);
            this.PlaceInfo_UpdateCurrentDataButton.Name = "PlaceInfo_UpdateCurrentDataButton";
            this.PlaceInfo_UpdateCurrentDataButton.Size = new System.Drawing.Size(130, 28);
            this.PlaceInfo_UpdateCurrentDataButton.TabIndex = 5;
            this.PlaceInfo_UpdateCurrentDataButton.Text = "Получить";
            this.PlaceInfo_UpdateCurrentDataButton.UseVisualStyleBackColor = true;
            this.PlaceInfo_UpdateCurrentDataButton.Click += new System.EventHandler(this.PlaceInfo_UpdateCurrentDataButton_Click);
            // 
            // PlaceInfo_NewDataGroupBox
            // 
            this.PlaceInfo_NewDataGroupBox.Controls.Add(this.label7);
            this.PlaceInfo_NewDataGroupBox.Controls.Add(this.PlaceInfo_UploadNewDataFileButton);
            this.PlaceInfo_NewDataGroupBox.Controls.Add(this.PlaceInfo_NewData5Box);
            this.PlaceInfo_NewDataGroupBox.Controls.Add(this.PlaceInfo_NewData1Box);
            this.PlaceInfo_NewDataGroupBox.Controls.Add(this.PlaceInfo_NewData4Box);
            this.PlaceInfo_NewDataGroupBox.Controls.Add(this.PlaceInfo_NewData2Box);
            this.PlaceInfo_NewDataGroupBox.Controls.Add(this.PlaceInfo_NewData3Box);
            this.PlaceInfo_NewDataGroupBox.Location = new System.Drawing.Point(306, 204);
            this.PlaceInfo_NewDataGroupBox.Name = "PlaceInfo_NewDataGroupBox";
            this.PlaceInfo_NewDataGroupBox.Size = new System.Drawing.Size(286, 230);
            this.PlaceInfo_NewDataGroupBox.TabIndex = 2;
            this.PlaceInfo_NewDataGroupBox.TabStop = false;
            this.PlaceInfo_NewDataGroupBox.Text = "Новые данные подразделения";
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
            // PlaceInfo_UploadNewDataFileButton
            // 
            this.PlaceInfo_UploadNewDataFileButton.Location = new System.Drawing.Point(6, 196);
            this.PlaceInfo_UploadNewDataFileButton.Name = "PlaceInfo_UploadNewDataFileButton";
            this.PlaceInfo_UploadNewDataFileButton.Size = new System.Drawing.Size(274, 28);
            this.PlaceInfo_UploadNewDataFileButton.TabIndex = 5;
            this.PlaceInfo_UploadNewDataFileButton.Text = "Загрузить из текстового файла";
            this.PlaceInfo_UploadNewDataFileButton.UseVisualStyleBackColor = true;
            this.PlaceInfo_UploadNewDataFileButton.Click += new System.EventHandler(this.PlaceInfo_UploadNewDataFileButton_Click);
            // 
            // PlaceInfo_NewData5Box
            // 
            this.PlaceInfo_NewData5Box.Location = new System.Drawing.Point(17, 159);
            this.PlaceInfo_NewData5Box.MaxLength = 28;
            this.PlaceInfo_NewData5Box.Name = "PlaceInfo_NewData5Box";
            this.PlaceInfo_NewData5Box.Size = new System.Drawing.Size(251, 24);
            this.PlaceInfo_NewData5Box.TabIndex = 4;
            // 
            // PlaceInfo_NewData1Box
            // 
            this.PlaceInfo_NewData1Box.Location = new System.Drawing.Point(17, 41);
            this.PlaceInfo_NewData1Box.MaxLength = 28;
            this.PlaceInfo_NewData1Box.Name = "PlaceInfo_NewData1Box";
            this.PlaceInfo_NewData1Box.Size = new System.Drawing.Size(251, 24);
            this.PlaceInfo_NewData1Box.TabIndex = 0;
            // 
            // PlaceInfo_NewData4Box
            // 
            this.PlaceInfo_NewData4Box.Location = new System.Drawing.Point(17, 131);
            this.PlaceInfo_NewData4Box.MaxLength = 28;
            this.PlaceInfo_NewData4Box.Name = "PlaceInfo_NewData4Box";
            this.PlaceInfo_NewData4Box.Size = new System.Drawing.Size(251, 24);
            this.PlaceInfo_NewData4Box.TabIndex = 3;
            // 
            // PlaceInfo_NewData2Box
            // 
            this.PlaceInfo_NewData2Box.Location = new System.Drawing.Point(17, 71);
            this.PlaceInfo_NewData2Box.MaxLength = 28;
            this.PlaceInfo_NewData2Box.Name = "PlaceInfo_NewData2Box";
            this.PlaceInfo_NewData2Box.Size = new System.Drawing.Size(251, 24);
            this.PlaceInfo_NewData2Box.TabIndex = 1;
            // 
            // PlaceInfo_NewData3Box
            // 
            this.PlaceInfo_NewData3Box.Location = new System.Drawing.Point(17, 101);
            this.PlaceInfo_NewData3Box.MaxLength = 28;
            this.PlaceInfo_NewData3Box.Name = "PlaceInfo_NewData3Box";
            this.PlaceInfo_NewData3Box.Size = new System.Drawing.Size(251, 24);
            this.PlaceInfo_NewData3Box.TabIndex = 2;
            // 
            // PlaceInfo_DBParmsGroupBox
            // 
            this.PlaceInfo_DBParmsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.PlaceInfo_DBHostBox);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.PlaceInfo_DBConnectTestButton);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.label5);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.PlaceInfo_DBEncodingBox);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.label4);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.PlaceInfo_DBPasswordBox);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.label3);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.PlaceInfo_DBUsernameBox);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.label2);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.label1);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.PlaceInfo_DBBrowseButton);
            this.PlaceInfo_DBParmsGroupBox.Controls.Add(this.PlaceInfo_DBPathBox);
            this.PlaceInfo_DBParmsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.PlaceInfo_DBParmsGroupBox.Name = "PlaceInfo_DBParmsGroupBox";
            this.PlaceInfo_DBParmsGroupBox.Size = new System.Drawing.Size(590, 174);
            this.PlaceInfo_DBParmsGroupBox.TabIndex = 0;
            this.PlaceInfo_DBParmsGroupBox.TabStop = false;
            this.PlaceInfo_DBParmsGroupBox.Text = "Параметры подключения к БД";
            // 
            // PlaceInfo_DBHostBox
            // 
            this.PlaceInfo_DBHostBox.DropDownWidth = 280;
            this.PlaceInfo_DBHostBox.FormattingEnabled = true;
            this.PlaceInfo_DBHostBox.Location = new System.Drawing.Point(6, 99);
            this.PlaceInfo_DBHostBox.MaxLength = 256;
            this.PlaceInfo_DBHostBox.Name = "PlaceInfo_DBHostBox";
            this.PlaceInfo_DBHostBox.Size = new System.Drawing.Size(145, 26);
            this.PlaceInfo_DBHostBox.TabIndex = 2;
            // 
            // PlaceInfo_DBConnectTestButton
            // 
            this.PlaceInfo_DBConnectTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaceInfo_DBConnectTestButton.Location = new System.Drawing.Point(6, 140);
            this.PlaceInfo_DBConnectTestButton.Name = "PlaceInfo_DBConnectTestButton";
            this.PlaceInfo_DBConnectTestButton.Size = new System.Drawing.Size(578, 28);
            this.PlaceInfo_DBConnectTestButton.TabIndex = 6;
            this.PlaceInfo_DBConnectTestButton.Text = "Тест подключения";
            this.PlaceInfo_DBConnectTestButton.UseVisualStyleBackColor = true;
            this.PlaceInfo_DBConnectTestButton.Click += new System.EventHandler(this.PlaceInfo_DBConnectTestButton_Click);
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
            // PlaceInfo_DBEncodingBox
            // 
            this.PlaceInfo_DBEncodingBox.FormattingEnabled = true;
            this.PlaceInfo_DBEncodingBox.Location = new System.Drawing.Point(459, 99);
            this.PlaceInfo_DBEncodingBox.Name = "PlaceInfo_DBEncodingBox";
            this.PlaceInfo_DBEncodingBox.Size = new System.Drawing.Size(125, 26);
            this.PlaceInfo_DBEncodingBox.TabIndex = 5;
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
            // PlaceInfo_DBPasswordBox
            // 
            this.PlaceInfo_DBPasswordBox.Location = new System.Drawing.Point(308, 100);
            this.PlaceInfo_DBPasswordBox.MaxLength = 32;
            this.PlaceInfo_DBPasswordBox.Name = "PlaceInfo_DBPasswordBox";
            this.PlaceInfo_DBPasswordBox.Size = new System.Drawing.Size(145, 24);
            this.PlaceInfo_DBPasswordBox.TabIndex = 4;
            this.PlaceInfo_DBPasswordBox.UseSystemPasswordChar = true;
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
            // PlaceInfo_DBUsernameBox
            // 
            this.PlaceInfo_DBUsernameBox.Location = new System.Drawing.Point(157, 100);
            this.PlaceInfo_DBUsernameBox.MaxLength = 32;
            this.PlaceInfo_DBUsernameBox.Name = "PlaceInfo_DBUsernameBox";
            this.PlaceInfo_DBUsernameBox.Size = new System.Drawing.Size(145, 24);
            this.PlaceInfo_DBUsernameBox.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к файлу БД";
            // 
            // PlaceInfo_DBBrowseButton
            // 
            this.PlaceInfo_DBBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaceInfo_DBBrowseButton.Location = new System.Drawing.Point(496, 42);
            this.PlaceInfo_DBBrowseButton.Name = "PlaceInfo_DBBrowseButton";
            this.PlaceInfo_DBBrowseButton.Size = new System.Drawing.Size(88, 28);
            this.PlaceInfo_DBBrowseButton.TabIndex = 1;
            this.PlaceInfo_DBBrowseButton.Text = "Обзор";
            this.PlaceInfo_DBBrowseButton.UseVisualStyleBackColor = true;
            this.PlaceInfo_DBBrowseButton.Click += new System.EventHandler(this.PlaceInfo_DBBrowseButton_Click);
            // 
            // PlaceInfo_DBPathBox
            // 
            this.PlaceInfo_DBPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaceInfo_DBPathBox.Location = new System.Drawing.Point(6, 44);
            this.PlaceInfo_DBPathBox.Name = "PlaceInfo_DBPathBox";
            this.PlaceInfo_DBPathBox.Size = new System.Drawing.Size(484, 24);
            this.PlaceInfo_DBPathBox.TabIndex = 0;
            // 
            // PostItemParamPage
            // 
            this.PostItemParamPage.Controls.Add(this.PostItemPar_SingleButton);
            this.PostItemParamPage.Controls.Add(this.PostItemPar_MultipleUsersButton);
            this.PostItemParamPage.Controls.Add(this.PostItemPar_ParamsGetButton);
            this.PostItemParamPage.Controls.Add(this.PostItemPar_ForAllBox);
            this.PostItemParamPage.Controls.Add(this.label14);
            this.PostItemParamPage.Controls.Add(this.PostItemPar_UsersGetButton);
            this.PostItemParamPage.Controls.Add(this.PostItemPar_UsersBox);
            this.PostItemParamPage.Controls.Add(this.PostItemPar_UpdateParamBox);
            this.PostItemParamPage.Controls.Add(this.label13);
            this.PostItemParamPage.Controls.Add(this.PostItemPar_ParamValBox);
            this.PostItemParamPage.Controls.Add(this.label12);
            this.PostItemParamPage.Controls.Add(this.PostItemPar_ParamGetValButton);
            this.PostItemParamPage.Controls.Add(this.PostItemPar_ParamsBox);
            this.PostItemParamPage.Controls.Add(this.PostItemPar_DBParmsGroupBox);
            this.PostItemParamPage.Location = new System.Drawing.Point(4, 27);
            this.PostItemParamPage.Name = "PostItemParamPage";
            this.PostItemParamPage.Size = new System.Drawing.Size(606, 510);
            this.PostItemParamPage.TabIndex = 1;
            this.PostItemParamPage.Text = "Параметры ИС ОПС Почтовые отправления";
            this.PostItemParamPage.UseVisualStyleBackColor = true;
            // 
            // PostItemPar_SingleButton
            // 
            this.PostItemPar_SingleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_SingleButton.Location = new System.Drawing.Point(306, 378);
            this.PostItemPar_SingleButton.Name = "PostItemPar_SingleButton";
            this.PostItemPar_SingleButton.Size = new System.Drawing.Size(292, 28);
            this.PostItemPar_SingleButton.TabIndex = 8;
            this.PostItemPar_SingleButton.Text = "Параметр для одного пользователя";
            this.PostItemPar_SingleButton.UseVisualStyleBackColor = true;
            this.PostItemPar_SingleButton.Click += new System.EventHandler(this.PostItemPar_SingleButton_Click);
            // 
            // PostItemPar_MultipleUsersButton
            // 
            this.PostItemPar_MultipleUsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_MultipleUsersButton.Location = new System.Drawing.Point(8, 378);
            this.PostItemPar_MultipleUsersButton.Name = "PostItemPar_MultipleUsersButton";
            this.PostItemPar_MultipleUsersButton.Size = new System.Drawing.Size(292, 28);
            this.PostItemPar_MultipleUsersButton.TabIndex = 7;
            this.PostItemPar_MultipleUsersButton.Text = "Параметр для всех пользователей";
            this.PostItemPar_MultipleUsersButton.UseVisualStyleBackColor = true;
            this.PostItemPar_MultipleUsersButton.Click += new System.EventHandler(this.PostItemPar_MultipleUsersButton_Click);
            // 
            // PostItemPar_ParamsGetButton
            // 
            this.PostItemPar_ParamsGetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_ParamsGetButton.Location = new System.Drawing.Point(446, 276);
            this.PostItemPar_ParamsGetButton.Name = "PostItemPar_ParamsGetButton";
            this.PostItemPar_ParamsGetButton.Size = new System.Drawing.Size(152, 28);
            this.PostItemPar_ParamsGetButton.TabIndex = 4;
            this.PostItemPar_ParamsGetButton.Text = "Получить список";
            this.PostItemPar_ParamsGetButton.UseVisualStyleBackColor = true;
            this.PostItemPar_ParamsGetButton.Click += new System.EventHandler(this.PostItemPar_ParamsGetButton_Click);
            // 
            // PostItemPar_ForAllBox
            // 
            this.PostItemPar_ForAllBox.AutoSize = true;
            this.PostItemPar_ForAllBox.Location = new System.Drawing.Point(8, 446);
            this.PostItemPar_ForAllBox.Name = "PostItemPar_ForAllBox";
            this.PostItemPar_ForAllBox.Size = new System.Drawing.Size(272, 22);
            this.PostItemPar_ForAllBox.TabIndex = 9;
            this.PostItemPar_ForAllBox.Text = "Изменить для всех пользователей";
            this.PostItemPar_ForAllBox.UseVisualStyleBackColor = true;
            this.PostItemPar_ForAllBox.CheckedChanged += new System.EventHandler(this.PostItemPar_ForAllBox_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 18);
            this.label14.TabIndex = 19;
            this.label14.Text = "Пользователь";
            // 
            // PostItemPar_UsersGetButton
            // 
            this.PostItemPar_UsersGetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_UsersGetButton.Location = new System.Drawing.Point(446, 226);
            this.PostItemPar_UsersGetButton.Name = "PostItemPar_UsersGetButton";
            this.PostItemPar_UsersGetButton.Size = new System.Drawing.Size(152, 28);
            this.PostItemPar_UsersGetButton.TabIndex = 2;
            this.PostItemPar_UsersGetButton.Text = "Получить список";
            this.PostItemPar_UsersGetButton.UseVisualStyleBackColor = true;
            this.PostItemPar_UsersGetButton.Click += new System.EventHandler(this.PostItemPar_UsersGetButton_Click);
            // 
            // PostItemPar_UsersBox
            // 
            this.PostItemPar_UsersBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostItemPar_UsersBox.DropDownWidth = 590;
            this.PostItemPar_UsersBox.FormattingEnabled = true;
            this.PostItemPar_UsersBox.Location = new System.Drawing.Point(8, 227);
            this.PostItemPar_UsersBox.Name = "PostItemPar_UsersBox";
            this.PostItemPar_UsersBox.Size = new System.Drawing.Size(432, 26);
            this.PostItemPar_UsersBox.TabIndex = 1;
            // 
            // PostItemPar_UpdateParamBox
            // 
            this.PostItemPar_UpdateParamBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_UpdateParamBox.Location = new System.Drawing.Point(8, 474);
            this.PostItemPar_UpdateParamBox.Name = "PostItemPar_UpdateParamBox";
            this.PostItemPar_UpdateParamBox.Size = new System.Drawing.Size(590, 28);
            this.PostItemPar_UpdateParamBox.TabIndex = 10;
            this.PostItemPar_UpdateParamBox.Text = "Изменить значение";
            this.PostItemPar_UpdateParamBox.UseVisualStyleBackColor = true;
            this.PostItemPar_UpdateParamBox.Click += new System.EventHandler(this.PostItemPar_UpdateParamBox_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "Значение параметра";
            // 
            // PostItemPar_ParamValBox
            // 
            this.PostItemPar_ParamValBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_ParamValBox.Location = new System.Drawing.Point(8, 336);
            this.PostItemPar_ParamValBox.MaxLength = 2048;
            this.PostItemPar_ParamValBox.Name = "PostItemPar_ParamValBox";
            this.PostItemPar_ParamValBox.Size = new System.Drawing.Size(432, 24);
            this.PostItemPar_ParamValBox.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Параметр";
            // 
            // PostItemPar_ParamGetValButton
            // 
            this.PostItemPar_ParamGetValButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_ParamGetValButton.Location = new System.Drawing.Point(446, 334);
            this.PostItemPar_ParamGetValButton.Name = "PostItemPar_ParamGetValButton";
            this.PostItemPar_ParamGetValButton.Size = new System.Drawing.Size(152, 28);
            this.PostItemPar_ParamGetValButton.TabIndex = 6;
            this.PostItemPar_ParamGetValButton.Text = "Получить значение";
            this.PostItemPar_ParamGetValButton.UseVisualStyleBackColor = true;
            this.PostItemPar_ParamGetValButton.Click += new System.EventHandler(this.PostItemPar_ParamGetValBox_Click);
            // 
            // PostItemPar_ParamsBox
            // 
            this.PostItemPar_ParamsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostItemPar_ParamsBox.DropDownWidth = 590;
            this.PostItemPar_ParamsBox.FormattingEnabled = true;
            this.PostItemPar_ParamsBox.Location = new System.Drawing.Point(8, 277);
            this.PostItemPar_ParamsBox.Name = "PostItemPar_ParamsBox";
            this.PostItemPar_ParamsBox.Size = new System.Drawing.Size(432, 26);
            this.PostItemPar_ParamsBox.TabIndex = 3;
            // 
            // PostItemPar_DBParmsGroupBox
            // 
            this.PostItemPar_DBParmsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.PostItemPar_DBHostBox);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.PostItemPar_DBConnectTestButton);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.label6);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.PostItemPar_DBEncodingBox);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.label8);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.PostItemPar_DBPasswordBox);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.label9);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.PostItemPar_DBUsernameBox);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.label10);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.label11);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.PostItemPar_DBBrowseButton);
            this.PostItemPar_DBParmsGroupBox.Controls.Add(this.PostItemPar_DBPathBox);
            this.PostItemPar_DBParmsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.PostItemPar_DBParmsGroupBox.Name = "PostItemPar_DBParmsGroupBox";
            this.PostItemPar_DBParmsGroupBox.Size = new System.Drawing.Size(590, 174);
            this.PostItemPar_DBParmsGroupBox.TabIndex = 0;
            this.PostItemPar_DBParmsGroupBox.TabStop = false;
            this.PostItemPar_DBParmsGroupBox.Text = "Параметры подключения к БД";
            // 
            // PostItemPar_DBHostBox
            // 
            this.PostItemPar_DBHostBox.DropDownWidth = 280;
            this.PostItemPar_DBHostBox.FormattingEnabled = true;
            this.PostItemPar_DBHostBox.Location = new System.Drawing.Point(6, 99);
            this.PostItemPar_DBHostBox.MaxLength = 256;
            this.PostItemPar_DBHostBox.Name = "PostItemPar_DBHostBox";
            this.PostItemPar_DBHostBox.Size = new System.Drawing.Size(145, 26);
            this.PostItemPar_DBHostBox.TabIndex = 2;
            // 
            // PostItemPar_DBConnectTestButton
            // 
            this.PostItemPar_DBConnectTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_DBConnectTestButton.Location = new System.Drawing.Point(6, 140);
            this.PostItemPar_DBConnectTestButton.Name = "PostItemPar_DBConnectTestButton";
            this.PostItemPar_DBConnectTestButton.Size = new System.Drawing.Size(578, 28);
            this.PostItemPar_DBConnectTestButton.TabIndex = 6;
            this.PostItemPar_DBConnectTestButton.Text = "Тест подключения";
            this.PostItemPar_DBConnectTestButton.UseVisualStyleBackColor = true;
            this.PostItemPar_DBConnectTestButton.Click += new System.EventHandler(this.PostItemPar_DBConnectTestButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Кодировка";
            // 
            // PostItemPar_DBEncodingBox
            // 
            this.PostItemPar_DBEncodingBox.FormattingEnabled = true;
            this.PostItemPar_DBEncodingBox.Location = new System.Drawing.Point(459, 99);
            this.PostItemPar_DBEncodingBox.Name = "PostItemPar_DBEncodingBox";
            this.PostItemPar_DBEncodingBox.Size = new System.Drawing.Size(125, 26);
            this.PostItemPar_DBEncodingBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Пароль";
            // 
            // PostItemPar_DBPasswordBox
            // 
            this.PostItemPar_DBPasswordBox.Location = new System.Drawing.Point(308, 100);
            this.PostItemPar_DBPasswordBox.MaxLength = 32;
            this.PostItemPar_DBPasswordBox.Name = "PostItemPar_DBPasswordBox";
            this.PostItemPar_DBPasswordBox.Size = new System.Drawing.Size(145, 24);
            this.PostItemPar_DBPasswordBox.TabIndex = 4;
            this.PostItemPar_DBPasswordBox.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Логин";
            // 
            // PostItemPar_DBUsernameBox
            // 
            this.PostItemPar_DBUsernameBox.Location = new System.Drawing.Point(157, 100);
            this.PostItemPar_DBUsernameBox.MaxLength = 32;
            this.PostItemPar_DBUsernameBox.Name = "PostItemPar_DBUsernameBox";
            this.PostItemPar_DBUsernameBox.Size = new System.Drawing.Size(145, 24);
            this.PostItemPar_DBUsernameBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Хост";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Путь к файлу БД";
            // 
            // PostItemPar_DBBrowseButton
            // 
            this.PostItemPar_DBBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_DBBrowseButton.Location = new System.Drawing.Point(496, 42);
            this.PostItemPar_DBBrowseButton.Name = "PostItemPar_DBBrowseButton";
            this.PostItemPar_DBBrowseButton.Size = new System.Drawing.Size(88, 28);
            this.PostItemPar_DBBrowseButton.TabIndex = 1;
            this.PostItemPar_DBBrowseButton.Text = "Обзор";
            this.PostItemPar_DBBrowseButton.UseVisualStyleBackColor = true;
            this.PostItemPar_DBBrowseButton.Click += new System.EventHandler(this.PostItemPar_DBBrowseButton_Click);
            // 
            // PostItemPar_DBPathBox
            // 
            this.PostItemPar_DBPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostItemPar_DBPathBox.Location = new System.Drawing.Point(6, 44);
            this.PostItemPar_DBPathBox.Name = "PostItemPar_DBPathBox";
            this.PostItemPar_DBPathBox.Size = new System.Drawing.Size(484, 24);
            this.PostItemPar_DBPathBox.TabIndex = 0;
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
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Что сегодня? (для вызова справки нажмите F1)";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.MainTabControl.ResumeLayout(false);
            this.PlaceInfoPage.ResumeLayout(false);
            this.PlaceInfo_CurrentDataGroupBox.ResumeLayout(false);
            this.PlaceInfo_CurrentDataGroupBox.PerformLayout();
            this.PlaceInfo_NewDataGroupBox.ResumeLayout(false);
            this.PlaceInfo_NewDataGroupBox.PerformLayout();
            this.PlaceInfo_DBParmsGroupBox.ResumeLayout(false);
            this.PlaceInfo_DBParmsGroupBox.PerformLayout();
            this.PostItemParamPage.ResumeLayout(false);
            this.PostItemParamPage.PerformLayout();
            this.PostItemPar_DBParmsGroupBox.ResumeLayout(false);
            this.PostItemPar_DBParmsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PlaceInfoPage;
        private System.Windows.Forms.GroupBox PlaceInfo_DBParmsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlaceInfo_DBBrowseButton;
        private System.Windows.Forms.TextBox PlaceInfo_DBPathBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PlaceInfo_DBEncodingBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlaceInfo_DBPasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PlaceInfo_DBUsernameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog MainOpenFileDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PlaceInfo_NewData1Box;
        private System.Windows.Forms.GroupBox PlaceInfo_NewDataGroupBox;
        private System.Windows.Forms.TextBox PlaceInfo_NewData5Box;
        private System.Windows.Forms.TextBox PlaceInfo_NewData4Box;
        private System.Windows.Forms.TextBox PlaceInfo_NewData2Box;
        private System.Windows.Forms.TextBox PlaceInfo_NewData3Box;
        private System.Windows.Forms.GroupBox PlaceInfo_CurrentDataGroupBox;
        private System.Windows.Forms.Button PlaceInfo_DBConnectTestButton;
        private System.Windows.Forms.Button PlaceInfo_ApplyChangesButton;
        private System.Windows.Forms.Button PlaceInfo_UpdateCurrentDataButton;
        private System.Windows.Forms.Button PlaceInfo_UploadNewDataFileButton;
        private System.Windows.Forms.TextBox PlaceInfo_CurrentDataBox;
        private System.Windows.Forms.Button PlaceInfo_SaveCurrentDataButton;
        private System.Windows.Forms.SaveFileDialog MainSaveFileDialog;
        private System.Windows.Forms.ComboBox PlaceInfo_DBHostBox;
        private System.Windows.Forms.TabPage PostItemParamPage;
        private System.Windows.Forms.GroupBox PostItemPar_DBParmsGroupBox;
        private System.Windows.Forms.ComboBox PostItemPar_DBHostBox;
        private System.Windows.Forms.Button PostItemPar_DBConnectTestButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PostItemPar_DBEncodingBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PostItemPar_DBPasswordBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PostItemPar_DBUsernameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button PostItemPar_DBBrowseButton;
        private System.Windows.Forms.TextBox PostItemPar_DBPathBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button PostItemPar_ParamGetValButton;
        private System.Windows.Forms.ComboBox PostItemPar_ParamsBox;
        private System.Windows.Forms.TextBox PostItemPar_ParamValBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button PostItemPar_UpdateParamBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button PostItemPar_UsersGetButton;
        private System.Windows.Forms.ComboBox PostItemPar_UsersBox;
        private System.Windows.Forms.CheckBox PostItemPar_ForAllBox;
        private System.Windows.Forms.Button PostItemPar_ParamsGetButton;
        private System.Windows.Forms.Button PostItemPar_SingleButton;
        private System.Windows.Forms.Button PostItemPar_MultipleUsersButton;
    }
}

