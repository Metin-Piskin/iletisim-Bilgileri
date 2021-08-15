namespace İletişim_Bilgileri
{
    partial class Kaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaydol));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKaydol = new System.Windows.Forms.Button();
            this.TxtKAd = new System.Windows.Forms.TextBox();
            this.TxtŞifre = new System.Windows.Forms.TextBox();
            this.BtnÇıkış = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // BtnKaydol
            // 
            this.BtnKaydol.Location = new System.Drawing.Point(59, 147);
            this.BtnKaydol.Name = "BtnKaydol";
            this.BtnKaydol.Size = new System.Drawing.Size(219, 57);
            this.BtnKaydol.TabIndex = 2;
            this.BtnKaydol.Text = "Kaydol";
            this.BtnKaydol.UseVisualStyleBackColor = true;
            this.BtnKaydol.Click += new System.EventHandler(this.BtnKaydol_Click);
            // 
            // TxtKAd
            // 
            this.TxtKAd.Location = new System.Drawing.Point(157, 61);
            this.TxtKAd.Name = "TxtKAd";
            this.TxtKAd.Size = new System.Drawing.Size(141, 32);
            this.TxtKAd.TabIndex = 3;
            // 
            // TxtŞifre
            // 
            this.TxtŞifre.Location = new System.Drawing.Point(157, 99);
            this.TxtŞifre.Name = "TxtŞifre";
            this.TxtŞifre.Size = new System.Drawing.Size(141, 32);
            this.TxtŞifre.TabIndex = 4;
            this.TxtŞifre.UseSystemPasswordChar = true;
            // 
            // BtnÇıkış
            // 
            this.BtnÇıkış.Location = new System.Drawing.Point(59, 210);
            this.BtnÇıkış.Name = "BtnÇıkış";
            this.BtnÇıkış.Size = new System.Drawing.Size(219, 57);
            this.BtnÇıkış.TabIndex = 5;
            this.BtnÇıkış.Text = "Çıkış";
            this.BtnÇıkış.UseVisualStyleBackColor = true;
            this.BtnÇıkış.Click += new System.EventHandler(this.BtnÇıkış_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(113, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kaydol";
            // 
            // Kaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(325, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnÇıkış);
            this.Controls.Add(this.TxtŞifre);
            this.Controls.Add(this.TxtKAd);
            this.Controls.Add(this.BtnKaydol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Kaydol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaydol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKaydol;
        private System.Windows.Forms.TextBox TxtKAd;
        private System.Windows.Forms.TextBox TxtŞifre;
        private System.Windows.Forms.Button BtnÇıkış;
        private System.Windows.Forms.Label label3;
    }
}