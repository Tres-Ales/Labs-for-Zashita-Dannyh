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
    public partial class Guest_Services : Form
    {
        public static int idg;
        public static Guest_Services _fr4;
        public static void getForm()
        {
            if (_fr4 == null || _fr4.IsDisposed)
            {
                _fr4 = new Guest_Services();
                _fr4.Show();
            }
            else
            {
                _fr4.Activate();
            }
        }
        public Guest_Services()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_id.Text == "")
            {
                MessageBox.Show("Введите данные в текстовое поле!");
            }
            else
            {
                idg = Convert.ToInt32(_id.Text);
                this.стоимостьИспУслугTableAdapter.Fill(this.course_workDataSet.СтоимостьИспУслуг, idg);
                this.инфГостяTableAdapter.Fill(this.course_workDataSet.ИнфГостя, idg);
            }
        }

        private void инфГостяBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
