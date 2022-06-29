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
    public partial class CreatePassForm : Form
    {
        USER User;
        int num_in_doc;
        public CreatePassForm(USER fUser, int n)
        {
            InitializeComponent();
            User = fUser;
            num_in_doc = n;
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (!(ChangePasswordForm.Approved_Pass(User, new_pass_text.Text)))
            { //новый пароль не соответствует ограничениям
                MessageBox.Show(" Пароль не соответствует ограничениям! ");
            }

            else if (new_pass_text.Text != new_pass_text2.Text)
            { //пароли не совпадают
                MessageBox.Show(" Пароли не совпадают! ");
            }
            else if (new_pass_text.Text.Contains(" "))
            { //пароль не должен иметь пробела
                MessageBox.Show(" Пароли не должен содержать символ пробела! ");
            }
            else
            { // все ок, меняем пароли
                int n = num_in_doc;
                string pas = new_pass_text.Text;
                string name = LoginForm.Users[n].username;
                string p_b = "0", p_r = "0";
                if (LoginForm.Users[n].par_blocked) p_b = "1";
                if (LoginForm.Users[n].par_restricted) p_r = "1";


                /*int count = File.ReadAllLines("Info.txt").Length;
                string[] str = new string[count];

                FileStream file = new FileStream("Info.txt", FileMode.Open);
                StreamReader fnew = new StreamReader(file);

                for (int i = 0; i < count; i++)
                    str[i] = fnew.ReadLine();
                fnew.Close();*/

                PasswordCiphering pass = new PasswordCiphering(pas, name);
                pas = pass.GetPasswordCipher();

                LoginForm.Users[n].password = pas;
                LoginForm.Users[n].first_time = false;
                /*FileStream file2 = new FileStream("Info.txt", FileMode.Create);
                StreamWriter fnew2 = new StreamWriter(file2);
                for (int i = 0; i < LoginForm.Users.Count; i++)
                {
                    if (i != n)
                        fnew2.WriteLine(str[i]);
                    else
                        fnew2.WriteLine(name + ' ' + pas + ' ' + "f" + ' ' + p_b + ' ' + p_r);
                }
                fnew2.Close();*/
                if (File.Exists(FileEncryption.encFile)) { File.Delete(FileEncryption.encFile); }
                FileEncryption.CreateEncrypFile();
                
                MessageBox.Show(" Пароль создан ");
                Close();
            }
        }

        private void CreatePassForm_Load(object sender, EventArgs e)
        {

        }
    }
}
