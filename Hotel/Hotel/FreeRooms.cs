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
    public partial class FreeRooms : Form
    {
        public static int cat;
        public static FreeRooms _fr;
        public static void getForm()
        {
            if (_fr == null || _fr.IsDisposed)
            {
                _fr = new FreeRooms();
                _fr.Show();
            }
            else
            {
                _fr.Activate();
            }
        }
        public FreeRooms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите Категорию номера в текстовое поле!");
            }
            else
            {
                cat = Convert.ToInt32(textBox1.Text);
                this.свободные_сейчас_по_категорииTableAdapter.Fill(this.course_workDataSet.Свободные_сейчас_по_категории, cat);
            }
        }
    }
}
