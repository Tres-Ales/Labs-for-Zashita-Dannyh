
namespace Hotel
{
    partial class Service
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
            this.бытовыеуслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бытовые_услугиTableAdapter = new Hotel.Course_workDataSetTableAdapters.Бытовые_услугиTableAdapter();
            this.названиеуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бытовыеуслугиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеуслугиDataGridViewTextBoxColumn,
            this.стоимостьуслугиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.бытовыеуслугиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // course_workDataSet
            // 
            this.course_workDataSet.DataSetName = "Course_workDataSet";
            this.course_workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бытовыеуслугиBindingSource
            // 
            this.бытовыеуслугиBindingSource.DataMember = "Бытовые_услуги";
            this.бытовыеуслугиBindingSource.DataSource = this.course_workDataSet;
            // 
            // бытовые_услугиTableAdapter
            // 
            this.бытовые_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // названиеуслугиDataGridViewTextBoxColumn
            // 
            this.названиеуслугиDataGridViewTextBoxColumn.DataPropertyName = "Название_услуги";
            this.названиеуслугиDataGridViewTextBoxColumn.HeaderText = "Название_услуги";
            this.названиеуслугиDataGridViewTextBoxColumn.Name = "названиеуслугиDataGridViewTextBoxColumn";
            // 
            // стоимостьуслугиDataGridViewTextBoxColumn
            // 
            this.стоимостьуслугиDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_услуги";
            this.стоимостьуслугиDataGridViewTextBoxColumn.HeaderText = "Стоимость_услуги";
            this.стоимостьуслугиDataGridViewTextBoxColumn.Name = "стоимостьуслугиDataGridViewTextBoxColumn";
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 260);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бытовыеуслугиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Course_workDataSet course_workDataSet;
        private System.Windows.Forms.BindingSource бытовыеуслугиBindingSource;
        private Course_workDataSetTableAdapters.Бытовые_услугиTableAdapter бытовые_услугиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеуслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьуслугиDataGridViewTextBoxColumn;
    }
}