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
    public partial class Room : Form
    {
        public static Room _rooms;
        public static void getForm()
        {
            if (_rooms == null || _rooms.IsDisposed)
            {
                _rooms = new Room();
                _rooms.Show();
            }
            else
            {
                _rooms.Activate();
            }
        }
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "course_workDataSet.Комната". При необходимости она может быть перемещена или удалена.
            this.комнатаTableAdapter.Fill(this.course_workDataSet.Комната);

        }
    }
}
