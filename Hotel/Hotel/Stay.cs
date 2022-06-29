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
    public partial class Stay : Form
    {
        public static Stay _stays;
        public static void getForm()
        {
            if (_stays == null || _stays.IsDisposed)
            {
                _stays = new Stay();
                _stays.Show();
            }
            else
            {
                _stays.Activate();
            }
        }
        public Stay()
        {
            InitializeComponent();
        }

        private void Stay_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "course_workDataSet.Посещение". При необходимости она может быть перемещена или удалена.
            this.посещениеTableAdapter.Fill(this.course_workDataSet.Посещение);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
    }
}
