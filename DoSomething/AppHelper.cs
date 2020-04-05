﻿using DoSomething.Configuration;
using Feodosiya.Lib.Conf;
using Feodosiya.Lib.IO;
using Feodosiya.Lib.Logs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace DoSomething {
    public static class AppHelper {
        /// <summary>
        /// Конфигурационный файл
        /// </summary>
        public static ConfHelper ConfHelper { get; set; }

        /// <summary>
        /// Конфигурация программы
        /// </summary>
        public static Global Configuration { get; set; }

        /// <summary>
        /// Аргументы программы
        /// </summary>
        public static string[] ARGS { get; set; }

        /// <summary>
        /// Текущая рабочая папка
        /// </summary>
        public static string CurrentDirectory { get; set; }

        /// <summary>
        /// Имя данного продукта
        /// </summary>
        public static string ProductName { get; set; }

        /// <summary>
        /// Лог файл программы
        /// </summary>
        public static Log Log { get; set; }

        /// <summary>
        /// Главное окно программы
        /// </summary>
        public static MainForm MainForm { get; set; }



        /// <summary>
        /// Создает сообщение, которое можно записать в лог, вывести в окне и отправить по почте
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        /// <param name="messageType">Тип сообщения</param>
        /// <param name="showMessageBox">Отображает окно сообщения если установлено в true</param>
        public static void CreateMessage(string message, MessageType messageType, bool showMessageBox = false) {
            Log.Write(message, messageType);

            // Отображает окно сообщения с заданным текстом если true
            if (showMessageBox) {
                MessageBoxIcon msgBoxIcon;
                string msgBoxTitle;
                switch (messageType) {
                    case MessageType.Debug:
                        msgBoxIcon = MessageBoxIcon.Information;
                        msgBoxTitle = "Отладка";
                        break;
                    case MessageType.Error:
                        msgBoxIcon = MessageBoxIcon.Error;
                        msgBoxTitle = "Ошибка";
                        break;
                    case MessageType.Information:
                        msgBoxIcon = MessageBoxIcon.Information;
                        msgBoxTitle = "Информация";
                        break;
                    case MessageType.Warning:
                        msgBoxIcon = MessageBoxIcon.Warning;
                        msgBoxTitle = "Внимание";
                        break;
                    case MessageType.None:
                    default:
                        msgBoxIcon = MessageBoxIcon.None;
                        msgBoxTitle = "Сообщение";
                        break;
                }
                MessageBox.Show(message, msgBoxTitle, MessageBoxButtons.OK, msgBoxIcon);
            }
        }


        /// <summary>
        /// Инициализация программы
        /// </summary>
        /// <returns></returns>
        public static bool Init(MainForm mainForm, out Exception innerException) {
            try {
                Assembly execAssembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(execAssembly.Location);
                CurrentDirectory = IOHelper.GetCurrentDir(execAssembly);
                ProductName = fileVersionInfo.ProductName;
                MainForm = mainForm;

                ARGS = Environment.GetCommandLineArgs();

                Log = new Log(Path.Combine(CurrentDirectory, ProductName + ".log")) { InsertDate = true, AutoCompress = true };
                Log.ExceptionThrownEvent += (e) => MessageBox.Show(e.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                innerException = null;

                return true;
            }
            catch (Exception ex) {
                innerException = ex;
                return false;
            }
        }

        /// <summary>
        /// Инициализация конфигурации приложения
        /// </summary>
        /// <returns></returns>
        public static bool InitConfiguration() {
            try {
                string confPath = Path.Combine(CurrentDirectory, "settings.conf");
                ConfHelper = new ConfHelper(confPath);
                if (!File.Exists(confPath)) {
                    Global defConf = new Global();
                    defConf.PlaceInfoParms = new PlaceInfoParms();
                    defConf.PlaceInfoParms.Database = "";
                    defConf.PlaceInfoParms.Datasource = "localhost";
                    defConf.PlaceInfoParms.EncodingList = new List<string>() { "ASCII", "KOI8R", "KOI8U", "UTF8", "WIN1251" };
                    defConf.PlaceInfoParms.Encoding = "WIN1251";
                    defConf.PlaceInfoParms.Username = "SYSDBA";
                    defConf.PlaceInfoParms.Password = "masterkey";
                    defConf.PlaceInfoParms.HostList = new Dictionary<string, string>();
                    defConf.PlaceInfoParms.HostList.Add("localhost", "localhost");
                    ConfHelper.SaveConfig(defConf, Encoding.UTF8, true);
                    CreateMessage("Файл конфигурации приложения не был обнаружен. Создан файл конфигурации с параметрами по умолчанию.", MessageType.Warning, true);
                }

                Configuration = ConfHelper.LoadConfig<Global>();
                if (!ConfHelper.Success) {
                    CreateMessage("Ошибка при загрузке конфигурации:\r\n" + ConfHelper.LastError.ToString(), MessageType.Error, true);
                    return false;
                }

                return true;
            }
            catch (Exception ex) {
                CreateMessage("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(), MessageType.Error, true);
                return false;
            }
        }
    }
}
