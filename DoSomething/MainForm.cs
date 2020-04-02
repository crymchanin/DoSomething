using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoSomething.Modules;


namespace DoSomething
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();

            DBEncodingBox.SelectedIndex = Math.Max(-1, DBEncodingBox.Items.Count - 1);
        }

        private void DBBrowseButton_Click(object sender, EventArgs e)
        {
            MainOpenFileDialog.Title = "Выбор базы данных";
            MainOpenFileDialog.FileName = "POSTITEM.IB";
            MainOpenFileDialog.Filter = "БД InterBase 7.0|*.ib|БД Firebird|*.fdb|БД InterBase|*.gdb|Все файлы|*.*";
            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                DBPathBox.Text = MainOpenFileDialog.FileName;
            }
        }

        private void DBConnectTestButton_Click(object sender, EventArgs e)
        {
            string username = DBUsernameBox.Text;
            string password = DBPasswordBox.Text;
            string database = DBPathBox.Text;
            string datasource = DBHostBox.Text;

            bool flag = PlaceInfoHelper.TestConnection(username, password, database, datasource);
            MessageBox.Show((flag) ? "Подключение выполнено!" : "Подключение не выполнено!", "Тест подключения", MessageBoxButtons.OK, (flag) ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        private void PrintCurrentData()
        {
            try
            {
                string username = DBUsernameBox.Text;
                string password = DBPasswordBox.Text;
                string database = DBPathBox.Text;
                string datasource = DBHostBox.Text;

                PlaceInfoHelper.PlaceInfo[] placeInfos = PlaceInfoHelper.GetPlaceData(username, password, database, datasource).ToArray();
                string data = "";
                int index = 0;
                foreach (PlaceInfoHelper.PlaceInfo info in placeInfos)
                {
                    data += string.Format("[{0}]\r\n{1}\r\n{2}", info.Name, info.Data, ((index >= placeInfos.Length - 1) ? "" : "\r\n"));
                    index++;
                }
                CurrentDataBox.Text = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCurrentDataButton_Click(object sender, EventArgs e)
        {
            PrintCurrentData();
        }

        private void UploadNewDataFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainOpenFileDialog.Title = "Выбор файла с данными";
                MainOpenFileDialog.FileName = "";
                MainOpenFileDialog.Filter = "Текстовый файл|*.txt|Все файлы|*.*";
                if (MainOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] data = PlaceInfoHelper.UploadTextFile(MainOpenFileDialog.FileName);
                    Control[] ctrls = new Control[] { NewData1Box, NewData2Box, NewData3Box, NewData4Box, NewData5Box }.Select(c => { c.Text = ""; return c; }).ToArray();
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (i >= ctrls.Length) break;

                        ctrls[i].Text = data[i];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCurrentDataButton_Click(object sender, EventArgs e)
        {

        }

        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = DBUsernameBox.Text;
                string password = DBPasswordBox.Text;
                string database = DBPathBox.Text;
                string datasource = DBHostBox.Text;

                string data = "";
                Control[] ctrls = new Control[] { NewData1Box, NewData2Box, NewData3Box, NewData4Box, NewData5Box };
                int index = 0;
                foreach (Control ctrl in ctrls)
                {
                    data += ctrl.Text + ((index >= ctrls.Length - 1) ? "" : "\r\n");
                    index++;
                }
                PlaceInfoHelper.SetPlaceData(username, password, database, datasource, data);

                MessageBox.Show("Изменения успешно внесены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PrintCurrentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
