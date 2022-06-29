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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_but_Click(object sender, EventArgs e)
        {
            bool existing = false;

            if (username_text.Text == "")
            {
                MessageBox.Show("Имя пользователя не может быть пустым");
                //empty = true;
            }

            else if (username_text.Text.Length < 2)
            {
                MessageBox.Show("Имя пользователя не может меньше 2 символов");
            }
            
            

            else
            {
                char first = username_text.Text[0];
                char second = username_text.Text[1];
                PasswordCiphering pc = new PasswordCiphering();
                if (!pc.Alphabet.Contains(first) || !pc.Alphabet.Contains(second))
                {
                    MessageBox.Show("Недопустимые первые 2 символа имени");
                }

                else
                {
                    int count = LoginForm.Users.Count;
                    for (int i = 0; i<count; i++)
                    {
                        if (LoginForm.Users[i].username == username_text.Text)
                        {
                            existing = true;
                        }
                    }

                    #region
                    /*int count = File.ReadAllLines("Info.txt").Length;

                    FileStream file = new FileStream("Info.txt", FileMode.Open);
                    StreamReader fnew = new StreamReader(file);

                    string[] str_of_usernames = new string[count];

                    for (int i = 0; i < count; i++)
                    {
                        string str = fnew.ReadLine();
                        str_of_usernames[i] = str.Substring(0, str.IndexOf(' '));
                    }

                    for (int i = 0; i < count; i++)
                    {
                        if (str_of_usernames[i] == username_text.Text)
                        {
                            //MessageBox.Show("Пользователь с таким именем уже существует");
                            existing = true;
                        }
                    }
                    fnew.Close();
                    */
                    #endregion

                    if (existing)
                    {
                        MessageBox.Show("Пользователь с таким именем уже существует");
                    }



                    else
                    {
                                          
                        USER newUser = new USER(username_text.Text, "", true, CB_blocked.Checked, CB_restricted.Checked);
                        LoginForm.Users.Add(newUser);
                        if (File.Exists(FileEncryption.encFile)) { File.Delete(FileEncryption.encFile); }
                        FileEncryption.CreateEncrypFile();

                        MessageBox.Show("Пользователь создан");
                        Close();
                    }
                }
            }
            

        }
    }
}
