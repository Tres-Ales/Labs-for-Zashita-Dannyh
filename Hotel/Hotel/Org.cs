using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Org : Form
    {
        public static Org _orgs;
        public static void getForm()
        {
            if (_orgs == null || _orgs.IsDisposed)
            {
                _orgs = new Org();
                _orgs.Show();
            }
            else
            {
                _orgs.Activate();
            }
        }
        public Org()
        {
            InitializeComponent();
        }

        private void Org_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "course_workDataSet.Организация". При необходимости она может быть перемещена или удалена.
            this.организацияTableAdapter.Fill(this.course_workDataSet.Организация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "course_workDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.course_workDataSet.Договор);

        }
    }
}
