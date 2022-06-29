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
    public partial class ListOfUsersForm : Form
    {
        int index_now = 0;
        int count;

        public ListOfUsersForm()
        {
            InitializeComponent();
        }

        private void Close_but_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListOfUsersForm_Load(object sender, EventArgs e)
        {
            prev_but.Enabled = false;
            

            username.Text = "ADMIN";

            count = LoginForm.Users.Count;

            if (count == 1)
            {
                next_but.Enabled = false;
            }

            /*FileStream file = new FileStream("Info.txt", FileMode.Open);
            StreamReader fnew = new StreamReader(file);

            
            string str = fnew.ReadLine();
            fnew.Close();

            int length_str = str.Length;
            string p_b, p_r;
            p_r = str[length_str - 1].ToString();
            p_b = str[length_str - 3].ToString();

            if (p_b == "1") CH_blocked.Checked = true;
            if (p_r == "1") CH_restricted.Checked = true;*/
            CH_blocked.Checked = LoginForm.Users[0].par_blocked;
            CH_restricted.Checked = LoginForm.Users[0].par_restricted;
        }

        private void next_but_Click(object sender, EventArgs e)
        {
            prev_but.Enabled = true;
            index_now++;

            if (index_now == (count - 1))
            {
                next_but.Enabled = false;
            }

            /*FileStream file = new FileStream("Info.txt", FileMode.Open);
            StreamReader fnew = new StreamReader(file);

            for (int i = 0; i < (index_now); i++)
                fnew.ReadLine();

            string str = fnew.ReadLine();
            fnew.Close();


            int length_str = str.Length;
            string p_b, p_r;

            username.Text = str.Substring(0, str.IndexOf(" "));
            p_r = str[length_str - 1].ToString();
            p_b = str[length_str - 3].ToString();
            */
            USER User = LoginForm.Users[index_now];
            username.Text = User.username;
            if (User.par_blocked) CH_blocked.Checked = true;
            else CH_blocked.Checked = false;
            if (User.par_restricted) CH_restricted.Checked = true;
            else CH_restricted.Checked = false;
        }

        private void prev_but_Click(object sender, EventArgs e)
        {
            next_but.Enabled = true;
            index_now--;

            if (index_now == 0)
            {
                prev_but.Enabled = false;
            }

            /*FileStream file = new FileStream("Info.txt", FileMode.Open);
            StreamReader fnew = new StreamReader(file);

            if (index_now != 0)
            {
                for (int i = 0; i < (index_now); i++)
                    fnew.ReadLine();
            }

            string str = fnew.ReadLine();
            fnew.Close();


            int length_str = str.Length;
            string p_b, p_r;

            username.Text = str.Substring(0, str.IndexOf(" "));
            p_r = str[length_str - 1].ToString();
            p_b = str[length_str - 3].ToString();

            if (p_b == "1") CH_blocked.Checked = true;
            else CH_blocked.Checked = false;
            if (p_r == "1") CH_restricted.Checked = true;
            else CH_restricted.Checked = false;*/

            USER User = LoginForm.Users[index_now];
            username.Text = User.username;
            if (User.par_blocked) CH_blocked.Checked = true;
            else CH_blocked.Checked = false;
            if (User.par_restricted) CH_restricted.Checked = true;
            else CH_restricted.Checked = false;
        }

        private void save_but_Click(object sender, EventArgs e)
        {
            string[] str = new string[count];
            string p_b = "0", p_r = "0";

            /*FileStream file = new FileStream("Info.txt", FileMode.Open);
            StreamReader fnew = new StreamReader(file);

            for (int i = 0; i < count; i++)
                str[i] = fnew.ReadLine();
            fnew.Close();

            FileStream file2 = new FileStream("Info.txt", FileMode.Create);
            StreamWriter fnew2 = new StreamWriter(file2);
            for (int i = 0; i < count; i++)
            {
                if (i != index_now)
                    fnew2.WriteLine(str[i]);
                else
                {
                    string new_str = str[i].Substring(0, str[i].Length - 3);
                    if (CH_blocked.Checked == true) p_b = "1";
                    if (CH_restricted.Checked == true) p_r = "1";
                    new_str = new_str + p_b + " " + p_r;
                    fnew2.WriteLine(new_str);
                }
                    
            }
            fnew2.Close();*/
            USER User = LoginForm.Users[index_now];
            User.par_blocked = CH_blocked.Checked;
            User.par_restricted = CH_restricted.Checked;

            if (File.Exists(FileEncryption.encFile)) { File.Delete(FileEncryption.encFile); }
            FileEncryption.CreateEncrypFile();

            MessageBox.Show(" Изменения сохранены ");

        }

       
    }
}
