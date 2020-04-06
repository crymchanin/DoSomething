using DoSomething.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DoSomething {
    public partial class MainForm : Form {
        private void PostItemParInit() {
            try {
                PostItemPar_DBPathBox.Text = AppHelper.Configuration.PostItemParParms.Database;

                Dictionary<string, string> hosts = AppHelper.Configuration.PostItemParParms.HostList;
                string datasource = AppHelper.Configuration.PostItemParParms.Datasource;
                if (!string.IsNullOrEmpty(datasource)) {
                    if (!hosts.ContainsKey(datasource)) {
                        hosts.Add(datasource, datasource);
                    }
                }
                PostItemPar_DBHostBox.DataSource = null;
                PostItemPar_DBHostBox.DataSource = (hosts.Count > 0) ? new BindingSource(hosts, null) : null;
                PostItemPar_DBHostBox.DisplayMember = "Value";
                PostItemPar_DBHostBox.ValueMember = "Key";
                PostItemPar_DBHostBox.Refresh();
                PostItemPar_DBHostBox.SelectedValue = datasource;

                PostItemPar_DBUsernameBox.Text = AppHelper.Configuration.PostItemParParms.Username;
                PostItemPar_DBPasswordBox.Text = AppHelper.Configuration.PostItemParParms.Password;

                PostItemPar_DBEncodingBox.DataSource = null;
                PostItemPar_DBEncodingBox.DataSource = (AppHelper.Configuration.PostItemParParms.EncodingList.Count > 0)
                    ? new BindingSource(AppHelper.Configuration.PostItemParParms.EncodingList, null) : null;
                PostItemPar_DBEncodingBox.Refresh();
                int index = PostItemPar_DBEncodingBox.Items.IndexOf(AppHelper.Configuration.PostItemParParms.Encoding);
                PostItemPar_DBEncodingBox.SelectedIndex = Math.Max(-1, index);
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private string PostItemPar_GetConnectString() {
            string username = PostItemPar_DBUsernameBox.Text;
            string password = PostItemPar_DBPasswordBox.Text;
            string database = PostItemPar_DBPathBox.Text;
            string datasource = (PostItemPar_DBHostBox.SelectedItem == null) ? PostItemPar_DBHostBox.Text
                : ((KeyValuePair<string, string>)PostItemPar_DBHostBox.SelectedItem).Key;
            string encoding = PostItemPar_DBEncodingBox.SelectedItem as string;

            return string.Format("User={0};Password={1};Database={2};DataSource={3};Charset={4};Pooling=false;Connection lifetime=60;",
                username,
                password,
                database,
                datasource,
                encoding);
        }

        private void PostItemPar_SaveUsedVals() {
            try {
                string username = PostItemPar_DBUsernameBox.Text;
                string password = PostItemPar_DBPasswordBox.Text;
                string database = PostItemPar_DBPathBox.Text;
                string datasource = (PostItemPar_DBHostBox.SelectedItem == null) ? PostItemPar_DBHostBox.Text
                    : ((KeyValuePair<string, string>)PostItemPar_DBHostBox.SelectedItem).Key;

                AppHelper.Configuration.PostItemParParms.Username = username;
                AppHelper.Configuration.PostItemParParms.Password = password;
                AppHelper.Configuration.PostItemParParms.Database = database;
                AppHelper.Configuration.PostItemParParms.Datasource = datasource;
                AppHelper.ConfHelper.SaveConfig(AppHelper.Configuration, Encoding.UTF8, true);
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PostItemPar_DBBrowseButton_Click(object sender, EventArgs e) {
            MainOpenFileDialog.Title = "Выбор базы данных";
            MainOpenFileDialog.FileName = "POSTUNIT.IB";
            MainOpenFileDialog.Filter = "БД InterBase 7.0|*.ib|БД Firebird|*.fdb|БД InterBase|*.gdb|Все файлы|*.*";
            MainOpenFileDialog.CheckFileExists = false;
            MainOpenFileDialog.CheckPathExists = false;
            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK) {
                PostItemPar_DBPathBox.Text = MainOpenFileDialog.FileName;
            }
        }

        private void PostItemPar_DBConnectTestButton_Click(object sender, EventArgs e) {
            bool flag = PostItemParHelper.TestConnection(PostItemPar_GetConnectString());
            MessageBox.Show((flag) ? "Подключение выполнено!" : "Подключение не выполнено!", "Тест подключения", MessageBoxButtons.OK, (flag) ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            PostItemPar_SaveUsedVals();
        }

        private void PostItemPar_ForAllBox_CheckedChanged(object sender, EventArgs e) {
            PostItemPar_UsersBox.Enabled = !PostItemPar_ForAllBox.Checked;
        }

        private void PostItemPar_UsersGetButton_Click(object sender, EventArgs e) {
            try {
                PostItemParHelper.UserInfo[] users = PostItemParHelper.GetUsersList(PostItemPar_GetConnectString()).ToArray();
                PostItemPar_UsersBox.DataSource = null;
                PostItemPar_UsersBox.DataSource = (users.Length > 0)
                    ? new BindingSource(users, null) : null;
                PostItemPar_UsersBox.DisplayMember = "Name";
                PostItemPar_UsersBox.ValueMember = "Id";
                PostItemPar_UsersBox.Refresh();
                PostItemPar_UsersBox.SelectedIndex = Math.Min(0, PostItemPar_UsersBox.Items.Count - 1);
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PostItemPar_ParamsGetButton_Click(object sender, EventArgs e) {
            try {
                string connStr = PostItemPar_GetConnectString();
                PostItemParHelper.ParamInfo[] parameters = PostItemParHelper.GetParamList(connStr, AppHelper.Configuration.PostItemParParms.ParamList).ToArray();
                for (int index = 0; index < parameters.Length; index++) {
                    string pname = PostItemParHelper.GetParamParentName(connStr, parameters[index].ParentId);
                    parameters[index].DisplayName = string.Format("{0} -> {1}", pname, parameters[index].Name);
                }
                PostItemPar_ParamsBox.DataSource = null;
                PostItemPar_ParamsBox.DataSource = (parameters.Length > 0)
                    ? new BindingSource(parameters, null) : null;
                PostItemPar_ParamsBox.DisplayMember = "DisplayName";
                PostItemPar_ParamsBox.ValueMember = "Id";
                PostItemPar_ParamsBox.Refresh();
                PostItemPar_ParamsBox.SelectedIndex = Math.Min(0, PostItemPar_ParamsBox.Items.Count - 1);
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PostItemPar_ParamGetValBox_Click(object sender, EventArgs e) {
            try {
                PostItemParHelper.UserInfo userInfo = ((PostItemParHelper.UserInfo)PostItemPar_UsersBox.SelectedItem);
                PostItemParHelper.ParamInfo paramInfo = ((PostItemParHelper.ParamInfo)PostItemPar_ParamsBox.SelectedItem);
                if (userInfo == null || paramInfo == null) {
                    System.Media.SystemSounds.Beep.Play();
                    return;
                }

                PostItemPar_ParamValBox.Text = PostItemParHelper.GetParamValue(PostItemPar_GetConnectString(), userInfo.Id, paramInfo.Id);
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PostItemPar_MultipleUsersButton_Click(object sender, EventArgs e) {
            try {
                PostItemParHelper.ParamInfo paramInfo = ((PostItemParHelper.ParamInfo)PostItemPar_ParamsBox.SelectedItem);
                if (paramInfo == null) {
                    System.Media.SystemSounds.Beep.Play();
                    return;
                }
                if (MessageBox.Show("Данный параметр будет помечен как многопользовательский. Продолжить выполнение?",
                                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    return;
                }

                PostItemParHelper.SetParamPlaced(PostItemPar_GetConnectString(), paramInfo.Id, true);
                paramInfo.IsPlace = 1;

                MessageBox.Show("Изменения успешно внесены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PostItemPar_SingleButton_Click(object sender, EventArgs e) {
            try {
                PostItemParHelper.ParamInfo paramInfo = ((PostItemParHelper.ParamInfo)PostItemPar_ParamsBox.SelectedItem);
                if (paramInfo == null) {
                    System.Media.SystemSounds.Beep.Play();
                    return;
                }
                if (MessageBox.Show("Данный параметр будет помечен как однопользовательский. Настройки для всех пользователей кроме системного будут удалены. Продолжить выполнение?",
                                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    return;
                }

                string connectionString = PostItemPar_GetConnectString();
                PostItemParHelper.SetParamPlaced(connectionString, paramInfo.Id, false);
                paramInfo.IsPlace = 0;

                PostItemParHelper.DeleteParamValueForAllUsers(connectionString, paramInfo.Id);

                MessageBox.Show("Изменения успешно внесены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PostItemPar_UpdateParamBox_Click(object sender, EventArgs e) {
            try {
                string connectionString = PostItemPar_GetConnectString();
                PostItemParHelper.UserInfo userInfo = ((PostItemParHelper.UserInfo)PostItemPar_UsersBox.SelectedItem);
                PostItemParHelper.ParamInfo paramInfo = ((PostItemParHelper.ParamInfo)PostItemPar_ParamsBox.SelectedItem);
                if ((userInfo == null && !PostItemPar_ForAllBox.Checked) || paramInfo == null) {
                    System.Media.SystemSounds.Beep.Play();
                    return;
                }
                if (MessageBox.Show("Вы действительно хотите внести изменения в БД?", "Внимание",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    return;
                }

                if ((PostItemPar_ForAllBox.Checked || userInfo.Id != 0) && paramInfo.IsPlace <= 0) {
                    if (MessageBox.Show("Данный параметр не помечен как многопользовательский. Установить его многопользовательским и продолжить выполнение?",
                        "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                        return;
                    }
                    else {
                        PostItemParHelper.SetParamPlaced(connectionString, paramInfo.Id, true);
                        paramInfo.IsPlace = 1;
                    }
                }
                short? placeId = (PostItemPar_ForAllBox.Checked) ? null : (short?)userInfo.Id;
                string value = PostItemPar_ParamValBox.Text;
                short result = PostItemParHelper.SetParamValues(connectionString, placeId, paramInfo.Id, paramInfo.DatatypeId, value);
                if (result == -1) {
                    MessageBox.Show("Параметры не заданы. Изменения не были внесены в БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 0) {
                    MessageBox.Show("Невозможно изменить параметр данного типа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Изменения успешно внесены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                AppHelper.CreateMessage(ex.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
            }
        }

        private void PostItemParConnectionCtrls_TextChanged(object sender, EventArgs e) {
            PostItemPar_UsersBox.DataSource = null;
            PostItemPar_ParamsBox.DataSource = null;
            PostItemPar_ParamValBox.Text = "";
        }
    }
}
