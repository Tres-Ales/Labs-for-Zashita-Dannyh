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
    public partial class Guest : Form
    {
        public static Guest _guests;
        public static void getForm()
        {
            if (_guests == null || _guests.IsDisposed)
            {
                _guests = new Guest();
                _guests.Show();
            }
            else
            {
                _guests.Activate();
            }
        }
        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "course_workDataSet.Гость". При необходимости она может быть перемещена или удалена.
            this.гостьTableAdapter.Fill(this.course_workDataSet.Гость);

        }
    }
}
