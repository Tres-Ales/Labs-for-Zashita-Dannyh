using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab_work_1_DS
{

    

    public partial class LoginForm : Form
    {
        public Dictionary<string, int> err;

        static public List<USER> Users = new List<USER>();

        public DecryptionPassword parent_form;

        public bool isCorrectRegKey = false; 

        public LoginForm()
        {
            
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            FileEncryption.CreateEncrypFile();
            //FileEncryption.CreateDecFile();
            
            /*if (Users.Count == 0)
            {
                USER Admin = new USER("ADMIN", "", true, false, false);
                Users.Add(Admin);
            }*/

            err = new Dictionary<string, int>();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1;
            ab1 = new AboutBox1();
            ab1.ShowDialog();
        }

        private void login_but_Click(object sender, EventArgs e)
        {
            FileEncryption.CreateDecFile();
            string  log_name, npassword;
            string str;
            bool l = false;
            int count = 0;
            //USER[] User = new USER[count];

            int n = 0;
            //bool first_time = false;

            Users.Clear();
            //FileStream file = new FileStream(FileEncryption.decFile, FileMode.Open);
            count = File.ReadAllLines(FileEncryption.decFile).Length - 1;

            FileStream file = new FileStream(FileEncryption.decFile, FileMode.Open);
            StreamReader fnew = new StreamReader(file);

            for (int t = 0; t < count; t++)
            {
                str = fnew.ReadLine();

                int IND = str.IndexOf(' ');
                
                string username = str.Substring(0, IND-1);
                //Console.WriteLine(username);
                string new_str = str.Substring(str.IndexOf(' ') + 2);
                int new_index = new_str.IndexOf(' ');
                string password = new_str.Substring(0, new_index-1);
                bool par_blocked, par_restricted, first_time;
                
                
                if (new_str.Substring(new_index + 2, 1) == "t") first_time = true;
                else first_time = false;

                if (new_str.Substring(new_index + 6, 1) == "1") par_blocked = true;
                else par_blocked = false;

                if (new_str.Substring(new_index + 10, 1) == "1") par_restricted = true;
                else par_restricted = false;

                USER newUser = new USER(username, password, first_time, par_blocked, par_restricted);

                Users.Add(newUser);
            }
            fnew.Close();
            
            

            log_name = login_text.Text;
            npassword = password_text.Text;

            for (int i = 0; i < count; i++)
            {
                if (Users[i].username == log_name)
                {
                    l = true;
                    n = i;
                }
            }
            if (l == false)
                MessageBox.Show("Неправильное имя пользователя!");
            else
            {
                if (Users[n].par_blocked)
                    MessageBox.Show("Пользователь заблокирован!");
                
                else
                {
                    var from_doc = new PasswordCiphering (Users[n].password, Users[n].username);
                    string desh = from_doc.Decipher(from_doc.password);
                    //Console.WriteLine(desh);
                    if (npassword != desh)
                    {
                        if (!err.ContainsKey(Users[n].username))
                        {
                            err.Add(Users[n].username, 1);
                        }
                        else err[Users[n].username]++;
                            
                        if (err[Users[n].username] < 3)
                            MessageBox.Show(" Неверный пароль!");
                        else if (err[Users[n].username] == 3)
                        {

                            MessageBox.Show("Неверный пароль введен 3 раза! Завершаем программу");
                            Close();
                        }
                    }
                    else
                    {
                        err[Users[n].username] = 0;
                        if (Users[n].first_time == true)
                        {
                            CreatePassForm fc = new CreatePassForm(Users[n], n);
                            fc.ShowDialog();
                        }
                       
                        FileEncryption.DeleteDecrypFile();
                        WorkForm f2 = new WorkForm(this, Users[n], n);
                        login_text.Text = "";
                        password_text.Text = "";
                        this.Visible = false;
                        //Hide();
                        f2.ShowDialog();
                    }
                }
            }
        }

        delegate void LFCloseDelegate(object sender, FormClosingEventArgs e);

        

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileEncryption.DeleteDecrypFile();
           
            Hide();
            parent_form.Show();
            
        }
    }
}
