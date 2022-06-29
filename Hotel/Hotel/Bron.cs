using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Bron : Form
    {
        public static int IDG, IDR;

        public static int? IDDoc;

        public static string _date1, _date2;

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID_G.Text == "" || ID_R.Text == "" || Date1.Text == "" || Date2.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные в текстовые поля!");
            }
            else
            {
                IDG = Convert.ToInt32(ID_G.Text);
                IDR = Convert.ToInt32(ID_R.Text);
                _date1 = Date1.Text;
                _date2 = Date2.Text;
                if (Dog.Text == "") IDDoc = null;
                else IDDoc = Convert.ToInt32(Dog.Text);

                this.бронировать_номерTableAdapter.Fill(this.course_workDataSet.Бронировать_номер, IDG, IDR, _date1, _date2, IDDoc);
            }
        }

        public static Bron _br;
        public static void getForm()
        {
            if (_br == null || _br.IsDisposed)
            {
                _br = new Bron();
                _br.Show();
            }
            else
            {
                _br.Activate();
            }
        }
        public Bron()
        {
            InitializeComponent();
        }
    }
}
