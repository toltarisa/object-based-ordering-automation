namespace nypodev
{
    partial class Yetkiligiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yetkiligiris));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textYetkiliAd = new System.Windows.Forms.TextBox();
            this.textYetkiliPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YetkiliGir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(648, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yetkili Ad :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(695, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textYetkiliAd
            // 
            this.textYetkiliAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textYetkiliAd.Location = new System.Drawing.Point(760, 408);
            this.textYetkiliAd.Name = "textYetkiliAd";
            this.textYetkiliAd.Size = new System.Drawing.Size(132, 23);
            this.textYetkiliAd.TabIndex = 2;
            this.textYetkiliAd.TextChanged += new System.EventHandler(this.textYetkiliAd_TextChanged);
            // 
            // textYetkiliPass
            // 
            this.textYetkiliPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textYetkiliPass.Location = new System.Drawing.Point(760, 444);
            this.textYetkiliPass.Name = "textYetkiliPass";
            this.textYetkiliPass.PasswordChar = '*';
            this.textYetkiliPass.Size = new System.Drawing.Size(132, 23);
            this.textYetkiliPass.TabIndex = 4;
            this.textYetkiliPass.TextChanged += new System.EventHandler(this.textYetkiliPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(648, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yetkili Sifre :";
            // 
            // YetkiliGir
            // 
            this.YetkiliGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YetkiliGir.Image = ((System.Drawing.Image)(resources.GetObject("YetkiliGir.Image")));
            this.YetkiliGir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YetkiliGir.Location = new System.Drawing.Point(677, 489);
            this.YetkiliGir.Name = "YetkiliGir";
            this.YetkiliGir.Size = new System.Drawing.Size(157, 56);
            this.YetkiliGir.TabIndex = 5;
            this.YetkiliGir.Text = "           Yetkili Giriş";
            this.YetkiliGir.UseVisualStyleBackColor = true;
            this.YetkiliGir.Click += new System.EventHandler(this.YetkiliGir_Click);
            // 
            // Yetkiligiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.YetkiliGir);
            this.Controls.Add(this.textYetkiliPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textYetkiliAd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Yetkiligiris";
            this.Text = "Yetkiligiris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textYetkiliAd;
        private System.Windows.Forms.TextBox textYetkiliPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button YetkiliGir;
    }
}