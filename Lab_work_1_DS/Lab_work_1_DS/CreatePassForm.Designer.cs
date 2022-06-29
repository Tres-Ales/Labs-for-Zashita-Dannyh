
namespace Lab_work_1_DS
{
    partial class CreatePassForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.new_pass_text = new System.Windows.Forms.TextBox();
            this.new_pass_text2 = new System.Windows.Forms.TextBox();
            this.but1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm password";
            // 
            // new_pass_text
            // 
            this.new_pass_text.Location = new System.Drawing.Point(194, 37);
            this.new_pass_text.Name = "new_pass_text";
            this.new_pass_text.PasswordChar = '*';
            this.new_pass_text.Size = new System.Drawing.Size(169, 20);
            this.new_pass_text.TabIndex = 2;
            // 
            // new_pass_text2
            // 
            this.new_pass_text2.Location = new System.Drawing.Point(194, 107);
            this.new_pass_text2.Name = "new_pass_text2";
            this.new_pass_text2.PasswordChar = '*';
            this.new_pass_text2.Size = new System.Drawing.Size(169, 20);
            this.new_pass_text2.TabIndex = 3;
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(162, 171);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(75, 23);
            this.but1.TabIndex = 4;
            this.but1.Text = "OK";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // CreatePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 217);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.new_pass_text2);
            this.Controls.Add(this.new_pass_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreatePassForm";
            this.Text = "CreatePassForm";
            this.Load += new System.EventHandler(this.CreatePassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox new_pass_text;
        private System.Windows.Forms.TextBox new_pass_text2;
        private System.Windows.Forms.Button but1;
    }
}