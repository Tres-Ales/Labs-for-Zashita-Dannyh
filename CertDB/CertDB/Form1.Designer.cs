
namespace CertDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoadCertificate = new System.Windows.Forms.Button();
            this.DeleteCertificate = new System.Windows.Forms.Button();
            this.GetCertificate = new System.Windows.Forms.Button();
            this.SearchCertificate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.issuerName = new System.Windows.Forms.TextBox();
            this.subjectName = new System.Windows.Forms.TextBox();
            this.SerialNumber = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСертификатВБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСертификатИзБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСертификатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискСертификатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cert_info = new System.Windows.Forms.DataGridViewImageColumn();
            this.certBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certificateDataSet = new CertDB.certificateDataSet();
            this.certTableAdapter = new CertDB.certificateDataSetTableAdapters.certTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadCertificate
            // 
            this.LoadCertificate.Location = new System.Drawing.Point(56, 47);
            this.LoadCertificate.Name = "LoadCertificate";
            this.LoadCertificate.Size = new System.Drawing.Size(199, 39);
            this.LoadCertificate.TabIndex = 0;
            this.LoadCertificate.Text = "Загрузить сертификат в базу данных";
            this.LoadCertificate.UseVisualStyleBackColor = true;
            this.LoadCertificate.Click += new System.EventHandler(this.LoadCertificate_Click);
            // 
            // DeleteCertificate
            // 
            this.DeleteCertificate.Location = new System.Drawing.Point(56, 92);
            this.DeleteCertificate.Name = "DeleteCertificate";
            this.DeleteCertificate.Size = new System.Drawing.Size(199, 39);
            this.DeleteCertificate.TabIndex = 1;
            this.DeleteCertificate.Text = "Удалить сертификат";
            this.DeleteCertificate.UseVisualStyleBackColor = true;
            this.DeleteCertificate.Click += new System.EventHandler(this.DeleteCertificate_Click);
            // 
            // GetCertificate
            // 
            this.GetCertificate.Location = new System.Drawing.Point(56, 137);
            this.GetCertificate.Name = "GetCertificate";
            this.GetCertificate.Size = new System.Drawing.Size(199, 39);
            this.GetCertificate.TabIndex = 2;
            this.GetCertificate.Text = "Просмотреть сертификат";
            this.GetCertificate.UseVisualStyleBackColor = true;
            this.GetCertificate.Click += new System.EventHandler(this.GetCertificate_Click);
            // 
            // SearchCertificate
            // 
            this.SearchCertificate.Location = new System.Drawing.Point(56, 182);
            this.SearchCertificate.Name = "SearchCertificate";
            this.SearchCertificate.Size = new System.Drawing.Size(199, 39);
            this.SearchCertificate.TabIndex = 3;
            this.SearchCertificate.Text = "Поиск сертификата";
            this.SearchCertificate.UseVisualStyleBackColor = true;
            this.SearchCertificate.Click += new System.EventHandler(this.SearchCertificate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя издателя сертификата";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя владельца сертификата";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Серийный номер сертификата";
            // 
            // issuerName
            // 
            this.issuerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issuerName.Location = new System.Drawing.Point(447, 66);
            this.issuerName.Name = "issuerName";
            this.issuerName.Size = new System.Drawing.Size(221, 20);
            this.issuerName.TabIndex = 7;
            // 
            // subjectName
            // 
            this.subjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectName.Location = new System.Drawing.Point(447, 121);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(221, 20);
            this.subjectName.TabIndex = 8;
            // 
            // SerialNumber
            // 
            this.SerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialNumber.Location = new System.Drawing.Point(447, 179);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(221, 20);
            this.SerialNumber.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.программаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьСертификатВБДToolStripMenuItem,
            this.удалитьСертификатИзБДToolStripMenuItem,
            this.просмотретьСертификатыToolStripMenuItem,
            this.поискСертификатаToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // загрузитьСертификатВБДToolStripMenuItem
            // 
            this.загрузитьСертификатВБДToolStripMenuItem.Name = "загрузитьСертификатВБДToolStripMenuItem";
            this.загрузитьСертификатВБДToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.загрузитьСертификатВБДToolStripMenuItem.Text = "Загрузить сертификат в БД";
            this.загрузитьСертификатВБДToolStripMenuItem.Click += new System.EventHandler(this.загрузитьСертификатВБДToolStripMenuItem_Click);
            // 
            // удалитьСертификатИзБДToolStripMenuItem
            // 
            this.удалитьСертификатИзБДToolStripMenuItem.Name = "удалитьСертификатИзБДToolStripMenuItem";
            this.удалитьСертификатИзБДToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.удалитьСертификатИзБДToolStripMenuItem.Text = "Удалить сертификат из БД";
            this.удалитьСертификатИзБДToolStripMenuItem.Click += new System.EventHandler(this.удалитьСертификатИзБДToolStripMenuItem_Click);
            // 
            // просмотретьСертификатыToolStripMenuItem
            // 
            this.просмотретьСертификатыToolStripMenuItem.Name = "просмотретьСертификатыToolStripMenuItem";
            this.просмотретьСертификатыToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.просмотретьСертификатыToolStripMenuItem.Text = "Просмотреть сертификаты";
            this.просмотретьСертификатыToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСертификатыToolStripMenuItem_Click);
            // 
            // поискСертификатаToolStripMenuItem
            // 
            this.поискСертификатаToolStripMenuItem.Name = "поискСертификатаToolStripMenuItem";
            this.поискСертификатаToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.поискСертификатаToolStripMenuItem.Text = "Поиск сертификата";
            this.поискСертификатаToolStripMenuItem.Click += new System.EventHandler(this.поискСертификатаToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.issueDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.serialnumberDataGridViewTextBoxColumn,
            this.startdataDataGridViewTextBoxColumn,
            this.enddataDataGridViewTextBoxColumn,
            this.cert_info});
            this.dataGridView1.DataSource = this.certBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 188);
            this.dataGridView1.TabIndex = 12;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // issueDataGridViewTextBoxColumn
            // 
            this.issueDataGridViewTextBoxColumn.DataPropertyName = "issue";
            this.issueDataGridViewTextBoxColumn.HeaderText = "Issuer";
            this.issueDataGridViewTextBoxColumn.Name = "issueDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // serialnumberDataGridViewTextBoxColumn
            // 
            this.serialnumberDataGridViewTextBoxColumn.DataPropertyName = "serial_number";
            this.serialnumberDataGridViewTextBoxColumn.HeaderText = "Serial number";
            this.serialnumberDataGridViewTextBoxColumn.Name = "serialnumberDataGridViewTextBoxColumn";
            // 
            // startdataDataGridViewTextBoxColumn
            // 
            this.startdataDataGridViewTextBoxColumn.DataPropertyName = "start_data";
            this.startdataDataGridViewTextBoxColumn.HeaderText = "Start data";
            this.startdataDataGridViewTextBoxColumn.Name = "startdataDataGridViewTextBoxColumn";
            // 
            // enddataDataGridViewTextBoxColumn
            // 
            this.enddataDataGridViewTextBoxColumn.DataPropertyName = "end_data";
            this.enddataDataGridViewTextBoxColumn.HeaderText = "End data";
            this.enddataDataGridViewTextBoxColumn.Name = "enddataDataGridViewTextBoxColumn";
            // 
            // cert_info
            // 
            this.cert_info.DataPropertyName = "cert_info";
            this.cert_info.HeaderText = "cert_info";
            this.cert_info.Name = "cert_info";
            this.cert_info.Visible = false;
            // 
            // certBindingSource
            // 
            this.certBindingSource.DataMember = "cert";
            this.certBindingSource.DataSource = this.certificateDataSet;
            // 
            // certificateDataSet
            // 
            this.certificateDataSet.DataSetName = "certificateDataSet";
            this.certificateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // certTableAdapter
            // 
            this.certTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 22);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Как пользоваться функцией Просмотреть";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(261, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "?";
            this.toolTip1.SetToolTip(this.label4, "Выберите в таблице 1 строку с необходимым сертификатом для просмотра (нажав на за" +
        "головок строки). Нажимайте кнопку \'Просмотреть\'");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.subjectName);
            this.Controls.Add(this.issuerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchCertificate);
            this.Controls.Add(this.GetCertificate);
            this.Controls.Add(this.DeleteCertificate);
            this.Controls.Add(this.LoadCertificate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Программа для хранения сертификатов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadCertificate;
        private System.Windows.Forms.Button DeleteCertificate;
        private System.Windows.Forms.Button GetCertificate;
        private System.Windows.Forms.Button SearchCertificate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox issuerName;
        private System.Windows.Forms.TextBox subjectName;
        private System.Windows.Forms.TextBox SerialNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private certificateDataSet certificateDataSet;
        private System.Windows.Forms.BindingSource certBindingSource;
        private certificateDataSetTableAdapters.certTableAdapter certTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьСертификатВБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСертификатИзБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСертификатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискСертификатаToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn cert_info;
    }
}

