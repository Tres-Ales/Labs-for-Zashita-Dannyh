
namespace Hotel
{
    partial class Change
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
            this.изменитьценуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изменить_ценуTableAdapter = new Hotel.Course_workDataSetTableAdapters.Изменить_ценуTableAdapter();
            this.иДКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иДЗданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоместDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изменитьценуBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.изменитьценуBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // course_workDataSet
            // 
            this.course_workDataSet.DataSetName = "Course_workDataSet";
            this.course_workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // изменитьценуBindingSource
            // 
            this.изменитьценуBindingSource.DataMember = "Изменить_цену";
            this.изменитьценуBindingSource.DataSource = this.course_workDataSet;
            // 
            // изменить_ценуTableAdapter
            // 
            this.изменить_ценуTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество мест";
            // 
            // cat
            // 
            this.cat.Location = new System.Drawing.Point(132, 41);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(100, 20);
            this.cat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "На сколько изменить цену";
            // 
            // chg
            // 
            this.chg.Location = new System.Drawing.Point(450, 41);
            this.chg.Name = "chg";
            this.chg.Size = new System.Drawing.Size(100, 20);
            this.chg.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Change";
            this.Text = "Change";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изменитьценуBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДЗданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоместDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource изменитьценуBindingSource;
        private Course_workDataSet course_workDataSet;
        private Course_workDataSetTableAdapters.Изменить_ценуTableAdapter изменить_ценуTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chg;
        private System.Windows.Forms.Button button1;
    }
}