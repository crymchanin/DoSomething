using DoSomething.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DoSomething {
    public partial class MainForm : Form {

        private void PlaceInfoInit() {
            try {
                PlaceInfo_DBPathBox.Text = AppHelper.Configuration.PlaceInfoParms.Database;

                Dictionary<string, string> hosts = AppHelper.Configuration.PlaceInfoParms.HostList;
                string datasource = AppHelper.Configuration.PlaceInfoParms.Datasource;
                if (!string.IsNullOrEmpty(datasource)) {
                    if (!hosts.ContainsKey(datasource)) {
                        hosts.Add(datasource, datasource);
                    }
                }
                PlaceInfo_DBHostBox.DataSource = null;
                PlaceInfo_DBHostBox.DataSource = (hosts.Count > 0) ? new BindingSource(hosts, null) : null;
                PlaceInfo_DBHostBox.DisplayMember = "Value";
                PlaceInfo_DBHostBox.ValueMember = "Key";
                PlaceInfo_DBHostBox.Refresh();
                PlaceInfo_DBHostBox.SelectedValue = datasource;

                PlaceInfo_DBUsernameBox.Text = AppHelper.Configuration.PlaceInfoParms.Username;
                PlaceInfo_DBPasswordBox.Text = AppHelper.Configuration.PlaceInfoParms.Password;

                PlaceInfo_DBEncodingBox.DataSource = null;
                PlaceInfo_DBEncodingBox.DataSource = (AppHelper.Configuration.PlaceInfoParms.EncodingList.Count > 0)
                    ? new BindingSource(AppHelper.Configuration.PlaceInfoParms.EncodingList, null) : null;
                PlaceInfo_DBEncodingBox.Refresh();
                int index = PlaceInfo_DBEncodingBox.Items.IndexOf(AppHelper.Configuration.PlaceInfoParms.Encoding);
                PlaceInfo_DBEncodingBox.SelectedIndex = Math.Max(-1, index);
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private string PlaceInfo_GetConnectString() {
            string username = PlaceInfo_DBUsernameBox.Text;
            string password = PlaceInfo_DBPasswordBox.Text;
            string database = PlaceInfo_DBPathBox.Text;
            string datasource = (PlaceInfo_DBHostBox.SelectedItem == null) ? PlaceInfo_DBHostBox.Text
                : ((KeyValuePair<string, string>)PlaceInfo_DBHostBox.SelectedItem).Key;
            string encoding = PlaceInfo_DBEncodingBox.SelectedItem as string;

            return string.Format("User={0};Password={1};Database={2};DataSource={3};Charset={4};Pooling=false;Connection lifetime=60;",
                username,
                password,
                database,
                datasource,
                encoding);
        }

        private void PlaceInfo_SaveUsedVals() {
            try {
                string username = PlaceInfo_DBUsernameBox.Text;
                string password = PlaceInfo_DBPasswordBox.Text;
                string database = PlaceInfo_DBPathBox.Text;
                string datasource = (PlaceInfo_DBHostBox.SelectedItem == null) ? PlaceInfo_DBHostBox.Text
                    : ((KeyValuePair<string, string>)PlaceInfo_DBHostBox.SelectedItem).Key;

                AppHelper.Configuration.PlaceInfoParms.Username = username;
                AppHelper.Configuration.PlaceInfoParms.Password = password;
                AppHelper.Configuration.PlaceInfoParms.Database = database;
                AppHelper.Configuration.PlaceInfoParms.Datasource = datasource;
                AppHelper.ConfHelper.SaveConfig(AppHelper.Configuration, Encoding.UTF8, true);
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PlaceInfo_DBBrowseButton_Click(object sender, EventArgs e) {
            MainOpenFileDialog.Title = "Выбор базы данных";
            MainOpenFileDialog.FileName = "POSTITEM.IB";
            MainOpenFileDialog.Filter = "БД InterBase 7.0|*.ib|БД Firebird|*.fdb|БД InterBase|*.gdb|Все файлы|*.*";
            MainOpenFileDialog.CheckFileExists = false;
            MainOpenFileDialog.CheckPathExists = false;
            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK) {
                PlaceInfo_DBPathBox.Text = MainOpenFileDialog.FileName;
            }
        }

        private void PlaceInfo_DBConnectTestButton_Click(object sender, EventArgs e) {
            bool flag = PlaceInfoHelper.TestConnection(PlaceInfo_GetConnectString());
            MessageBox.Show((flag) ? "Подключение выполнено!" : "Подключение не выполнено!", "Тест подключения", MessageBoxButtons.OK, (flag) ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            PlaceInfo_SaveUsedVals();
        }

        private void PlaceInfo_PrintCurrentData() {
            try {
                PlaceInfoHelper.PlaceInfo[] placeInfos = PlaceInfoHelper.GetPlaceData(PlaceInfo_GetConnectString()).ToArray();
                string data = "";
                int index = 0;
                foreach (PlaceInfoHelper.PlaceInfo info in placeInfos) {
                    data += string.Format("[{0}]\r\n{1}\r\n{2}", info.Name, info.Data, ((index >= placeInfos.Length - 1) ? "" : "\r\n"));
                    index++;
                }
                PlaceInfo_CurrentDataBox.Text = data;
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PlaceInfo_UpdateCurrentDataButton_Click(object sender, EventArgs e) {
            PlaceInfo_PrintCurrentData();
            PlaceInfo_SaveUsedVals();
        }

        private void PlaceInfo_UploadNewDataFileButton_Click(object sender, EventArgs e) {
            try {
                MainOpenFileDialog.Title = "Выбор файла с данными";
                MainOpenFileDialog.FileName = "";
                MainOpenFileDialog.Filter = "Текстовый файл|*.txt|Все файлы|*.*";
                MainOpenFileDialog.CheckFileExists = true;
                MainOpenFileDialog.CheckPathExists = true;
                if (MainOpenFileDialog.ShowDialog() == DialogResult.OK) {
                    string[] data = PlaceInfoHelper.UploadTextFile(MainOpenFileDialog.FileName);
                    Control[] ctrls = new Control[] { PlaceInfo_NewData1Box, PlaceInfo_NewData2Box, PlaceInfo_NewData3Box, PlaceInfo_NewData4Box, PlaceInfo_NewData5Box }.Select(c => { c.Text = ""; return c; }).ToArray();
                    for (int i = 0; i < data.Length; i++) {
                        if (i >= ctrls.Length) break;

                        ctrls[i].Text = data[i];
                    }
                }
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PlaceInfo_SaveCurrentDataButton_Click(object sender, EventArgs e) {
            try {
                MainSaveFileDialog.Title = "Сохранение файла с данными";
                MainSaveFileDialog.FileName = "";
                MainSaveFileDialog.Filter = "Текстовый файл|*.txt|Все файлы|*.*";
                if (MainSaveFileDialog.ShowDialog() == DialogResult.OK) {
                    PlaceInfoHelper.SaveTextFile(MainSaveFileDialog.FileName, PlaceInfo_CurrentDataBox.Text);
                }
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PlaceInfo_ApplyChangesButton_Click(object sender, EventArgs e) {
            try {
                if (MessageBox.Show("Вы действительно хотите внести изменения в БД?", "Внимание",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    return;
                }

                string data = "";
                Control[] ctrls = new Control[] { PlaceInfo_NewData1Box, PlaceInfo_NewData2Box, PlaceInfo_NewData3Box, PlaceInfo_NewData4Box, PlaceInfo_NewData5Box };
                int index = 0;
                foreach (Control ctrl in ctrls) {
                    data += ctrl.Text + ((index >= ctrls.Length - 1) ? "" : "\r\n");
                    index++;
                }
                PlaceInfoHelper.SetPlaceData(PlaceInfo_GetConnectString(), data);

                MessageBox.Show("Изменения успешно внесены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PlaceInfo_PrintCurrentData();
                PlaceInfo_SaveUsedVals();
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PlaceInfoConnectionCtrls_TextChanged(object sender, EventArgs e) {
            PlaceInfo_CurrentDataBox.Text = "";
            Control[] ctrls = new Control[] { PlaceInfo_NewData1Box, PlaceInfo_NewData2Box, PlaceInfo_NewData3Box, PlaceInfo_NewData4Box, PlaceInfo_NewData5Box };
            foreach (Control ctrl in ctrls) {
                ctrl.Text = "";
            }
        }
    }
}
