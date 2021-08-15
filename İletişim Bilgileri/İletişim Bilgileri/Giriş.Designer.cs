namespace İletişim_Bilgileri
{
    partial class Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKAd = new System.Windows.Forms.TextBox();
            this.TxtŞifre = new System.Windows.Forms.TextBox();
            this.BtnGiriş = new System.Windows.Forms.Button();
            this.BtnKayıt = new System.Windows.Forms.Button();
            this.BtnÇıkış = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adınız :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifreniz :";
            // 
            // TxtKAd
            // 
            this.TxtKAd.Location = new System.Drawing.Point(194, 99);
            this.TxtKAd.Name = "TxtKAd";
            this.TxtKAd.Size = new System.Drawing.Size(151, 32);
            this.TxtKAd.TabIndex = 2;
            // 
            // TxtŞifre
            // 
            this.TxtŞifre.Location = new System.Drawing.Point(194, 147);
            this.TxtŞifre.Name = "TxtŞifre";
            this.TxtŞifre.Size = new System.Drawing.Size(151, 32);
            this.TxtŞifre.TabIndex = 3;
            this.TxtŞifre.UseSystemPasswordChar = true;
            // 
            // BtnGiriş
            // 
            this.BtnGiriş.Location = new System.Drawing.Point(42, 195);
            this.BtnGiriş.Name = "BtnGiriş";
            this.BtnGiriş.Size = new System.Drawing.Size(108, 55);
            this.BtnGiriş.TabIndex = 4;
            this.BtnGiriş.Text = "Giriş Yap";
            this.BtnGiriş.UseVisualStyleBackColor = true;
            this.BtnGiriş.Click += new System.EventHandler(this.BtnGiriş_Click);
            // 
            // BtnKayıt
            // 
            this.BtnKayıt.Location = new System.Drawing.Point(156, 195);
            this.BtnKayıt.Name = "BtnKayıt";
            this.BtnKayıt.Size = new System.Drawing.Size(110, 55);
            this.BtnKayıt.TabIndex = 5;
            this.BtnKayıt.Text = "Kaydol";
            this.BtnKayıt.UseVisualStyleBackColor = true;
            this.BtnKayıt.Click += new System.EventHandler(this.BtnKayıt_Click);
            // 
            // BtnÇıkış
            // 
            this.BtnÇıkış.Location = new System.Drawing.Point(272, 195);
            this.BtnÇıkış.Name = "BtnÇıkış";
            this.BtnÇıkış.Size = new System.Drawing.Size(110, 55);
            this.BtnÇıkış.TabIndex = 6;
            this.BtnÇıkış.Text = "Çıkış";
            this.BtnÇıkış.UseVisualStyleBackColor = true;
            this.BtnÇıkış.Click += new System.EventHandler(this.BtnÇıkış_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "İletişim Bilgilerine Giriş";
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(415, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnÇıkış);
            this.Controls.Add(this.BtnKayıt);
            this.Controls.Add(this.BtnGiriş);
            this.Controls.Add(this.TxtŞifre);
            this.Controls.Add(this.TxtKAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKAd;
        private System.Windows.Forms.TextBox TxtŞifre;
        private System.Windows.Forms.Button BtnGiriş;
        private System.Windows.Forms.Button BtnKayıt;
        private System.Windows.Forms.Button BtnÇıkış;
        private System.Windows.Forms.Label label3;
    }
}