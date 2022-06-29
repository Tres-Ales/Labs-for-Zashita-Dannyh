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

namespace Lab_work_1_DS
{
    public partial class DecryptionPassword : Form
    {
        public LoginForm loginForm;
        public bool isCorrectRegKey;

        public DecryptionPassword()
        {
            // Явно открываем форму для ввода раздела реестра
            isCorrectRegKey = false;
            RegistryKeyForm rkf = new RegistryKeyForm();
            rkf.logForm = this;
            rkf.ShowDialog();

            InitializeComponent();
            /*if (!isCorrectRegKey)
            {
                
                RegistryKeyForm rf = new RegistryKeyForm();
                rf.logForm = this;
                rf.Show();
                this.Enabled = false;
            }*/
            //FileEncryption.CreateEncrypFile();
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (isCorrectRegKey)
            {
                if (PassFile_Text.Text == "")
                {
                    MessageBox.Show(
                        "Password must not be empty",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                }

                else
                {
                    Hide();
                    if (!File.Exists(FileEncryption.encFile))
                    {
                        FileEncryption.passFromForm = PassFile_Text.Text;
                        FileEncryption.CreateEncrypFile();

                    }

                    if (File.Exists(FileEncryption.encFile))
                    {
                        FileEncryption.passFromForm = PassFile_Text.Text;
                        FileEncryption.CreateDecFile();
                    }


                    FileStream fs = File.OpenRead(FileEncryption.decFile);
                    StreamReader sr = new StreamReader(fs);
                    string s = sr.ReadToEnd();
                    fs.Close();
                    if (s.Contains(' '))
                    {
                        s = s.Substring(0, s.IndexOf(' '));
                    }
                    if (s != "ADMIN'")
                    {
                        FileEncryption.DeleteDecrypFile();
                        /*if (File.Exists(FileEncryption.encFile))
                            File.Delete(FileEncryption.encFile);*/

                        MessageBox.Show(
                        "Password is not correct. Program will stop working.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        this.PassFile_Text.Text = "";
                        LoginForm LF = new LoginForm();
                        LF.parent_form = this;
                        LF.Show();
                    }
                }
            }
        }

        private void DecryptionPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
             
            Application.Exit();
        }

        private void DecryptionPassword_Load(object sender, EventArgs e)
        {
            if (!isCorrectRegKey)
            {
                this.Close();
                return;
            }
        }
    }
}
