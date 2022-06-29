using System;

using System.Windows.Forms;



namespace CertDB
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void LoadCertificate_Click(object sender, EventArgs e)
        {
            LoadCertificateLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "certificateDataSet.cert". При необходимости она может быть перемещена или удалена.
            this.certTableAdapter.Fill(this.certificateDataSet.cert);
        }

        private void DeleteCertificate_Click(object sender, EventArgs e)
        {
            DeleteCertificateLogic();
        }

        private void GetCertificate_Click(object sender, EventArgs e)
        {
            GetCertificateLogic();
        }

        private void SearchCertificate_Click(object sender, EventArgs e)
        {
            SearchCertificateLogic();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            ab1.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // сброс таблицы
        private void button1_Click(object sender, EventArgs e)
        {
            this.certTableAdapter.Fill(this.certificateDataSet.cert);
            dataGridView1.DataSource = this.certificateDataSet.cert;
            
        }

        private void удалитьСертификатИзБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCertificateLogic();
        }

        private void загрузитьСертификатВБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCertificateLogic();
        }

        private void просмотретьСертификатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCertificateLogic();
        }

        private void поискСертификатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCertificateLogic();
        }
    }
}
