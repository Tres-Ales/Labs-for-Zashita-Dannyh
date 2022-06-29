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
    public partial class Service : Form
    {
        public static Service _br2;
        public static void getForm()
        {
            if (_br2 == null || _br2.IsDisposed)
            {
                _br2 = new Service();
                _br2.Show();
            }
            else
            {
                _br2.Activate();
            }
        }
        public Service()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "course_workDataSet.Бытовые_услуги". При необходимости она может быть перемещена или удалена.
            this.бытовые_услугиTableAdapter.Fill(this.course_workDataSet.Бытовые_услуги);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
