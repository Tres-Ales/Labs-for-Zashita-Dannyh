
namespace Lab_work_1_DS
{
    partial class RegistryKeyForm
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
            this.registryKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registryKey
            // 
            this.registryKey.Location = new System.Drawing.Point(31, 68);
            this.registryKey.Name = "registryKey";
            this.registryKey.Size = new System.Drawing.Size(356, 20);
            this.registryKey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя раздела реестра";
            // 
            // okBut
            // 
            this.okBut.Location = new System.Drawing.Point(316, 180);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(75, 23);
            this.okBut.TabIndex = 2;
            this.okBut.Text = "ОК";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.okBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Требуется ввести полное название, например: \r\nHKEY_CURRENT_USER\\Software\\Ivanov";
            // 
            // RegistryKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registryKey);
            this.Name = "RegistryKeyForm";
            this.Text = "RegistryKey Name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistryKeyForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registryKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.Label label2;
    }
}