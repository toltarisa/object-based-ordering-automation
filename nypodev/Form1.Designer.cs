namespace nypodev
{
    partial class Form1
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
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeGerçekleştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.sepetToolStripMenuItem,
            this.ödemeGerçekleştirToolStripMenuItem,
            this.ürünEkleToolStripMenuItem,
            this.ürünSilToolStripMenuItem,
            this.ürünDüzenleToolStripMenuItem,
            this.personelEkleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriGirişiToolStripMenuItem,
            this.personelGirişiToolStripMenuItem,
            this.kaydolToolStripMenuItem});
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.girişToolStripMenuItem.Text = "Giriş";
            // 
            // müşteriGirişiToolStripMenuItem
            // 
            this.müşteriGirişiToolStripMenuItem.Name = "müşteriGirişiToolStripMenuItem";
            this.müşteriGirişiToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.müşteriGirişiToolStripMenuItem.Text = "Müşteri Girişi";
            this.müşteriGirişiToolStripMenuItem.Click += new System.EventHandler(this.müşteriGirişiToolStripMenuItem_Click);
            // 
            // personelGirişiToolStripMenuItem
            // 
            this.personelGirişiToolStripMenuItem.Name = "personelGirişiToolStripMenuItem";
            this.personelGirişiToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.personelGirişiToolStripMenuItem.Text = "Personel Girişi";
            this.personelGirişiToolStripMenuItem.Click += new System.EventHandler(this.personelGirişiToolStripMenuItem_Click);
            // 
            // kaydolToolStripMenuItem
            // 
            this.kaydolToolStripMenuItem.Name = "kaydolToolStripMenuItem";
            this.kaydolToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.kaydolToolStripMenuItem.Text = "Kaydol";
            this.kaydolToolStripMenuItem.Click += new System.EventHandler(this.kaydolToolStripMenuItem_Click);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // sepetToolStripMenuItem
            // 
            this.sepetToolStripMenuItem.Name = "sepetToolStripMenuItem";
            this.sepetToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.sepetToolStripMenuItem.Text = "Sepet";
            this.sepetToolStripMenuItem.Click += new System.EventHandler(this.sepetToolStripMenuItem_Click);
            // 
            // ödemeGerçekleştirToolStripMenuItem
            // 
            this.ödemeGerçekleştirToolStripMenuItem.Name = "ödemeGerçekleştirToolStripMenuItem";
            this.ödemeGerçekleştirToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.ödemeGerçekleştirToolStripMenuItem.Text = "Ödeme Gerçekleştir";
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // ürünSilToolStripMenuItem
            // 
            this.ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem";
            this.ürünSilToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ürünSilToolStripMenuItem.Text = "Ürün Sil";
            this.ürünSilToolStripMenuItem.Click += new System.EventHandler(this.ürünSilToolStripMenuItem_Click);
            // 
            // ürünDüzenleToolStripMenuItem
            // 
            this.ürünDüzenleToolStripMenuItem.Name = "ürünDüzenleToolStripMenuItem";
            this.ürünDüzenleToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.ürünDüzenleToolStripMenuItem.Text = "Ürün Düzenle";
            this.ürünDüzenleToolStripMenuItem.Click += new System.EventHandler(this.ürünDüzenleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Visible = false;
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Visible = false;
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1019, 500);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGirişiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sepetToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ödemeGerçekleştirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ürünSilToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ürünDüzenleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydolToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
    }
}

