
namespace Lab_work_1_DS
{
    partial class ChangePasswordForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.old_pass_text = new System.Windows.Forms.TextBox();
            this.new_pass_text = new System.Windows.Forms.TextBox();
            this.new_pass_text2 = new System.Windows.Forms.TextBox();
            this.Change_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm New Password";
            // 
            // old_pass_text
            // 
            this.old_pass_text.Location = new System.Drawing.Point(217, 48);
            this.old_pass_text.Name = "old_pass_text";
            this.old_pass_text.PasswordChar = '*';
            this.old_pass_text.Size = new System.Drawing.Size(192, 20);
            this.old_pass_text.TabIndex = 3;
            // 
            // new_pass_text
            // 
            this.new_pass_text.Location = new System.Drawing.Point(217, 103);
            this.new_pass_text.Name = "new_pass_text";
            this.new_pass_text.PasswordChar = '*';
            this.new_pass_text.Size = new System.Drawing.Size(192, 20);
            this.new_pass_text.TabIndex = 4;
            // 
            // new_pass_text2
            // 
            this.new_pass_text2.Location = new System.Drawing.Point(217, 174);
            this.new_pass_text2.Name = "new_pass_text2";
            this.new_pass_text2.PasswordChar = '*';
            this.new_pass_text2.Size = new System.Drawing.Size(192, 20);
            this.new_pass_text2.TabIndex = 5;
            // 
            // Change_but
            // 
            this.Change_but.Location = new System.Drawing.Point(171, 258);
            this.Change_but.Name = "Change_but";
            this.Change_but.Size = new System.Drawing.Size(75, 23);
            this.Change_but.TabIndex = 6;
            this.Change_but.Text = "Change Password";
            this.Change_but.UseVisualStyleBackColor = true;
            this.Change_but.Click += new System.EventHandler(this.Change_but_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 340);
            this.Controls.Add(this.Change_but);
            this.Controls.Add(this.new_pass_text2);
            this.Controls.Add(this.new_pass_text);
            this.Controls.Add(this.old_pass_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox old_pass_text;
        private System.Windows.Forms.TextBox new_pass_text;
        private System.Windows.Forms.TextBox new_pass_text2;
        private System.Windows.Forms.Button Change_but;
    }
}