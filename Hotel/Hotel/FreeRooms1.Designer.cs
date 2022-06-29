
namespace Hotel
{
    partial class FreeRooms1
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
            this.свободныесейчаспокорпусуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.свободные_сейчас_по_корпусуTableAdapter = new Hotel.Course_workDataSetTableAdapters.Свободные_сейчас_по_корпусуTableAdapter();
            this.иДКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоместDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иДЗданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.свободныесейчаспокорпусуBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДКомнатыDataGridViewTextBoxColumn,
            this.количествоместDataGridViewTextBoxColumn,
            this.иДЗданияDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.свободныесейчаспокорпусуBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // course_workDataSet
            // 
            this.course_workDataSet.DataSetName = "Course_workDataSet";
            this.course_workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // свободныесейчаспокорпусуBindingSource
            // 
            this.свободныесейчаспокорпусуBindingSource.DataMember = "Свободные_сейчас_по_корпусу";
            this.свободныесейчаспокорпусуBindingSource.DataSource = this.course_workDataSet;
            // 
            // свободные_сейчас_по_корпусуTableAdapter
            // 
            this.свободные_сейчас_по_корпусуTableAdapter.ClearBeforeFill = true;
            // 
            // иДКомнатыDataGridViewTextBoxColumn
            // 
            this.иДКомнатыDataGridViewTextBoxColumn.DataPropertyName = "ИД_Комнаты";
            this.иДКомнатыDataGridViewTextBoxColumn.HeaderText = "ИД_Комнаты";
            this.иДКомнатыDataGridViewTextBoxColumn.Name = "иДКомнатыDataGridViewTextBoxColumn";
            // 
            // количествоместDataGridViewTextBoxColumn
            // 
            this.количествоместDataGridViewTextBoxColumn.DataPropertyName = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn.HeaderText = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn.Name = "количествоместDataGridViewTextBoxColumn";
            // 
            // иДЗданияDataGridViewTextBoxColumn
            // 
            this.иДЗданияDataGridViewTextBoxColumn.DataPropertyName = "ИД_Здания";
            this.иДЗданияDataGridViewTextBoxColumn.HeaderText = "ИД_Здания";
            this.иДЗданияDataGridViewTextBoxColumn.Name = "иДЗданияDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // FreeRooms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 290);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FreeRooms1";
            this.Text = "FreeRooms1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.свободныесейчаспокорпусуBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоместDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДЗданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource свободныесейчаспокорпусуBindingSource;
        private Course_workDataSet course_workDataSet;
        private Course_workDataSetTableAdapters.Свободные_сейчас_по_корпусуTableAdapter свободные_сейчас_по_корпусуTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}