
namespace Hotel
{
    partial class Dogov
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
            this.договорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договорTableAdapter = new Hotel.Course_workDataSetTableAdapters.ДоговорTableAdapter();
            this.иДДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.организацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гостиницаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяброниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окончаниевремениDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДДоговораDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn,
            this.организацияDataGridViewTextBoxColumn,
            this.гостиницаDataGridViewTextBoxColumn,
            this.времяброниDataGridViewTextBoxColumn,
            this.окончаниевремениDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.договорBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // course_workDataSet
            // 
            this.course_workDataSet.DataSetName = "Course_workDataSet";
            this.course_workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договорBindingSource
            // 
            this.договорBindingSource.DataMember = "Договор";
            this.договорBindingSource.DataSource = this.course_workDataSet;
            // 
            // договорTableAdapter
            // 
            this.договорTableAdapter.ClearBeforeFill = true;
            // 
            // иДДоговораDataGridViewTextBoxColumn
            // 
            this.иДДоговораDataGridViewTextBoxColumn.DataPropertyName = "ИД_Договора";
            this.иДДоговораDataGridViewTextBoxColumn.HeaderText = "ИД_Договора";
            this.иДДоговораDataGridViewTextBoxColumn.Name = "иДДоговораDataGridViewTextBoxColumn";
            this.иДДоговораDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            // 
            // организацияDataGridViewTextBoxColumn
            // 
            this.организацияDataGridViewTextBoxColumn.DataPropertyName = "Организация";
            this.организацияDataGridViewTextBoxColumn.HeaderText = "Организация";
            this.организацияDataGridViewTextBoxColumn.Name = "организацияDataGridViewTextBoxColumn";
            // 
            // гостиницаDataGridViewTextBoxColumn
            // 
            this.гостиницаDataGridViewTextBoxColumn.DataPropertyName = "Гостиница";
            this.гостиницаDataGridViewTextBoxColumn.HeaderText = "Гостиница";
            this.гостиницаDataGridViewTextBoxColumn.Name = "гостиницаDataGridViewTextBoxColumn";
            // 
            // времяброниDataGridViewTextBoxColumn
            // 
            this.времяброниDataGridViewTextBoxColumn.DataPropertyName = "Время_брони";
            this.времяброниDataGridViewTextBoxColumn.HeaderText = "Время_брони";
            this.времяброниDataGridViewTextBoxColumn.Name = "времяброниDataGridViewTextBoxColumn";
            // 
            // окончаниевремениDataGridViewTextBoxColumn
            // 
            this.окончаниевремениDataGridViewTextBoxColumn.DataPropertyName = "Окончание_времени";
            this.окончаниевремениDataGridViewTextBoxColumn.HeaderText = "Окончание_времени";
            this.окончаниевремениDataGridViewTextBoxColumn.Name = "окончаниевремениDataGridViewTextBoxColumn";
            // 
            // Dogov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 227);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dogov";
            this.Text = "Dogov";
            this.Load += new System.EventHandler(this.Dogov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Course_workDataSet course_workDataSet;
        private System.Windows.Forms.BindingSource договорBindingSource;
        private Course_workDataSetTableAdapters.ДоговорTableAdapter договорTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn организацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гостиницаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяброниDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окончаниевремениDataGridViewTextBoxColumn;
    }
}