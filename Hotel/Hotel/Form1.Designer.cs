
namespace Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корпусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.комнатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бытовыеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gjсещенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свободныеСейчасНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКатегорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКорпусуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.забронироватьНомерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦенуНомеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоОИспУслугахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоОПосещенияхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
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
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.корпусыToolStripMenuItem,
            this.комнатыToolStripMenuItem,
            this.бытовыеУслугиToolStripMenuItem,
            this.гостиToolStripMenuItem,
            this.договорыToolStripMenuItem,
            this.организацииToolStripMenuItem,
            this.gjсещенияToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // корпусыToolStripMenuItem
            // 
            this.корпусыToolStripMenuItem.Name = "корпусыToolStripMenuItem";
            this.корпусыToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.корпусыToolStripMenuItem.Text = "Корпусы";
            this.корпусыToolStripMenuItem.Click += new System.EventHandler(this.корпусыToolStripMenuItem_Click);
            // 
            // комнатыToolStripMenuItem
            // 
            this.комнатыToolStripMenuItem.Name = "комнатыToolStripMenuItem";
            this.комнатыToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.комнатыToolStripMenuItem.Text = "Комнаты";
            this.комнатыToolStripMenuItem.Click += new System.EventHandler(this.комнатыToolStripMenuItem_Click);
            // 
            // бытовыеУслугиToolStripMenuItem
            // 
            this.бытовыеУслугиToolStripMenuItem.Name = "бытовыеУслугиToolStripMenuItem";
            this.бытовыеУслугиToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.бытовыеУслугиToolStripMenuItem.Text = "Бытовые услуги";
            this.бытовыеУслугиToolStripMenuItem.Click += new System.EventHandler(this.бытовыеУслугиToolStripMenuItem_Click);
            // 
            // гостиToolStripMenuItem
            // 
            this.гостиToolStripMenuItem.Name = "гостиToolStripMenuItem";
            this.гостиToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.гостиToolStripMenuItem.Text = "Гости";
            this.гостиToolStripMenuItem.Click += new System.EventHandler(this.гостиToolStripMenuItem_Click);
            // 
            // договорыToolStripMenuItem
            // 
            this.договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            this.договорыToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.договорыToolStripMenuItem.Text = "Договоры";
            this.договорыToolStripMenuItem.Click += new System.EventHandler(this.договорыToolStripMenuItem_Click);
            // 
            // организацииToolStripMenuItem
            // 
            this.организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            this.организацииToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.организацииToolStripMenuItem.Text = "Организации";
            this.организацииToolStripMenuItem.Click += new System.EventHandler(this.организацииToolStripMenuItem_Click);
            // 
            // gjсещенияToolStripMenuItem
            // 
            this.gjсещенияToolStripMenuItem.Name = "gjсещенияToolStripMenuItem";
            this.gjсещенияToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gjсещенияToolStripMenuItem.Text = "Посещения";
            this.gjсещенияToolStripMenuItem.Click += new System.EventHandler(this.gjсещенияToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свободныеСейчасНомераToolStripMenuItem,
            this.забронироватьНомерToolStripMenuItem,
            this.изменитьЦенуНомеровToolStripMenuItem,
            this.инфоОИспУслугахToolStripMenuItem,
            this.инфоОПосещенияхToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // свободныеСейчасНомераToolStripMenuItem
            // 
            this.свободныеСейчасНомераToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поКатегорииToolStripMenuItem,
            this.поКорпусуToolStripMenuItem});
            this.свободныеСейчасНомераToolStripMenuItem.Name = "свободныеСейчасНомераToolStripMenuItem";
            this.свободныеСейчасНомераToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.свободныеСейчасНомераToolStripMenuItem.Text = "Свободные сейчас номера";
            this.свободныеСейчасНомераToolStripMenuItem.Click += new System.EventHandler(this.свободныеСейчасНомераToolStripMenuItem_Click);
            // 
            // поКатегорииToolStripMenuItem
            // 
            this.поКатегорииToolStripMenuItem.Name = "поКатегорииToolStripMenuItem";
            this.поКатегорииToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.поКатегорииToolStripMenuItem.Text = "по категории";
            this.поКатегорииToolStripMenuItem.Click += new System.EventHandler(this.поКатегорииToolStripMenuItem_Click);
            // 
            // поКорпусуToolStripMenuItem
            // 
            this.поКорпусуToolStripMenuItem.Name = "поКорпусуToolStripMenuItem";
            this.поКорпусуToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.поКорпусуToolStripMenuItem.Text = "по корпусу";
            this.поКорпусуToolStripMenuItem.Click += new System.EventHandler(this.поКорпусуToolStripMenuItem_Click);
            // 
            // забронироватьНомерToolStripMenuItem
            // 
            this.забронироватьНомерToolStripMenuItem.Name = "забронироватьНомерToolStripMenuItem";
            this.забронироватьНомерToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.забронироватьНомерToolStripMenuItem.Text = "Забронировать номер";
            this.забронироватьНомерToolStripMenuItem.Click += new System.EventHandler(this.забронироватьНомерToolStripMenuItem_Click);
            // 
            // изменитьЦенуНомеровToolStripMenuItem
            // 
            this.изменитьЦенуНомеровToolStripMenuItem.Name = "изменитьЦенуНомеровToolStripMenuItem";
            this.изменитьЦенуНомеровToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.изменитьЦенуНомеровToolStripMenuItem.Text = "Изменить цену номеров";
            this.изменитьЦенуНомеровToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦенуНомеровToolStripMenuItem_Click);
            // 
            // инфоОИспУслугахToolStripMenuItem
            // 
            this.инфоОИспУслугахToolStripMenuItem.Name = "инфоОИспУслугахToolStripMenuItem";
            this.инфоОИспУслугахToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.инфоОИспУслугахToolStripMenuItem.Text = "Инфо о исп услугах";
            this.инфоОИспУслугахToolStripMenuItem.Click += new System.EventHandler(this.инфоОИспУслугахToolStripMenuItem_Click);
            // 
            // инфоОПосещенияхToolStripMenuItem
            // 
            this.инфоОПосещенияхToolStripMenuItem.Name = "инфоОПосещенияхToolStripMenuItem";
            this.инфоОПосещенияхToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.инфоОПосещенияхToolStripMenuItem.Text = "Инфо о посещениях";
            this.инфоОПосещенияхToolStripMenuItem.Click += new System.EventHandler(this.инфоОПосещенияхToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 352);
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem корпусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem комнатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бытовыеУслугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem организацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свободныеСейчасНомераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem забронироватьНомерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦенуНомеровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gjсещенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКатегорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКорпусуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфоОИспУслугахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфоОПосещенияхToolStripMenuItem;
    }
}

