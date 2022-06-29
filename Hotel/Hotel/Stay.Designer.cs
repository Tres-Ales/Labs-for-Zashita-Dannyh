
namespace Hotel
{
    partial class Stay
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
            this.иДПосещенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иДГостяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иДКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времявъездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времявыездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.договорDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_workDataSet = new Hotel.Course_workDataSet();
            this.посещениеTableAdapter = new Hotel.Course_workDataSetTableAdapters.ПосещениеTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДПосещенияDataGridViewTextBoxColumn,
            this.иДГостяDataGridViewTextBoxColumn,
            this.иДКомнатыDataGridViewTextBoxColumn,
            this.времявъездаDataGridViewTextBoxColumn,
            this.времявыездаDataGridViewTextBoxColumn,
            this.договорDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.посещениеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 148);
            this.dataGridView1.TabIndex = 0;
            // 
            // иДПосещенияDataGridViewTextBoxColumn
            // 
            this.иДПосещенияDataGridViewTextBoxColumn.DataPropertyName = "ИД_Посещения";
            this.иДПосещенияDataGridViewTextBoxColumn.HeaderText = "ИД_Посещения";
            this.иДПосещенияDataGridViewTextBoxColumn.Name = "иДПосещенияDataGridViewTextBoxColumn";
            this.иДПосещенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // иДГостяDataGridViewTextBoxColumn
            // 
            this.иДГостяDataGridViewTextBoxColumn.DataPropertyName = "ИД_Гостя";
            this.иДГостяDataGridViewTextBoxColumn.HeaderText = "ИД_Гостя";
            this.иДГостяDataGridViewTextBoxColumn.Name = "иДГостяDataGridViewTextBoxColumn";
            // 
            // иДКомнатыDataGridViewTextBoxColumn
            // 
            this.иДКомнатыDataGridViewTextBoxColumn.DataPropertyName = "ИД_Комнаты";
            this.иДКомнатыDataGridViewTextBoxColumn.HeaderText = "ИД_Комнаты";
            this.иДКомнатыDataGridViewTextBoxColumn.Name = "иДКомнатыDataGridViewTextBoxColumn";
            // 
            // времявъездаDataGridViewTextBoxColumn
            // 
            this.времявъездаDataGridViewTextBoxColumn.DataPropertyName = "Время_въезда";
            this.времявъездаDataGridViewTextBoxColumn.HeaderText = "Время_въезда";
            this.времявъездаDataGridViewTextBoxColumn.Name = "времявъездаDataGridViewTextBoxColumn";
            // 
            // времявыездаDataGridViewTextBoxColumn
            // 
            this.времявыездаDataGridViewTextBoxColumn.DataPropertyName = "Время_выезда";
            this.времявыездаDataGridViewTextBoxColumn.HeaderText = "Время_выезда";
            this.времявыездаDataGridViewTextBoxColumn.Name = "времявыездаDataGridViewTextBoxColumn";
            // 
            // договорDataGridViewTextBoxColumn
            // 
            this.договорDataGridViewTextBoxColumn.DataPropertyName = "Договор";
            this.договорDataGridViewTextBoxColumn.HeaderText = "Договор";
            this.договорDataGridViewTextBoxColumn.Name = "договорDataGridViewTextBoxColumn";
            // 
            // посещениеBindingSource
            // 
            this.посещениеBindingSource.DataMember = "Посещение";
            this.посещениеBindingSource.DataSource = this.course_workDataSet;
            // 
            // course_workDataSet
            // 
            this.course_workDataSet.DataSetName = "Course_workDataSet";
            this.course_workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // посещениеTableAdapter
            // 
            this.посещениеTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stay";
            this.Text = "Stay";
            this.Load += new System.EventHandler(this.Stay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Course_workDataSet course_workDataSet;
        private System.Windows.Forms.BindingSource посещениеBindingSource;
        private Course_workDataSetTableAdapters.ПосещениеTableAdapter посещениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДПосещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДГостяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времявъездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времявыездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn договорDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}