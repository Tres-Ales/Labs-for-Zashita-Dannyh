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
    public partial class Dogov : Form
    {
        public static Dogov _dogs;
        public static void getForm()
        {
            if (_dogs == null || _dogs.IsDisposed)
            {
                _dogs = new Dogov();
                _dogs.Show();
            }
            else
            {
                _dogs.Activate();
            }
        }
        public Dogov()
        {
            InitializeComponent();
        }

        private void Dogov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "course_workDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.course_workDataSet.Договор);

        }
    }
}
