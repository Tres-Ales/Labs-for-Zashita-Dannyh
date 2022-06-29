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
    public partial class ChangePasswordForm : Form
    {
        
        USER User;
        int num_in_doc;
        string pas_from_db;

        
        // проверка пароля нового на соответствие ограничениям, если они поставлены
        public static bool Approved_Pass(USER User,  string password_text)
        {
            List<char> PUNC = new List<char> { ',', '.', '?', ':', '!', ';', '"' };
            
            if (!User.par_restricted)
            {
                return true;
            }
            else
            {
                // задача: чередование знаков препинания-символов кириллицы-знаков препинания
                int first_punc = -1;
                bool flag = false;
                int i = 0;

                while (i < password_text.Length && !flag)
                {
                    if (PUNC.Contains(password_text[i]))
                    {
                        flag = true;
                        first_punc = i;
                    }
                    i++;
                }

                if (first_punc == -1)
                {
                    return false;
                }

                int first_letter = -1;
                flag = false;
                i = 0;

                while (i < password_text.Length && !flag)
                {
                    char c = password_text[i];
                    if ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
                    {
                        flag = true;
                        first_letter = i;
                    }
                    i++;
                }

                string new_str;
                if ((first_letter == -1) || (first_punc == (password_text.Length - 1)) || (first_punc > first_letter))
                {
                    return false;
                }
                else
                {
                    new_str = password_text.Substring(first_letter + 1);
                    int punc_after = -1;
                    flag = false;
                    i = 0;

                    while (i < new_str.Length && !flag)
                    {
                        if (PUNC.Contains(new_str[i]))
                        {
                            flag = true;
                            punc_after = i;
                        }
                        i++;
                    }

                    if (punc_after == -1)
                    {
                        return false;
                    }

                    return true;
                }


            }
        }
        private void Change_but_Click(object sender, EventArgs e)
        {
            var from_doc = new PasswordCiphering(pas_from_db, LoginForm.Users[num_in_doc].username);
            string desh = from_doc.Decipher(from_doc.password);
            if (( desh != old_pass_text.Text))
            { //старый пароль введен неверно
                MessageBox.Show(" Старый пароль введен неверно! ");
            }

            else if (!(Approved_Pass(User, new_pass_text.Text)))
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

            else if (new_pass_text.Text == old_pass_text.Text)
            { //старый пароль совпадает с новым
               MessageBox.Show(" Старый пароль совпадает с новым! ");
            }

            else
            { // все ок, меняем пароли

                int n = num_in_doc;
                PasswordCiphering pass = new PasswordCiphering(new_pass_text.Text, LoginForm.Users[n].username);
                string pas = pass.GetPasswordCipher();
                LoginForm.Users[n].password = pas;

                if (File.Exists(FileEncryption.encFile)) { File.Delete(FileEncryption.encFile); }
                FileEncryption.CreateEncrypFile();

                /*int n = num_in_doc;
                string pas = new_pass_text.Text;
                string name = User.username;
                string p_b = "0", p_r = "0";
                if (User.par_blocked) p_b = "1";
                if (User.par_restricted) p_r = "1";
                */

                /*int count = File.ReadAllLines("Info.txt").Length;
                string[] str = new string[count];

                FileStream file = new FileStream("Info.txt", FileMode.Open);
                StreamReader fnew = new StreamReader(file);

                for (int i = 0; i < count; i++)
                    str[i] = fnew.ReadLine();
                fnew.Close();*/

                /*PasswordCiphering pass = new PasswordCiphering(pas, name);
                pas = pass.GetPasswordCipher();

                FileStream file2 = new FileStream("Info.txt", FileMode.Create);
                StreamWriter fnew2 = new StreamWriter(file2);
                for (int i = 0; i < count; i++)
                {
                    if (i != n)
                        fnew2.WriteLine(str[i]);
                    else
                        fnew2.WriteLine(name + ' ' + pas + ' ' + "f" + ' ' + p_b + ' ' + p_r);
                }
                fnew2.Close();*/

                MessageBox.Show(" Пароль изменен ");
                Close();
            }
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

            #region
            /*string str;
            bool b = false;
            int count = File.ReadAllLines("Info.txt").Length;
            string[] password = new string[count];

            FileStream file = new FileStream("Info.txt", FileMode.Open);
            StreamReader fnew = new StreamReader(file);
            for (int t = 0, i = 0, j = 0; t < count; t++, i = 0, j = 0)
            {
                str = fnew.ReadLine();
                while (b == false)
                {
                    if ((str[i] == ' ') && (b == false))
                    {
                        if (str[i + 1] == ' ')
                        {
                            b = true;
                        }
                        else
                        {
                            do
                            {
                                i++;
                                j++;
                                b = true;
                            }
                            while (str[i + 1] != ' ');
                        }
                    }
                    i++;
                }
                password[t] = str.Substring(i - j, j);

                b = false;
            }
            fnew.Close();*/
            #endregion
            int n = num_in_doc;
            pas_from_db = LoginForm.Users[n].password;
            
        }

        
        public ChangePasswordForm(USER fUser, int n)
        {
            User = fUser;
            
            num_in_doc = n;

            InitializeComponent();
        }

    }
}
