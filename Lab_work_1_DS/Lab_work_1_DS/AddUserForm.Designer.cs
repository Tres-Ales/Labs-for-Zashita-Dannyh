
namespace Lab_work_1_DS
{
    partial class AddUserForm
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
            this.username_text = new System.Windows.Forms.TextBox();
            this.CB_blocked = new System.Windows.Forms.CheckBox();
            this.CB_restricted = new System.Windows.Forms.CheckBox();
            this.Add_but = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(128, 50);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(239, 20);
            this.username_text.TabIndex = 1;
            // 
            // CB_blocked
            // 
            this.CB_blocked.AutoSize = true;
            this.CB_blocked.Location = new System.Drawing.Point(128, 96);
            this.CB_blocked.Name = "CB_blocked";
            this.CB_blocked.Size = new System.Drawing.Size(89, 17);
            this.CB_blocked.TabIndex = 2;
            this.CB_blocked.Text = "User blocked";
            this.CB_blocked.UseVisualStyleBackColor = true;
            // 
            // CB_restricted
            // 
            this.CB_restricted.AutoSize = true;
            this.CB_restricted.Location = new System.Drawing.Point(128, 140);
            this.CB_restricted.Name = "CB_restricted";
            this.CB_restricted.Size = new System.Drawing.Size(184, 17);
            this.CB_restricted.TabIndex = 3;
            this.CB_restricted.Text = "User has restrictions for password";
            this.CB_restricted.UseVisualStyleBackColor = true;
            // 
            // Add_but
            // 
            this.Add_but.Location = new System.Drawing.Point(31, 192);
            this.Add_but.Name = "Add_but";
            this.Add_but.Size = new System.Drawing.Size(336, 36);
            this.Add_but.TabIndex = 4;
            this.Add_but.Text = "Create User";
            this.Add_but.UseVisualStyleBackColor = true;
            this.Add_but.Click += new System.EventHandler(this.Add_but_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 275);
            this.Controls.Add(this.Add_but);
            this.Controls.Add(this.CB_restricted);
            this.Controls.Add(this.CB_blocked);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.CheckBox CB_blocked;
        private System.Windows.Forms.CheckBox CB_restricted;
        private System.Windows.Forms.Button Add_but;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}