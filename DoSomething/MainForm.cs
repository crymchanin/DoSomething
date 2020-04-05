using System;
using System.Windows.Forms;


namespace DoSomething {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            Exception innerExeption;
            if (!AppHelper.Init(this, out innerExeption)) {
                AppHelper.CreateMessage(innerExeption.ToString(), Feodosiya.Lib.Logs.MessageType.Error, true);
                Load += (s, e) => Application.Exit();
                return;
            }
            if (!AppHelper.InitConfiguration()) {
                Load += (s, e) => Application.Exit();
                return;
            }

            PlaceInfoInit();
            PostItemParInit();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F1) {
                switch (MainTabControl.SelectedTab.Name) {
                    case "PlaceInfoPage":
                        MessageBox.Show(Properties.Resources.PlaceInfoPage, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "PostItemParamPage":
                        MessageBox.Show(Properties.Resources.PostItemParamPage, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
