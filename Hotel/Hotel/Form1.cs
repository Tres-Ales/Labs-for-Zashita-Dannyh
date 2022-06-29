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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void корпусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Building.getForm();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room.getForm();
        }

        private void гостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guest.getForm();
        }

        private void бытовыеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service.getForm();
        }

        private void gjсещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stay.getForm();
        }

        private void договорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dogov.getForm();
        }

        private void организацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Org.getForm();
        }

        private void свободныеСейчасНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поКатегорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FreeRooms.getForm();
        }

        private void поКорпусуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FreeRooms1.getForm();
        }

        private void забронироватьНомерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bron.getForm();
        }

        private void изменитьЦенуНомеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change.getForm();
        }

        private void инфоОИспУслугахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guest_Services.getForm();
        }

        private void инфоОПосещенияхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Count.getForm();
        }
    }
}
