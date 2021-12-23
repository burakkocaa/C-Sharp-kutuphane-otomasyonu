namespace Kutuphane.Forms
{
    partial class OgrenciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciEkle));
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.lbl_okulNo = new System.Windows.Forms.Label();
            this.tb_okulNo = new System.Windows.Forms.TextBox();
            this.lbl_tcNo = new System.Windows.Forms.Label();
            this.tb_tcNo = new System.Windows.Forms.TextBox();
            this.lbl_telNo = new System.Windows.Forms.Label();
            this.tb_telNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ekle.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ekle.Location = new System.Drawing.Point(207, 232);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(66, 34);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
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
            this.lbl_ad.Size = new System.Drawing.Size(44, 19);
            this.lbl_ad.TabIndex = 11;
            this.lbl_ad.Text = "Adı :";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soyad.Location = new System.Drawing.Point(34, 62);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(66, 19);
            this.lbl_soyad.TabIndex = 13;
            this.lbl_soyad.Text = "Soyadı :";
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(127, 62);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(100, 20);
            this.tb_soyad.TabIndex = 12;
            // 
            // lbl_okulNo
            // 
            this.lbl_okulNo.AutoSize = true;
            this.lbl_okulNo.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_okulNo.Location = new System.Drawing.Point(25, 103);
            this.lbl_okulNo.Name = "lbl_okulNo";
            this.lbl_okulNo.Size = new System.Drawing.Size(78, 19);
            this.lbl_okulNo.TabIndex = 15;
            this.lbl_okulNo.Text = "Okul No :";
            // 
            // tb_okulNo
            // 
            this.tb_okulNo.Location = new System.Drawing.Point(127, 104);
            this.tb_okulNo.Name = "tb_okulNo";
            this.tb_okulNo.Size = new System.Drawing.Size(100, 20);
            this.tb_okulNo.TabIndex = 14;
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.AutoSize = true;
            this.lbl_tcNo.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tcNo.Location = new System.Drawing.Point(20, 142);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(67, 19);
            this.lbl_tcNo.TabIndex = 17;
            this.lbl_tcNo.Text = "TC No :";
            // 
            // tb_tcNo
            // 
            this.tb_tcNo.Location = new System.Drawing.Point(127, 141);
            this.tb_tcNo.Name = "tb_tcNo";
            this.tb_tcNo.Size = new System.Drawing.Size(100, 20);
            this.tb_tcNo.TabIndex = 16;
            // 
            // lbl_telNo
            // 
            this.lbl_telNo.AutoSize = true;
            this.lbl_telNo.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telNo.Location = new System.Drawing.Point(21, 180);
            this.lbl_telNo.Name = "lbl_telNo";
            this.lbl_telNo.Size = new System.Drawing.Size(66, 19);
            this.lbl_telNo.TabIndex = 19;
            this.lbl_telNo.Text = "Tel No :";
            // 
            // tb_telNo
            // 
            this.tb_telNo.Location = new System.Drawing.Point(127, 179);
            this.tb_telNo.Name = "tb_telNo";
            this.tb_telNo.Size = new System.Drawing.Size(100, 20);
            this.tb_telNo.TabIndex = 18;
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 288);
            this.Controls.Add(this.lbl_telNo);
            this.Controls.Add(this.tb_telNo);
            this.Controls.Add(this.lbl_tcNo);
            this.Controls.Add(this.tb_tcNo);
            this.Controls.Add(this.lbl_okulNo);
            this.Controls.Add(this.tb_okulNo);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Öğrenci Ekle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.Label lbl_okulNo;
        private System.Windows.Forms.TextBox tb_okulNo;
        private System.Windows.Forms.Label lbl_tcNo;
        private System.Windows.Forms.TextBox tb_tcNo;
        private System.Windows.Forms.Label lbl_telNo;
        private System.Windows.Forms.TextBox tb_telNo;
    }
}