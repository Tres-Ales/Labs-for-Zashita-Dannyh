
namespace Lab_work_1_DS
{
    partial class ListOfUsersForm
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
            this.CH_blocked = new System.Windows.Forms.CheckBox();
            this.CH_restricted = new System.Windows.Forms.CheckBox();
            this.prev_but = new System.Windows.Forms.Button();
            this.next_but = new System.Windows.Forms.Button();
            this.save_but = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.Close_but = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // CH_blocked
            // 
            this.CH_blocked.AutoSize = true;
            this.CH_blocked.Location = new System.Drawing.Point(140, 126);
            this.CH_blocked.Name = "CH_blocked";
            this.CH_blocked.Size = new System.Drawing.Size(75, 17);
            this.CH_blocked.TabIndex = 1;
            this.CH_blocked.Text = "Is blocked";
            this.CH_blocked.UseVisualStyleBackColor = true;
            // 
            // CH_restricted
            // 
            this.CH_restricted.AutoSize = true;
            this.CH_restricted.Location = new System.Drawing.Point(140, 163);
            this.CH_restricted.Name = "CH_restricted";
            this.CH_restricted.Size = new System.Drawing.Size(145, 17);
            this.CH_restricted.TabIndex = 2;
            this.CH_restricted.Text = "Password has restrictions";
            this.CH_restricted.UseVisualStyleBackColor = true;
            // 
            // prev_but
            // 
            this.prev_but.Location = new System.Drawing.Point(22, 67);
            this.prev_but.Name = "prev_but";
            this.prev_but.Size = new System.Drawing.Size(75, 23);
            this.prev_but.TabIndex = 3;
            this.prev_but.Text = "prev";
            this.prev_but.UseVisualStyleBackColor = true;
            this.prev_but.Click += new System.EventHandler(this.prev_but_Click);
            // 
            // next_but
            // 
            this.next_but.Location = new System.Drawing.Point(421, 67);
            this.next_but.Name = "next_but";
            this.next_but.Size = new System.Drawing.Size(75, 23);
            this.next_but.TabIndex = 4;
            this.next_but.Text = "next";
            this.next_but.UseVisualStyleBackColor = true;
            this.next_but.Click += new System.EventHandler(this.next_but_Click);
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(65, 218);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(150, 57);
            this.save_but.TabIndex = 5;
            this.save_but.Text = "Save changes";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(176, 69);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(198, 20);
            this.username.TabIndex = 6;
            // 
            // Close_but
            // 
            this.Close_but.Location = new System.Drawing.Point(367, 248);
            this.Close_but.Name = "Close_but";
            this.Close_but.Size = new System.Drawing.Size(75, 23);
            this.Close_but.TabIndex = 7;
            this.Close_but.Text = "Close";
            this.Close_but.UseVisualStyleBackColor = true;
            this.Close_but.Click += new System.EventHandler(this.Close_but_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 8;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ListOfUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 333);
            this.Controls.Add(this.Close_but);
            this.Controls.Add(this.username);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.next_but);
            this.Controls.Add(this.prev_but);
            this.Controls.Add(this.CH_restricted);
            this.Controls.Add(this.CH_blocked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListOfUsersForm";
            this.Text = "ListOfUsersForm";
            this.Load += new System.EventHandler(this.ListOfUsersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CH_blocked;
        private System.Windows.Forms.CheckBox CH_restricted;
        private System.Windows.Forms.Button prev_but;
        private System.Windows.Forms.Button next_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button Close_but;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}