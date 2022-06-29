
namespace Lab_work_1_DS
{
    partial class WorkForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Chng_password_but = new System.Windows.Forms.Button();
            this.list_users_but = new System.Windows.Forms.Button();
            this.add_user_but = new System.Windows.Forms.Button();
            this.close_but = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Действия:";
            // 
            // Chng_password_but
            // 
            this.Chng_password_but.Location = new System.Drawing.Point(111, 74);
            this.Chng_password_but.Name = "Chng_password_but";
            this.Chng_password_but.Size = new System.Drawing.Size(247, 40);
            this.Chng_password_but.TabIndex = 2;
            this.Chng_password_but.Text = "Сменить пароль";
            this.Chng_password_but.UseVisualStyleBackColor = true;
            this.Chng_password_but.Click += new System.EventHandler(this.Chng_password_but_Click);
            // 
            // list_users_but
            // 
            this.list_users_but.Location = new System.Drawing.Point(114, 136);
            this.list_users_but.Name = "list_users_but";
            this.list_users_but.Size = new System.Drawing.Size(244, 40);
            this.list_users_but.TabIndex = 3;
            this.list_users_but.Text = "Просмотреть список пользователей";
            this.list_users_but.UseVisualStyleBackColor = true;
            this.list_users_but.Click += new System.EventHandler(this.list_users_but_Click);
            // 
            // add_user_but
            // 
            this.add_user_but.Location = new System.Drawing.Point(115, 197);
            this.add_user_but.Name = "add_user_but";
            this.add_user_but.Size = new System.Drawing.Size(243, 40);
            this.add_user_but.TabIndex = 4;
            this.add_user_but.Text = "Добавить пользователя";
            this.add_user_but.UseVisualStyleBackColor = true;
            this.add_user_but.Click += new System.EventHandler(this.add_user_but_Click);
            // 
            // close_but
            // 
            this.close_but.Location = new System.Drawing.Point(116, 262);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(241, 46);
            this.close_but.TabIndex = 5;
            this.close_but.Text = "Закрыть";
            this.close_but.UseVisualStyleBackColor = true;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 355);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.add_user_but);
            this.Controls.Add(this.list_users_but);
            this.Controls.Add(this.Chng_password_but);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkForm";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkForm_FormClosed);
            this.Load += new System.EventHandler(this.WorkForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Chng_password_but;
        private System.Windows.Forms.Button list_users_but;
        private System.Windows.Forms.Button add_user_but;
        private System.Windows.Forms.Button close_but;
    }
}