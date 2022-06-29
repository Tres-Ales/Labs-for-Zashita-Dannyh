using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMZI_lr3
{
    public partial class Form1 : Form
    {
        string DefaultHeader = "Лабораторная работа 3";

        public Form1()
        {
            InitializeComponent();
            SetTitle(DefaultHeader, false);
        }

        public void SetTitle(string header, bool b)
        {
            Text = header;
            docContent.Text = "";
            docContent.Enabled = b;
            LoadFile.Enabled = SaveFile.Enabled =
                создатьToolStripMenuItem.Enabled = загрузитьToolStripMenuItem.Enabled =
                сохранитьToolStripMenuItem.Enabled = удалитьToolStripMenuItem.Enabled = b;
        }

        public void SelectCertLogic()
        {
            SetTitle(DefaultHeader, false);
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.IncludeArchived | OpenFlags.ReadOnly);
            X509Certificate2Collection selected = X509Certificate2UI.SelectFromCollection(store.Certificates,
                "Выбор сертификата", "Выберите сертификат:", X509SelectionFlag.SingleSelection);
            if (selected.Count < 1)
            {
                username.Text = "";
                return;
            }
            CryptoService.currentCertificate = selected[0];
            store.Close();

            try
            {
                CryptoService.currentDSA = (DSACryptoServiceProvider)CryptoService.currentCertificate.PrivateKey;
                if (CryptoService.currentDSA == null)
                {
                    MessageBox.Show("Сертификат не подходит для данной программы", "Ошибка", MessageBoxButtons.OK);
                    username.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сертификат не подходит для данной программы", "Ошибка", MessageBoxButtons.OK);
                username.Text = "";
                return;
            }

            username.Text = CryptoService.currentCertificate.GetNameInfo(X509NameType.SimpleName, false);
            SetTitle(DefaultHeader, true);
        }

        public void LoadFileLogic()
        {
            Stream myStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Подписанный документ|*.sd";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog.OpenFile()) != null)
                {
                    try
                    {
                        CryptoService.LoadDocument(myStream, this);
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                        string textForMB = "";
                        if (message.Equals("docwrong"))
                        {
                            textForMB = "Документ повреждён";
                        }
                        else if (message.Equals("certwrong") || message.Equals("certnotvalid"))
                        {
                            textForMB = "Проверка не подтвердила подлинность сертификата автора документа";
                        }
                        else if (message.Equals("signaturewrong"))
                        {
                            textForMB = "Подпись не подтверждена";
                        }
                        else
                        {
                            textForMB = message;
                        }

                        MessageBox.Show(textForMB, "Ошибка", MessageBoxButtons.OK);
                        myStream.Close();
                        return;
                    }

                    myStream.Close();
                }
            }
        }

        public void SaveFileLogic()
        {
            if (CryptoService.currentCertificate == null)
            {
                MessageBox.Show("Сертификат не выбран!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Подписанный документ|*.sd";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    CryptoService.SaveDocument(myStream, Encoding.Default.GetBytes(docContent.Text));
                    Text = "Подписанный документ " + username.Text;
                    myStream.Close();
                }
            }
        }

        public void DeleteCertLogic()
        {
            if (CryptoService.currentCertificate != null)
            {
                try
                {
                    X509Store store = new X509Store();
                    store.Open(OpenFlags.IncludeArchived | OpenFlags.ReadWrite);
                    store.Remove(CryptoService.currentCertificate);
                    store.Close();
                    MessageBox.Show("Сертификат удалён", "Информация", MessageBoxButtons.OK);
                    CryptoService.currentCertificate = null;
                    username.Text = "";
                    SetTitle(DefaultHeader, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сертификат не удалён", "Информация", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Сертификат не выбран!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
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

        private void SelectCert_Click(object sender, EventArgs e)
        {
            SelectCertLogic();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFileLogic();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileLogic();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileLogic();
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            LoadFileLogic();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Подписанный документ";
            docContent.Text = "";
        }

        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectCertLogic();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCertLogic();
        }
    }
}
