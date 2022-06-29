
namespace Hotel
{
    partial class Guest_Services
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.course_workDataSet = new Hotel.Course_workDataSet();
            this.стоимостьИспУслугBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стоимостьИспУслугTableAdapter = new Hotel.Course_workDataSetTableAdapters.СтоимостьИспУслугTableAdapter();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иДПосещенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьЗаДопУслугиСоСкидкойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.инфГостяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.инфГостяTableAdapter = new Hotel.Course_workDataSetTableAdapters.ИнфГостяTableAdapter();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоимостьИспУслугBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.инфГостяBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияDataGridViewTextBoxColumn,
            this.иДПосещенияDataGridViewTextBoxColumn,
            this.стоимостьЗаДопУслугиСоСкидкойDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.стоимостьИспУслугBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияDataGridViewTextBoxColumn1,
            this.названиеуслугиDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.инфГостяBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(418, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(288, 295);
            this.dataGridView2.TabIndex = 1;
            // 
            // _id
            // 
            this._id.Location = new System.Drawing.Point(134, 220);
            this._id.Name = "_id";
            this._id.Size = new System.Drawing.Size(100, 20);
            this._id.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вывести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ИД_Комнаты";
            // 
            // course_workDataSet
            // 
            this.course_workDataSet.DataSetName = "Course_workDataSet";
            this.course_workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стоимостьИспУслугBindingSource
            // 
            this.стоимостьИспУслугBindingSource.DataMember = "СтоимостьИспУслуг";
            this.стоимостьИспУслугBindingSource.DataSource = this.course_workDataSet;
            // 
            // стоимостьИспУслугTableAdapter
            // 
            this.стоимостьИспУслугTableAdapter.ClearBeforeFill = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // иДПосещенияDataGridViewTextBoxColumn
            // 
            this.иДПосещенияDataGridViewTextBoxColumn.DataPropertyName = "ИД_Посещения";
            this.иДПосещенияDataGridViewTextBoxColumn.HeaderText = "ИД_Посещения";
            this.иДПосещенияDataGridViewTextBoxColumn.Name = "иДПосещенияDataGridViewTextBoxColumn";
            this.иДПосещенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьЗаДопУслугиСоСкидкойDataGridViewTextBoxColumn
            // 
            this.стоимостьЗаДопУслугиСоСкидкойDataGridViewTextBoxColumn.DataPropertyName = "Стоимость за доп услуги со скидкой";
            this.стоимостьЗаДопУслугиСоСкидкойDataGridViewTextBoxColumn.HeaderText = "Стоимость за доп услуги со скидкой";
            this.стоимостьЗаДопУслугиСоСкидкойDataGridViewTextBoxColumn.Name = "стоимостьЗаДопУслугиСоСкидкойDataGridViewTextBoxColumn";
            this.стоимостьЗаДопУслугиСоСкидкойDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // инфГостяBindingSource
            // 
            this.инфГостяBindingSource.DataMember = "ИнфГостя";
            this.инфГостяBindingSource.DataSource = this.course_workDataSet;
            // 
            // инфГостяTableAdapter
            // 
            this.инфГостяTableAdapter.ClearBeforeFill = true;
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            // 
            // названиеуслугиDataGridViewTextBoxColumn
            // 
            this.названиеуслугиDataGridViewTextBoxColumn.DataPropertyName = "Название_услуги";
            this.названиеуслугиDataGridViewTextBoxColumn.HeaderText = "Название_услуги";
            this.названиеуслугиDataGridViewTextBoxColumn.Name = "названиеуслугиDataGridViewTextBoxColumn";
            // 
            // Guest_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._id);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Guest_Services";
            this.Text = "Guest_Services";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоимостьИспУслугBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.инфГостяBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox _id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДПосещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьЗаДопУслугиСоСкидкойDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource стоимостьИспУслугBindingSource;
        private Course_workDataSet course_workDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеуслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource инфГостяBindingSource;
        private Course_workDataSetTableAdapters.СтоимостьИспУслугTableAdapter стоимостьИспУслугTableAdapter;
        private Course_workDataSetTableAdapters.ИнфГостяTableAdapter инфГостяTableAdapter;
    }
}