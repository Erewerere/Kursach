namespace Coursach
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.навчанняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пройтиМатеріалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.першаТемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.навчанняToolStripMenuItem,
            this.аккаунтToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(595, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // навчанняToolStripMenuItem
            // 
            this.навчанняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пройтиМатеріалToolStripMenuItem,
            this.тестуванняToolStripMenuItem});
            this.навчанняToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.навчанняToolStripMenuItem.Name = "навчанняToolStripMenuItem";
            this.навчанняToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.навчанняToolStripMenuItem.Text = "Навчання";
            // 
            // пройтиМатеріалToolStripMenuItem
            // 
            this.пройтиМатеріалToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.пройтиМатеріалToolStripMenuItem.Name = "пройтиМатеріалToolStripMenuItem";
            this.пройтиМатеріалToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пройтиМатеріалToolStripMenuItem.Text = "Пройти матеріал";
            this.пройтиМатеріалToolStripMenuItem.Click += new System.EventHandler(this.пройтиМатеріалToolStripMenuItem_Click);
            // 
            // тестуванняToolStripMenuItem
            // 
            this.тестуванняToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.тестуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.першаТемаToolStripMenuItem});
            this.тестуванняToolStripMenuItem.Name = "тестуванняToolStripMenuItem";
            this.тестуванняToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тестуванняToolStripMenuItem.Text = "Тестування";
            this.тестуванняToolStripMenuItem.Click += new System.EventHandler(this.тестуванняToolStripMenuItem_Click);
            // 
            // аккаунтToolStripMenuItem
            // 
            this.аккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem});
            this.аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            this.аккаунтToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.аккаунтToolStripMenuItem.Text = "Аккаунт";
            this.аккаунтToolStripMenuItem.Click += new System.EventHandler(this.аккаунтToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            this.довідкаToolStripMenuItem.Click += new System.EventHandler(this.довідкаToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // першаТемаToolStripMenuItem
            // 
            this.першаТемаToolStripMenuItem.Name = "першаТемаToolStripMenuItem";
            this.першаТемаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.першаТемаToolStripMenuItem.Text = "Перша Тема";
            this.першаТемаToolStripMenuItem.Click += new System.EventHandler(this.першаТемаToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(595, 361);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Тестова Система";
            this.TransparencyKey = System.Drawing.Color.SpringGreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem навчанняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пройтиМатеріалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem першаТемаToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

