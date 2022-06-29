
namespace Tretyakova_LR6
{
    partial class MainForm
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
            this.installDir = new System.Windows.Forms.TextBox();
            this.registryKey = new System.Windows.Forms.TextBox();
            this.browseDirBut = new System.Windows.Forms.Button();
            this.installBut = new System.Windows.Forms.Button();
            this.closeBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // installDir
            // 
            this.installDir.Location = new System.Drawing.Point(42, 78);
            this.installDir.Name = "installDir";
            this.installDir.ReadOnly = true;
            this.installDir.Size = new System.Drawing.Size(370, 20);
            this.installDir.TabIndex = 0;
            // 
            // registryKey
            // 
            this.registryKey.Location = new System.Drawing.Point(42, 175);
            this.registryKey.Name = "registryKey";
            this.registryKey.ReadOnly = true;
            this.registryKey.Size = new System.Drawing.Size(308, 20);
            this.registryKey.TabIndex = 1;
            // 
            // browseDirBut
            // 
            this.browseDirBut.Location = new System.Drawing.Point(435, 75);
            this.browseDirBut.Name = "browseDirBut";
            this.browseDirBut.Size = new System.Drawing.Size(75, 23);
            this.browseDirBut.TabIndex = 2;
            this.browseDirBut.Text = "Выбрать";
            this.browseDirBut.UseVisualStyleBackColor = true;
            this.browseDirBut.Click += new System.EventHandler(this.browseDirBut_Click);
            // 
            // installBut
            // 
            this.installBut.Location = new System.Drawing.Point(106, 231);
            this.installBut.Name = "installBut";
            this.installBut.Size = new System.Drawing.Size(75, 23);
            this.installBut.TabIndex = 3;
            this.installBut.Text = "Install";
            this.installBut.UseVisualStyleBackColor = true;
            this.installBut.Click += new System.EventHandler(this.installBut_Click);
            // 
            // closeBut
            // 
            this.closeBut.Location = new System.Drawing.Point(275, 231);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(75, 23);
            this.closeBut.TabIndex = 4;
            this.closeBut.Text = "Close";
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "REGISTRY KEY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ВЫБЕРИТЕ ПАПКУ ДЛЯ УСТАНОВКИ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.installBut);
            this.Controls.Add(this.browseDirBut);
            this.Controls.Add(this.registryKey);
            this.Controls.Add(this.installDir);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox installDir;
        private System.Windows.Forms.TextBox registryKey;
        private System.Windows.Forms.Button browseDirBut;
        private System.Windows.Forms.Button installBut;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

