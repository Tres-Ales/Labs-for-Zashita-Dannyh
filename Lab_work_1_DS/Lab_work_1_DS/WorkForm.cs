using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_work_1_DS
{
    public partial class WorkForm : Form
    {
        LoginForm par_form;
        
        USER User;
        int num_in_doc;

        public WorkForm(LoginForm pform, USER fUser, int n)
        {
            par_form = pform;
            //username = User.username;
            //param_blocked = p_b;
            //param_restricted = p_r;
            User = fUser;
            num_in_doc = n;

            InitializeComponent();
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            if (User.username != "ADMIN")
            {
                add_user_but.Enabled = false;
                list_users_but.Enabled = false;
            }
        }

        private void WorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            par_form.Visible = true;
            Close();

        }

        private void add_user_but_Click(object sender, EventArgs e)
        {
            AddUserForm f5 = new AddUserForm();
            f5.ShowDialog();
        }

        private void Chng_password_but_Click(object sender, EventArgs e)
        {
            ChangePasswordForm f2 = new ChangePasswordForm(User, num_in_doc);
            f2.ShowDialog();
        }

        private void list_users_but_Click(object sender, EventArgs e)
        {
            ListOfUsersForm f3 = new ListOfUsersForm();
            f3.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            par_form.Visible = true;
            Close();
        }
    }
}
