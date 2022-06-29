using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CertDB
{

    public partial class Form1
    {
        private Process execute;
        private TaskCompletionSource<bool> eventHandled;

        internal static byte[] ReadFile(string fileName)
        {
            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int size = (int)f.Length;
            byte[] data = new byte[size];
            size = f.Read(data, 0, size);
            f.Close();
            return data;
        }

        public void DeleteCert(string issuer, string subject, string serialNum)
        {
            var query = "";
            int x = 0;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\certificate.mdf;Integrated Security=True");
            con.Open();
            try
            {

                query = String.Format("delete from cert where (issue LIKE '%{0}%' AND subject LIKE '%{1}%' AND serial_number LIKE '%{2}%')", issuer, subject, serialNum);
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    x = cmd.ExecuteNonQuery();
                }
                con.Close();


                if (x == 0)
                {
                    MessageBox.Show("Не было найдено элементов по введенной информации");
                }
                else
                {
                    MessageBox.Show("Success");
                    this.certTableAdapter.Fill(this.certificateDataSet.cert);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Произошла ошибка при удалении сертификата");
            }
        }

        public void DeleteCertificateLogic()
        {
            if (issuerName.Text == "" && subjectName.Text == "" && SerialNumber.Text == "")
            {
                MessageBox.Show("Для удаления сертификата нужно заполнить хотя бы одно из полей:\t\t\n-Имя издателя сертификата\t\t\n-Имя владельца сертификат\t\t\n-Серийный номер сертификата");
            }
            else
            {
                DeleteCert(issuerName.Text, subjectName.Text, SerialNumber.Text);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "certificateDataSet.cert". При необходимости она может быть перемещена или удалена.
                
            }

            //this.certTableAdapter.Fill(this.certificateDataSet.cert);
        }

        public void LoadCertificateLogic()
        {
            string filePath = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                openFileDialog.Filter = "CER |*.cer; *.crt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    X509Certificate2 x509 = new X509Certificate2();

                    //Create X509Certificate2 object from .cer file.
                    byte[] rawData = ReadFile(filePath);
                    if (rawData != null)
                    {
                        try
                        {
                            x509.Import(rawData);

                            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\certificate.mdf;Integrated Security=True");
                            con.Open();

                            using (SqlCommand cmd = new SqlCommand("insert into cert values ( @issuer, @subject, @serialNum, @startdate, @enddate, @data)", con))
                            {
                                cmd.Parameters.AddWithValue("@issuer", x509.Issuer);
                                cmd.Parameters.AddWithValue("@subject", x509.Subject);
                                cmd.Parameters.AddWithValue("@serialNum", x509.SerialNumber);
                                cmd.Parameters.AddWithValue("@startdate", x509.NotBefore);
                                cmd.Parameters.AddWithValue("@enddate", x509.NotAfter);
                                cmd.Parameters.AddWithValue("@data", x509.RawData);

                                cmd.ExecuteNonQuery();
                            }
                            

                            con.Close();

                            this.certTableAdapter.Fill(this.certificateDataSet.cert);
                        }
                        catch
                        {
                            MessageBox.Show("Поддерживаемый формат сертификата X.509. Проверьте сертификат");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при чтении файла");
                    }

                }
            }
        }

        public void GetCertificateLogic()
        {
            eventHandled = new TaskCompletionSource<bool>();

            if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) != 1)
            {
                MessageBox.Show("Выберите 1 строку!");
            }
            else
            {
                try
                {
                    string sn = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    using (FileStream fs = File.Create("TEMP.cer"))
                    {
                        byte[] info = (byte[])dataGridView1.SelectedRows[0].Cells[6].Value;

                        fs.Write(info, 0, info.Length);
                    }


                    execute = new Process();
                    execute.StartInfo.FileName = "TEMP.cer";
                    execute.EnableRaisingEvents = true;

                    execute.Exited += new EventHandler(myProcess_Exited);

                    execute.Start();
                }
                catch
                {
                    MessageBox.Show("Возникла ошибка при просмотре сертификата");
                }

            }
        }

        public void SearchCertificateLogic()
        {
            SqlDataAdapter sqlDataAdap;
            int x = 0;
            var query = "";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\certificate.mdf;Integrated Security=True");
            con.Open();

            try
            {
                query = String.Format("SELECT * from cert where (issue LIKE '%{0}%' AND subject LIKE '%{1}%' AND serial_number LIKE '%{2}%')", issuerName.Text, subjectName.Text, SerialNumber.Text);
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    sqlDataAdap = new SqlDataAdapter(cmd);
                }
                con.Close();

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при поиске сертификата");
            }
        }

        // Handle Exited event and display process information.
        private void myProcess_Exited(object sender, System.EventArgs e)
        {

            File.Delete("TEMP.cer");
            eventHandled.TrySetResult(true);
        }
    }
}
