
namespace Hotel
{
    partial class Building
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.course_workDataSet = new Hotel.Course_workDataSet();
            this.courseworkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.корпусBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.корпусTableAdapter = new Hotel.Course_workDataSetTableAdapters.КорпусTableAdapter();
            this.иДЗданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеГостиницыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоэтажейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествозвездDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комнатнаэтажеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.корпусBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДЗданияDataGridViewTextBoxColumn,
            this.названиеГостиницыDataGridViewTextBoxColumn,
            this.количествоэтажейDataGridViewTextBoxColumn,
            this.количествозвездDataGridViewTextBoxColumn,
            this.комнатнаэтажеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.корпусBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // course_workDataSet
            // 
            this.course_workDataSet.DataSetName = "Course_workDataSet";
            this.course_workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseworkDataSetBindingSource
            // 
            this.courseworkDataSetBindingSource.DataSource = this.course_workDataSet;
            this.courseworkDataSetBindingSource.Position = 0;
            // 
            // корпусBindingSource
            // 
            this.корпусBindingSource.DataMember = "Корпус";
            this.корпусBindingSource.DataSource = this.courseworkDataSetBindingSource;
            // 
            // корпусTableAdapter
            // 
            this.корпусTableAdapter.ClearBeforeFill = true;
            // 
            // иДЗданияDataGridViewTextBoxColumn
            // 
            this.иДЗданияDataGridViewTextBoxColumn.DataPropertyName = "ИД_Здания";
            this.иДЗданияDataGridViewTextBoxColumn.HeaderText = "ИД_Здания";
            this.иДЗданияDataGridViewTextBoxColumn.Name = "иДЗданияDataGridViewTextBoxColumn";
            this.иДЗданияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеГостиницыDataGridViewTextBoxColumn
            // 
            this.названиеГостиницыDataGridViewTextBoxColumn.DataPropertyName = "Название_Гостиницы";
            this.названиеГостиницыDataGridViewTextBoxColumn.HeaderText = "Название_Гостиницы";
            this.названиеГостиницыDataGridViewTextBoxColumn.Name = "названиеГостиницыDataGridViewTextBoxColumn";
            // 
            // количествоэтажейDataGridViewTextBoxColumn
            // 
            this.количествоэтажейDataGridViewTextBoxColumn.DataPropertyName = "Количество_этажей";
            this.количествоэтажейDataGridViewTextBoxColumn.HeaderText = "Количество_этажей";
            this.количествоэтажейDataGridViewTextBoxColumn.Name = "количествоэтажейDataGridViewTextBoxColumn";
            this.количествоэтажейDataGridViewTextBoxColumn.Width = 120;
            // 
            // количествозвездDataGridViewTextBoxColumn
            // 
            this.количествозвездDataGridViewTextBoxColumn.DataPropertyName = "Количество_звезд";
            this.количествозвездDataGridViewTextBoxColumn.HeaderText = "Количество_звезд";
            this.количествозвездDataGridViewTextBoxColumn.Name = "количествозвездDataGridViewTextBoxColumn";
            this.количествозвездDataGridViewTextBoxColumn.Width = 120;
            // 
            // комнатнаэтажеDataGridViewTextBoxColumn
            // 
            this.комнатнаэтажеDataGridViewTextBoxColumn.DataPropertyName = "Комнат_на_этаже";
            this.комнатнаэтажеDataGridViewTextBoxColumn.HeaderText = "Комнат_на_этаже";
            this.комнатнаэтажеDataGridViewTextBoxColumn.Name = "комнатнаэтажеDataGridViewTextBoxColumn";
            this.комнатнаэтажеDataGridViewTextBoxColumn.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(252, 211);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 13);
            this.Error.TabIndex = 3;
            // 
            // Building
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 300);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Building";
            this.Text = "Building";
            this.Load += new System.EventHandler(this.Building_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.корпусBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource courseworkDataSetBindingSource;
        private Course_workDataSet course_workDataSet;
        private System.Windows.Forms.BindingSource корпусBindingSource;
        private Course_workDataSetTableAdapters.КорпусTableAdapter корпусTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДЗданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеГостиницыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоэтажейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествозвездDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комнатнаэтажеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Error;
    }
}