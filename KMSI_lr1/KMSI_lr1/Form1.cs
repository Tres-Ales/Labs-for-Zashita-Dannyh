using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMSI_lr1
{
    public partial class Form1 : Form
    {
        private Key_class keyContainer;
        private PublicKey publicKey;

        public Form1()
        {
            InitializeComponent();
            keyContainer = new Key_class();
            
            publicKey = new PublicKey();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void создатьMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Текстовое поле будет очищено. Ок?", "Предупреждение", MessageBoxButtons.YesNo)
               == DialogResult.No)
            {
                return;
            }

            this.Text = "Подписанный документ";
            DocumentContent.Text = "";
        }

        private void сохранитьMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocumentLogic();
        }

        private void SelectUserLogic()
        {
            if (String.IsNullOrEmpty(usernameTB.Text))
            {
                MessageBox.Show("Для начала работы введите имя пользователя!", "Ошибка");
                return;
            }

            // Создаем контейнер для ключей
            //если провайдеров еще не существует
            if (!KeysContainer.IsKeyExists(usernameTB.Text))
            {
                KeysContainer.CreateContainersByName(usernameTB.Text);
                KeysContainer.SetCurrentProviders(usernameTB.Text);
            }
            else
            {
                //установить текущие настройки
                KeysContainer.SetCurrentProviders(usernameTB.Text);
            }



            this.Text = "Подписанный документ";

            loadDoc_but.Enabled = true;
            saveDoc_but.Enabled = true;
            DocumentContent.Enabled = true;
            создатьMenuItem.Enabled = true;
            загрузитьMenuItem.Enabled = true;
            сохранитьMenuItem.Enabled = true;
            экспортMenuItem.Enabled = true;
            импортMenuItem.Enabled = true;
            удалениеMenuItem.Enabled = true;
            usernameTB.Enabled = false;

            chooseUser_but.Enabled = false;
            выборЗToolStripMenuItem.Enabled = false;

            changeUser_but.Enabled = true;
        }

        private void SaveDocumentLogic()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Подписанный документ|*.sd";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            
            string fout = saveFileDialog.FileName;

            byte[] name = Encoding.GetEncoding(1251).GetBytes(usernameTB.Text);
            byte[] signature = KeysContainer.SignatureRSA(Encoding.GetEncoding(1251).GetBytes(DocumentContent.Text));

            //byte[] sign = keyContainer.SignDocument(DocumentContent.Text);
           
            using (BinaryWriter writer = new BinaryWriter(File.Open(fout, FileMode.Create)))
            {
                writer.Write(name.Length);
                writer.Write(signature.Length);
                writer.Write(name);
                writer.Write(signature);
                writer.Write(Encoding.GetEncoding(1251).GetBytes(DocumentContent.Text));
            }

        }
     

        private void импортMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Открытый ключ|*.pub";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fin = openFileDialog.FileName;

            string readedName;
            byte[] readedBlob;
            using (BinaryReader reader = new BinaryReader(File.Open(fin, FileMode.Open)))
            {
                int nameLen = reader.ReadInt32();
                int blobLen = reader.ReadInt32();
                readedName = Encoding.GetEncoding(1251).GetString(reader.ReadBytes(nameLen));
                readedBlob = reader.ReadBytes(blobLen);
            }

            if (!Directory.Exists("PK" + Path.DirectorySeparatorChar + usernameTB.Text))
            {
                Directory.CreateDirectory("PK" + Path.DirectorySeparatorChar + usernameTB.Text);
            }

            byte[] signature = KeysContainer.SignatureECDSA(readedBlob);

            using (BinaryWriter writer = new BinaryWriter(File.Open("PK" + Path.DirectorySeparatorChar +
                usernameTB.Text + Path.DirectorySeparatorChar + readedName + ".pub", FileMode.OpenOrCreate)))
            {
                writer.Write(Encoding.GetEncoding(1251).GetBytes(readedName).Length);
                writer.Write(readedBlob.Length);
                writer.Write(Encoding.GetEncoding(1251).GetBytes(readedName));
                writer.Write(readedBlob);
                writer.Write(signature);
            }
        }

        private void удалениеMenuItem_Click(object sender, EventArgs e)
        {
            // Удаление ключей из криптопровайдера
            KeysContainer.DeleteKeys(usernameTB.Text);
            MessageBox.Show("Ключи пользователя " + usernameTB.Text + " удалены", "Сообщение об удалении ключей");
            


            // Выход
            this.Text = "Третьякова, А-13-18, ЛР1, КМЗИ";
            DocumentContent.Text = "";

            loadDoc_but.Enabled = false;
            saveDoc_but.Enabled = false;
            DocumentContent.Enabled = false;
            создатьMenuItem.Enabled = false;
            загрузитьMenuItem.Enabled = false;
            сохранитьMenuItem.Enabled = false;
            экспортMenuItem.Enabled = false;
            импортMenuItem.Enabled = false;
            удалениеMenuItem.Enabled = false;
            usernameTB.Enabled = true;
            usernameTB.Text = "";

            chooseUser_but.Enabled = true;
            выборЗToolStripMenuItem.Enabled = true;

            changeUser_but.Enabled = false;

            usernameTB.Focus();
        }

        private void выборЗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectUserLogic();
        }

        private void экспортMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Открытый ключ|*.pub";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fout = saveFileDialog.FileName;
            

            byte[] name = Encoding.GetEncoding(1251).GetBytes(usernameTB.Text);

            byte[] blob = KeysContainer.ExportPublicKey();

            using (BinaryWriter writer = new BinaryWriter(File.Open(fout, FileMode.Create)))
            {
                writer.Write(name.Length);
                writer.Write(blob.Length);
                writer.Write(name);
                writer.Write(blob);
            }

        }

        private void загрузитьMenuItem_Click(object sender, EventArgs e)
        {
            LoadDocumentLogic();
        }

        private void saveDoc_but_Click(object sender, EventArgs e)
        {
            SaveDocumentLogic();
        }

        private void loadDoc_but_Click(object sender, EventArgs e)
        {
            LoadDocumentLogic();
        }

        private void LoadDocumentLogic()
        {
            // Выбор документа
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Подписанный документ|*.sd";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fin = openFileDialog.FileName;

            // Чтение документа
            string ownerDocumentName;
            byte[] documentSign, documentContent;
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fin, FileMode.Open)))
                {
                    int nameLen = reader.ReadInt32();
                    int signLen = reader.ReadInt32();
                    ownerDocumentName = Encoding.GetEncoding(1251).GetString(reader.ReadBytes(nameLen));
                    documentSign = reader.ReadBytes(signLen);
                    documentContent = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Документ повреждён!", "Ошибка");
                return;
            }

            // Проверяем наличие открытого ключа в хранилище открытых ключей
            if (!File.Exists("PK" + Path.DirectorySeparatorChar + usernameTB.Text + Path.DirectorySeparatorChar + ownerDocumentName + ".pub"))
            {
                MessageBox.Show("Открытый ключ автора документа не найден!", "Ошибка");
                return;
            }

            // Чтение открытого ключа
            string pkName;
            byte[] pkBlob, pkSign;
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(
                    "PK" + Path.DirectorySeparatorChar + usernameTB.Text + Path.DirectorySeparatorChar + ownerDocumentName + ".pub", FileMode.Open)))
                {
                    int nameLen = reader.ReadInt32();
                    int blobLen = reader.ReadInt32();
                    pkName = Encoding.GetEncoding(1251).GetString(reader.ReadBytes(nameLen));
                    pkBlob = reader.ReadBytes(blobLen);
                    pkSign = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Файл с открытым ключом поврежден!", "Ошибка");
                return;
            }

           

            if (!KeysContainer.VerifyDataECDSA(pkName, pkBlob, pkSign))
            {
                MessageBox.Show("Электронная подпись открытого ключа автора документа не подтверждена!", "Ошибка");
                return;
            }

            

            if (!KeysContainer.VerifyDataRSA(documentContent, documentSign))
            {
                MessageBox.Show("Электронная подпись документа не подтверждена!", "Ошибка");
                return;
            }
            // Проверка подписи пользователя под открытым ключом
            

            // Извлечение и проверка подписи автора под документом
            

            // Отображение текста проверенного документа в поле с текстовым редактором на главной форме
            this.DocumentContent.Text = Encoding.GetEncoding(1251).GetString(documentContent);
            Text = $"Подписанный документ: {ownerDocumentName}";
        }


private void chooseUser_but_Click(object sender, EventArgs e)
        {
            SelectUserLogic();
        }

        private void changeUser_but_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы потеряете все несохраненные изменения для текущего пользователя. " +
                "Сменить пользователя?", "Предупреждение", MessageBoxButtons.YesNo)
                == DialogResult.No)
            {
                return;
            }

            this.Text = "Третьякова, А-13-18, ЛР1, КМЗИ";
            DocumentContent.Text = "";

            loadDoc_but.Enabled = false;
            saveDoc_but.Enabled = false;
            DocumentContent.Enabled = false;
            создатьMenuItem.Enabled = false;
            загрузитьMenuItem.Enabled = false;
            сохранитьMenuItem.Enabled = false;
            экспортMenuItem.Enabled = false;
            импортMenuItem.Enabled = false;
            удалениеMenuItem.Enabled = false;
            usernameTB.Enabled = true;
            usernameTB.Text = "";

            chooseUser_but.Enabled = true;
            выборЗToolStripMenuItem.Enabled = true;

            changeUser_but.Enabled = false;

            usernameTB.Focus();
        }
    }
}
