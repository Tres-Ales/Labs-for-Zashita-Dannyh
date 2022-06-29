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
    public partial class Change : Form
    {
        public static int _cat;
        public static decimal _chg;
        public static Change _br1;
        public static void getForm()
        {
            if (_br1 == null || _br1.IsDisposed)
            {
                _br1 = new Change();
                _br1.Show();
            }
            else
            {
                _br1.Activate();
            }
        }
        public Change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cat.Text == "" || chg.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные в текстовые поля!");
            }
            else
            {
                _cat = Convert.ToInt32(cat.Text);
                _chg = Convert.ToDecimal(chg.Text);

                this.изменить_ценуTableAdapter.Fill(this.course_workDataSet.Изменить_цену, _cat, _chg);
            }
        }
    }
}
