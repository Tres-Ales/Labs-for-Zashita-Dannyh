
namespace Hotel
{
    partial class Room
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
            this.комнатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комнатаTableAdapter = new Hotel.Course_workDataSetTableAdapters.КомнатаTableAdapter();
            this.иДКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иДЗданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоместDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комнатаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДКомнатыDataGridViewTextBoxColumn,
            this.иДЗданияDataGridViewTextBoxColumn,
            this.количествоместDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.комнатаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 145);
            this.dataGridView1.TabIndex = 0;
            // 
            // course_workDataSet
            // 
            this.course_workDataSet.DataSetName = "Course_workDataSet";
            this.course_workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // комнатаBindingSource
            // 
            this.комнатаBindingSource.DataMember = "Комната";
            this.комнатаBindingSource.DataSource = this.course_workDataSet;
            // 
            // комнатаTableAdapter
            // 
            this.комнатаTableAdapter.ClearBeforeFill = true;
            // 
            // иДКомнатыDataGridViewTextBoxColumn
            // 
            this.иДКомнатыDataGridViewTextBoxColumn.DataPropertyName = "ИД_Комнаты";
            this.иДКомнатыDataGridViewTextBoxColumn.HeaderText = "ИД_Комнаты";
            this.иДКомнатыDataGridViewTextBoxColumn.Name = "иДКомнатыDataGridViewTextBoxColumn";
            // 
            // иДЗданияDataGridViewTextBoxColumn
            // 
            this.иДЗданияDataGridViewTextBoxColumn.DataPropertyName = "ИД_Здания";
            this.иДЗданияDataGridViewTextBoxColumn.HeaderText = "ИД_Здания";
            this.иДЗданияDataGridViewTextBoxColumn.Name = "иДЗданияDataGridViewTextBoxColumn";
            // 
            // количествоместDataGridViewTextBoxColumn
            // 
            this.количествоместDataGridViewTextBoxColumn.DataPropertyName = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn.HeaderText = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn.Name = "количествоместDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 251);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комнатаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Course_workDataSet course_workDataSet;
        private System.Windows.Forms.BindingSource комнатаBindingSource;
        private Course_workDataSetTableAdapters.КомнатаTableAdapter комнатаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДЗданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоместDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}