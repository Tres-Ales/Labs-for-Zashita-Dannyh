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
    public partial class FreeRooms1 : Form
    {
        public static int corp;

        public static FreeRooms1 _fr1;
        public static void getForm()
        {
            if (_fr1 == null || _fr1.IsDisposed)
            {
                _fr1 = new FreeRooms1();
                _fr1.Show();
            }
            else
            {
                _fr1.Activate();
            }
        }

        public FreeRooms1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите Корпус номера в текстовое поле!");
            }
            else
            {
                corp = Convert.ToInt32(textBox1.Text);
                this.свободные_сейчас_по_корпусуTableAdapter.Fill(this.course_workDataSet.Свободные_сейчас_по_корпусу, corp);
            }
        }
    }
}
