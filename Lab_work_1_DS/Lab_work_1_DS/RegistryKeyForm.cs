using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Lab_work_1_DS
{
    public partial class RegistryKeyForm : Form
    {
        public DecryptionPassword logForm;
        public bool isClosed;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)] 
        [return: MarshalAs(UnmanagedType.I4)]

        public static extern int GetKeyboardType(int nTypeFlag); /* получение типа (nTypeFlag=0) или подтипа (nTypeFlag=1) клавиатуры */

        public RegistryKeyForm()
        {
            isClosed = true;
            InitializeComponent();
        }

        private void okBut_Click(object sender, EventArgs e)
        {
            if (registryKey.Text == "")
            {
                MessageBox.Show("Registry key cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Собираем информацию о машине
                byte[] currentSignData = Encoding.GetEncoding(1251).GetBytes(getMachineInformation());

                // Возьмем информацию из реестра и сравним ее с полученной выше
                byte[] signDataFromReg = new byte[0],
                       publicKey = new byte[0];
                try
                {
                    // Достаем информацию из реестра
                    signDataFromReg = (byte[])Registry.GetValue(registryKey.Text, "Signature", null);
                    publicKey = (byte[])Registry.GetValue(registryKey.Text, "Public key", null);

                    // Сравниваем ЭЦП
                    using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                    {
                        rsa.ImportCspBlob(publicKey);
                        if (rsa.VerifyData(currentSignData, "MD5", signDataFromReg))
                        {
                            logForm.isCorrectRegKey = true;
                            
                        }
                        else
                        {
                            MessageBox.Show("Incorrect registry key. The program will stop working.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Incorrect registry key. The program will stop working.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                isClosed = false;
                //logForm.Enabled = true;
                //Application.Run(new DecryptionPassword());
                this.Close();
            }
        }

        private void RegistryKeyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            e.Cancel = isClosed;
            if (isClosed)
            {
                if (MessageBox.Show("If you close this window, the program will stop working. Close the window?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    isClosed = false;
                    e.Cancel = isClosed;
                }
            }
            //Application.Exit();
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
    }
}
