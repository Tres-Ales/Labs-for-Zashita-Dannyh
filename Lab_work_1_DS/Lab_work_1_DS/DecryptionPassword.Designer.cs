
namespace Lab_work_1_DS
{
    partial class DecryptionPassword
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
            this.PassFile_Text = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gentium Basic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password for file";
            // 
            // PassFile_Text
            // 
            this.PassFile_Text.Location = new System.Drawing.Point(69, 74);
            this.PassFile_Text.Name = "PassFile_Text";
            this.PassFile_Text.Size = new System.Drawing.Size(243, 20);
            this.PassFile_Text.TabIndex = 1;
            this.PassFile_Text.UseSystemPasswordChar = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(160, 128);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // DecryptionPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 178);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PassFile_Text);
            this.Controls.Add(this.label1);
            this.Name = "DecryptionPassword";
            this.Text = "DecryptionPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DecryptionPassword_FormClosing);
            this.Load += new System.EventHandler(this.DecryptionPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassFile_Text;
        private System.Windows.Forms.Button OK;
    }
}