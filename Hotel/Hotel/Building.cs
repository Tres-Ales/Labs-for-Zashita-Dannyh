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
    public partial class Building : Form
    {
        public static Building _buildings;
        public static void getForm()
        {
            if (_buildings == null || _buildings.IsDisposed)
            {
                _buildings = new Building();
                _buildings.Show();
            }
            else
            {
                _buildings.Activate();
            }
        }
        public Building()
        {
            InitializeComponent();
        }

        private void Building_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "course_workDataSet.Корпус". При необходимости она может быть перемещена или удалена.
            this.корпусTableAdapter.Fill(this.course_workDataSet.Корпус);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error.Text = "";
            try
            {
                //this.программное_обеспечениеTableAdapter.Update(this.kurs_ProjectDataSet_licenses);
                this.корпусTableAdapter.Update(this.course_workDataSet);
            }
            catch (Exception exc)
            {
                Error.Text = exc.Message;
            }
            //this.программное_обеспечениеTableAdapter.Fill(this.kurs_ProjectDataSet_licenses.Программное_обеспечение);
            this.корпусTableAdapter.Fill(this.course_workDataSet.Корпус);
        }
    }
}
