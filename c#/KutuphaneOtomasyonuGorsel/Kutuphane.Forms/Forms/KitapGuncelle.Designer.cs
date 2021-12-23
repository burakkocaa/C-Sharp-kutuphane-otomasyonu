namespace Kutuphane.Forms
{
    partial class KitapGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapGuncelle));
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_yazar = new System.Windows.Forms.Label();
            this.tb_yazar = new System.Windows.Forms.TextBox();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.tb_tur = new System.Windows.Forms.TextBox();
            this.lbl_sayfa = new System.Windows.Forms.Label();
            this.tb_sayfa = new System.Windows.Forms.TextBox();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.tb_stok = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_guncelle.BackColor = System.Drawing.Color.Firebrick;
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guncelle.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guncelle.Location = new System.Drawing.Point(207, 232);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(66, 34);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_iptal.BackColor = System.Drawing.Color.Firebrick;
            this.btn_iptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iptal.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iptal.Location = new System.Drawing.Point(107, 232);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(66, 34);
            this.btn_iptal.TabIndex = 9;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(127, 20);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(100, 20);
            this.tb_ad.TabIndex = 10;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ad.Location = new System.Drawing.Point(34, 20);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(87, 19);
            this.lbl_ad.TabIndex = 11;
            this.lbl_ad.Text = "Kitap Adı :";
            // 
            // lbl_yazar
            // 
            this.lbl_yazar.AutoSize = true;
            this.lbl_yazar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yazar.Location = new System.Drawing.Point(34, 62);
            this.lbl_yazar.Name = "lbl_yazar";
            this.lbl_yazar.Size = new System.Drawing.Size(90, 19);
            this.lbl_yazar.TabIndex = 13;
            this.lbl_yazar.Text = "Yazar Adı :";
            // 
            // tb_yazar
            // 
            this.tb_yazar.Location = new System.Drawing.Point(127, 62);
            this.tb_yazar.Name = "tb_yazar";
            this.tb_yazar.Size = new System.Drawing.Size(100, 20);
            this.tb_yazar.TabIndex = 12;
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tur.Location = new System.Drawing.Point(25, 103);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(96, 19);
            this.lbl_tur.TabIndex = 15;
            this.lbl_tur.Text = "Kitap Türü :";
            // 
            // tb_tur
            // 
            this.tb_tur.Location = new System.Drawing.Point(127, 104);
            this.tb_tur.Name = "tb_tur";
            this.tb_tur.Size = new System.Drawing.Size(100, 20);
            this.tb_tur.TabIndex = 14;
            // 
            // lbl_sayfa
            // 
            this.lbl_sayfa.AutoSize = true;
            this.lbl_sayfa.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sayfa.Location = new System.Drawing.Point(20, 142);
            this.lbl_sayfa.Name = "lbl_sayfa";
            this.lbl_sayfa.Size = new System.Drawing.Size(101, 19);
            this.lbl_sayfa.TabIndex = 17;
            this.lbl_sayfa.Text = "Sayfa Sayısı :";
            // 
            // tb_sayfa
            // 
            this.tb_sayfa.Location = new System.Drawing.Point(127, 141);
            this.tb_sayfa.Name = "tb_sayfa";
            this.tb_sayfa.Size = new System.Drawing.Size(100, 20);
            this.tb_sayfa.TabIndex = 16;
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stok.Location = new System.Drawing.Point(21, 180);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(103, 19);
            this.lbl_stok.TabIndex = 19;
            this.lbl_stok.Text = "Kitap Adedi :";
            // 
            // tb_stok
            // 
            this.tb_stok.Location = new System.Drawing.Point(127, 179);
            this.tb_stok.Name = "tb_stok";
            this.tb_stok.Size = new System.Drawing.Size(100, 20);
            this.tb_stok.TabIndex = 18;
            // 
            // KitapGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 288);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.tb_stok);
            this.Controls.Add(this.lbl_sayfa);
            this.Controls.Add(this.tb_sayfa);
            this.Controls.Add(this.lbl_tur);
            this.Controls.Add(this.tb_tur);
            this.Controls.Add(this.lbl_yazar);
            this.Controls.Add(this.tb_yazar);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_guncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap Güncelle";
            this.Load += new System.EventHandler(this.KitapGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_yazar;
        private System.Windows.Forms.TextBox tb_yazar;
        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.TextBox tb_tur;
        private System.Windows.Forms.Label lbl_sayfa;
        private System.Windows.Forms.TextBox tb_sayfa;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.TextBox tb_stok;
    }
}