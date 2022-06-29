using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tretyakova_LR6
{
    

    public partial class MainForm : Form
    {
        string appName;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.I4)]

        public static extern int GetKeyboardType(int nTypeFlag); /* получение типа (nTypeFlag=0) или подтипа (nTypeFlag=1) клавиатуры */


        public MainForm()
        {
            InitializeComponent();
            appName = "Tretyakova_LR4";
        }

        private void browseDirBut_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                installDir.Text = FBD.SelectedPath + @"\" + appName;
                installBut.Enabled = true;
            }
        }

        private void installBut_Click(object sender, EventArgs e)
        {
            try
            {
                // Установка исполняемого файла ЛР4
                if (!installProgram()) return;

                // Получам информацию
                string machineInfo = getMachineInformation();

                // Хешируем информацию
                byte[] signData, publicKey;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    signData = rsa.SignData(Encoding.GetEncoding(1251).GetBytes(machineInfo), "MD5"); // Получение ЭЦП
                    publicKey = rsa.ExportCspBlob(false); // Экспорт открытого ключа
                }

                // Записываем в реестр ЭЦП и открытый ключ
                Registry.SetValue(registryKey.Text, "Signature", signData);
                Registry.SetValue(registryKey.Text, "Public key", publicKey);

                // Сообщение об успешной установке
                MessageBox.Show($"The application {appName} has been successfully installed along the path: {installDir.Text}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Cryptographic exception: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InstallException ex)
            {
                MessageBox.Show("Install exception: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown exception: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            registryKey.Text = @"HKEY_CURRENT_USER\Software\Tretyakova";
            installBut.Enabled = false;
        }
        private bool installProgram()
        {
            if (!Directory.Exists(appName)) throw new InstallException("Installation files are corrupted"); // Нет установочных файлов
            if (Directory.Exists(installDir.Text)) // Приложение уже установлено по выбранному пути
            {
                if (MessageBox.Show("This application is already installed along this path. Overwrite?", // Перезаписать
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Directory.Delete(installDir.Text, true);
                    copyFolder(appName, installDir.Text);
                }
                else // Не перезаписывать
                {
                    return false;
                }
            }
            else // Приложение не установлено по выбранному пути
            {
                copyFolder(appName, installDir.Text);
            }
            return true;
        }

        private string getMachineInformation()
        {
            string machineInfo = "";
            // Собираемая информация (общая):
            machineInfo += "Имя пользователя: " + Environment.UserName + "\n";  // Имя пользователя
            machineInfo += "Имя компьютера: " + Environment.MachineName + "\n"; // Имя компьютера
            machineInfo += "Путь к папке с OC Windows: " + Environment.GetEnvironmentVariable("windir") + "\n";   // Путь к папке с ОС Windows        
            machineInfo += "Путь к папке с системными файлами OC Windows: " + Environment.SystemDirectory + "\n"; // Путь к папке с системными файлами ОС Windows
            // Информация (45 вариант):

            // тип клавиатуры
            machineInfo += "Тип клавиатуры: " + GetKeyboardType(0) + "\n";
            // количество кнопок мыши
            machineInfo += "Количество кнопок мыши: " + Convert.ToString(SystemInformation.MouseButtons) + "\n";
            // ширина экрана
            machineInfo += "Ширина экрана: " + Convert.ToString(SystemInformation.PrimaryMonitorSize.Width) + "\n";
            // Объем оперативной памяти
            ManagementObjectSearcher mos = new ManagementObjectSearcher("Select * from Win32_PhysicalMemory");
            string temp = "";
            foreach (var i in mos.Get()) { temp += Convert.ToString(i["Capacity"]); }
            machineInfo += "Объем оперативной памяти: " + temp;

            // Объем диска, на который установлена программа
            machineInfo += "Объем диска: " + Convert.ToString(new DriveInfo(
                System.Reflection.Assembly.GetExecutingAssembly().Location
                ).TotalSize) + "\n";
            return machineInfo;
        }

        private void copyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder)) Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                copyFolder(folder, dest);
            }
        }
    }

    class InstallException : Exception
    {
        public InstallException(string message) : base(message) { }
    }
}
