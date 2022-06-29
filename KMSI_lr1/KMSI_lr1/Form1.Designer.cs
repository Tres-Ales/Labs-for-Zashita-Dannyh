
namespace KMSI_lr1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеКлючамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.chooseUser_but = new System.Windows.Forms.Button();
            this.changeUser_but = new System.Windows.Forms.Button();
            this.loadDoc_but = new System.Windows.Forms.Button();
            this.saveDoc_but = new System.Windows.Forms.Button();
            this.DocumentContent = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.управлениеКлючамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьMenuItem,
            this.загрузитьMenuItem,
            this.сохранитьMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem,
            this.toolStripSeparator2,
            this.оПрограммеToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьMenuItem
            // 
            this.создатьMenuItem.Enabled = false;
            this.создатьMenuItem.Name = "создатьMenuItem";
            this.создатьMenuItem.Size = new System.Drawing.Size(149, 22);
            this.создатьMenuItem.Text = "Создать";
            this.создатьMenuItem.Click += new System.EventHandler(this.создатьMenuItem_Click);
            // 
            // загрузитьMenuItem
            // 
            this.загрузитьMenuItem.Enabled = false;
            this.загрузитьMenuItem.Name = "загрузитьMenuItem";
            this.загрузитьMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьMenuItem.Text = "Загрузить";
            this.загрузитьMenuItem.Click += new System.EventHandler(this.загрузитьMenuItem_Click);
            // 
            // сохранитьMenuItem
            // 
            this.сохранитьMenuItem.Enabled = false;
            this.сохранитьMenuItem.Name = "сохранитьMenuItem";
            this.сохранитьMenuItem.Size = new System.Drawing.Size(149, 22);
            this.сохранитьMenuItem.Text = "Сохранить";
            this.сохранитьMenuItem.Click += new System.EventHandler(this.сохранитьMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // управлениеКлючамиToolStripMenuItem
            // 
            this.управлениеКлючамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортMenuItem,
            this.импортMenuItem,
            this.удалениеMenuItem,
            this.выборЗToolStripMenuItem});
            this.управлениеКлючамиToolStripMenuItem.Name = "управлениеКлючамиToolStripMenuItem";
            this.управлениеКлючамиToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.управлениеКлючамиToolStripMenuItem.Text = "Управление ключами";
            // 
            // экспортMenuItem
            // 
            this.экспортMenuItem.Enabled = false;
            this.экспортMenuItem.Name = "экспортMenuItem";
            this.экспортMenuItem.Size = new System.Drawing.Size(219, 22);
            this.экспортMenuItem.Text = "Экспорт открытого ключа";
            this.экспортMenuItem.Click += new System.EventHandler(this.экспортMenuItem_Click);
            // 
            // импортMenuItem
            // 
            this.импортMenuItem.Enabled = false;
            this.импортMenuItem.Name = "импортMenuItem";
            this.импортMenuItem.Size = new System.Drawing.Size(219, 22);
            this.импортMenuItem.Text = "Импорт открытого ключа";
            this.импортMenuItem.Click += new System.EventHandler(this.импортMenuItem_Click);
            // 
            // удалениеMenuItem
            // 
            this.удалениеMenuItem.Enabled = false;
            this.удалениеMenuItem.Name = "удалениеMenuItem";
            this.удалениеMenuItem.Size = new System.Drawing.Size(219, 22);
            this.удалениеMenuItem.Text = "Удаление пары ключей";
            this.удалениеMenuItem.Click += new System.EventHandler(this.удалениеMenuItem_Click);
            // 
            // выборЗToolStripMenuItem
            // 
            this.выборЗToolStripMenuItem.Name = "выборЗToolStripMenuItem";
            this.выборЗToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.выборЗToolStripMenuItem.Text = "Выбор закрытого ключа";
            this.выборЗToolStripMenuItem.Click += new System.EventHandler(this.выборЗToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя пользователя:";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(15, 60);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(145, 20);
            this.usernameTB.TabIndex = 2;
            // 
            // chooseUser_but
            // 
            this.chooseUser_but.Location = new System.Drawing.Point(189, 37);
            this.chooseUser_but.Name = "chooseUser_but";
            this.chooseUser_but.Size = new System.Drawing.Size(92, 43);
            this.chooseUser_but.TabIndex = 3;
            this.chooseUser_but.Text = "Выбрать пользователя";
            this.chooseUser_but.UseVisualStyleBackColor = true;
            this.chooseUser_but.Click += new System.EventHandler(this.chooseUser_but_Click);
            // 
            // changeUser_but
            // 
            this.changeUser_but.Enabled = false;
            this.changeUser_but.Location = new System.Drawing.Point(287, 37);
            this.changeUser_but.Name = "changeUser_but";
            this.changeUser_but.Size = new System.Drawing.Size(92, 43);
            this.changeUser_but.TabIndex = 4;
            this.changeUser_but.Text = "Сменить пользователя";
            this.changeUser_but.UseVisualStyleBackColor = true;
            this.changeUser_but.Click += new System.EventHandler(this.changeUser_but_Click);
            // 
            // loadDoc_but
            // 
            this.loadDoc_but.Enabled = false;
            this.loadDoc_but.Location = new System.Drawing.Point(408, 37);
            this.loadDoc_but.Name = "loadDoc_but";
            this.loadDoc_but.Size = new System.Drawing.Size(86, 43);
            this.loadDoc_but.TabIndex = 5;
            this.loadDoc_but.Text = "Загрузить документ";
            this.loadDoc_but.UseVisualStyleBackColor = true;
            this.loadDoc_but.Click += new System.EventHandler(this.loadDoc_but_Click);
            // 
            // saveDoc_but
            // 
            this.saveDoc_but.Enabled = false;
            this.saveDoc_but.Location = new System.Drawing.Point(500, 37);
            this.saveDoc_but.Name = "saveDoc_but";
            this.saveDoc_but.Size = new System.Drawing.Size(92, 43);
            this.saveDoc_but.TabIndex = 6;
            this.saveDoc_but.Text = "Сохранить документ";
            this.saveDoc_but.UseVisualStyleBackColor = true;
            this.saveDoc_but.Click += new System.EventHandler(this.saveDoc_but_Click);
            // 
            // DocumentContent
            // 
            this.DocumentContent.Location = new System.Drawing.Point(16, 101);
            this.DocumentContent.Multiline = true;
            this.DocumentContent.Name = "DocumentContent";
            this.DocumentContent.Size = new System.Drawing.Size(575, 327);
            this.DocumentContent.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 473);
            this.Controls.Add(this.DocumentContent);
            this.Controls.Add(this.saveDoc_but);
            this.Controls.Add(this.loadDoc_but);
            this.Controls.Add(this.changeUser_but);
            this.Controls.Add(this.chooseUser_but);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem управлениеКлючамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборЗToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button chooseUser_but;
        private System.Windows.Forms.Button changeUser_but;
        private System.Windows.Forms.Button loadDoc_but;
        private System.Windows.Forms.Button saveDoc_but;
        private System.Windows.Forms.TextBox DocumentContent;
    }
}

