
namespace Hotel
{
    partial class Bron
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
            this.ID_G = new System.Windows.Forms.TextBox();
            this.ID_R = new System.Windows.Forms.TextBox();
            this.Date1 = new System.Windows.Forms.TextBox();
            this.Date2 = new System.Windows.Forms.TextBox();
            this.Dog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.course_workDataSet1 = new Hotel.Course_workDataSet();
            this.бронироватьномерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бронировать_номерTableAdapter = new Hotel.Course_workDataSetTableAdapters.Бронировать_номерTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронироватьномерBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_G
            // 
            this.ID_G.Location = new System.Drawing.Point(26, 69);
            this.ID_G.Name = "ID_G";
            this.ID_G.Size = new System.Drawing.Size(100, 20);
            this.ID_G.TabIndex = 0;
            // 
            // ID_R
            // 
            this.ID_R.Location = new System.Drawing.Point(153, 69);
            this.ID_R.Name = "ID_R";
            this.ID_R.Size = new System.Drawing.Size(100, 20);
            this.ID_R.TabIndex = 1;
            // 
            // Date1
            // 
            this.Date1.Location = new System.Drawing.Point(277, 69);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(100, 20);
            this.Date1.TabIndex = 2;
            // 
            // Date2
            // 
            this.Date2.Location = new System.Drawing.Point(409, 69);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(100, 20);
            this.Date2.TabIndex = 3;
            // 
            // Dog
            // 
            this.Dog.Location = new System.Drawing.Point(530, 69);
            this.Dog.Name = "Dog";
            this.Dog.Size = new System.Drawing.Size(100, 20);
            this.Dog.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ИД Гостя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер комнаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата конца";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Договор";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Бронировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.скидкаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.бронироватьномерBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 98);
            this.dataGridView1.TabIndex = 11;
            // 
            // course_workDataSet1
            // 
            this.course_workDataSet1.DataSetName = "Course_workDataSet";
            this.course_workDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бронироватьномерBindingSource
            // 
            this.бронироватьномерBindingSource.DataMember = "Бронировать_номер";
            this.бронироватьномерBindingSource.DataSource = this.course_workDataSet1;
            // 
            // бронировать_номерTableAdapter
            // 
            this.бронировать_номерTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ИД_Посещения";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД_Посещения";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ИД_Гостя";
            this.dataGridViewTextBoxColumn2.HeaderText = "ИД_Гостя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ИД_Комнаты";
            this.dataGridViewTextBoxColumn3.HeaderText = "ИД_Комнаты";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Время_въезда";
            this.dataGridViewTextBoxColumn4.HeaderText = "Время_въезда";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Время_выезда";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время_выезда";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Договор";
            this.dataGridViewTextBoxColumn6.HeaderText = "Договор";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            // 
            // Bron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 296);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dog);
            this.Controls.Add(this.Date2);
            this.Controls.Add(this.Date1);
            this.Controls.Add(this.ID_R);
            this.Controls.Add(this.ID_G);
            this.Name = "Bron";
            this.Text = "Bron";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронироватьномерBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_G;
        private System.Windows.Forms.TextBox ID_R;
        private System.Windows.Forms.TextBox Date1;
        private System.Windows.Forms.TextBox Date2;
        private System.Windows.Forms.TextBox Dog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДПосещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДГостяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времявъездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времявыездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn договорDataGridViewTextBoxColumn;
        private Course_workDataSet course_workDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource бронироватьномерBindingSource;
        private Course_workDataSet course_workDataSet1;
        private Course_workDataSetTableAdapters.Бронировать_номерTableAdapter бронировать_номерTableAdapter;
    }
}