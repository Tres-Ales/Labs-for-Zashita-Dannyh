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
    public partial class Count : Form
    {
        public static int idg;
        public static Count _fr3;
        public static void getForm()
        {
            if (_fr3 == null || _fr3.IsDisposed)
            {
                _fr3 = new Count();
                _fr3.Show();
            }
            else
            {
                _fr3.Activate();
            }
        }
        public Count()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите Гостя в текстовое поле!");
            }
            else
            {
                idg = Convert.ToInt32(textBox1.Text);
                this.сколькоРазTableAdapter2.Fill(this.course_workDataSet2.СколькоРаз, idg);
                this.гдеСколькоTableAdapter2.Fill(this.course_workDataSet2.ГдеСколько, idg);
            }
        }

        private void гдеСколькоBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
