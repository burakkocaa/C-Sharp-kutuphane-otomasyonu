namespace Kutuphane.Forms
{
    partial class Kitaplar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplar));
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.panelKitaplar = new System.Windows.Forms.Panel();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.btn_ogrenciler = new System.Windows.Forms.Button();
            this.btn_islemler = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_grafik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.panelKitaplar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AllowUserToAddRows = false;
            this.dataGridViewKitaplar.AllowUserToDeleteRows = false;
            this.dataGridViewKitaplar.AllowUserToResizeColumns = false;
            this.dataGridViewKitaplar.AllowUserToResizeRows = false;
            this.dataGridViewKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewKitaplar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewKitaplar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKitaplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKitaplar.ColumnHeadersHeight = 50;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKitaplar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKitaplar.EnableHeadersVisualStyles = false;
            this.dataGridViewKitaplar.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKitaplar.MultiSelect = false;
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.ReadOnly = true;
            this.dataGridViewKitaplar.RowHeadersVisible = false;
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.ShowCellToolTips = false;
            this.dataGridViewKitaplar.ShowEditingIcon = false;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(900, 400);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewKitaplar_ColumnAdded);
            // 
            // panelKitaplar
            // 
            this.panelKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKitaplar.Controls.Add(this.dataGridViewKitaplar);
            this.panelKitaplar.Location = new System.Drawing.Point(353, 42);
            this.panelKitaplar.Name = "panelKitaplar";
            this.panelKitaplar.Size = new System.Drawing.Size(900, 400);
            this.panelKitaplar.TabIndex = 1;
            // 
            // btn_kitaplar
            // 
            this.btn_kitaplar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_kitaplar.BackColor = System.Drawing.Color.Maroon;
            this.btn_kitaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kitaplar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kitaplar.ForeColor = System.Drawing.Color.White;
            this.btn_kitaplar.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitaplar.Image")));
            this.btn_kitaplar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kitaplar.Location = new System.Drawing.Point(80, 40);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(152, 73);
            this.btn_kitaplar.TabIndex = 2;
            this.btn_kitaplar.Text = "Kitaplar";
            this.btn_kitaplar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitaplar.UseVisualStyleBackColor = false;
            this.btn_kitaplar.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_kitaplar.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btn_ogrenciler
            // 
            this.btn_ogrenciler.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_ogrenciler.BackColor = System.Drawing.Color.Maroon;
            this.btn_ogrenciler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ogrenciler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ogrenciler.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciler.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciler.Image = ((System.Drawing.Image)(resources.GetObject("btn_ogrenciler.Image")));
            this.btn_ogrenciler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ogrenciler.Location = new System.Drawing.Point(80, 150);
            this.btn_ogrenciler.Name = "btn_ogrenciler";
            this.btn_ogrenciler.Size = new System.Drawing.Size(152, 73);
            this.btn_ogrenciler.TabIndex = 3;
            this.btn_ogrenciler.Text = "Öğrenciler";
            this.btn_ogrenciler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ogrenciler.UseVisualStyleBackColor = false;
            this.btn_ogrenciler.Click += new System.EventHandler(this.btn_ogrenciler_Click);
            this.btn_ogrenciler.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_ogrenciler.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btn_islemler
            // 
            this.btn_islemler.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_islemler.BackColor = System.Drawing.Color.Maroon;
            this.btn_islemler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_islemler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_islemler.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_islemler.ForeColor = System.Drawing.Color.White;
            this.btn_islemler.Image = ((System.Drawing.Image)(resources.GetObject("btn_islemler.Image")));
            this.btn_islemler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_islemler.Location = new System.Drawing.Point(80, 260);
            this.btn_islemler.Name = "btn_islemler";
            this.btn_islemler.Size = new System.Drawing.Size(152, 73);
            this.btn_islemler.TabIndex = 4;
            this.btn_islemler.Text = "İşlemler";
            this.btn_islemler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_islemler.UseVisualStyleBackColor = false;
            this.btn_islemler.Click += new System.EventHandler(this.btn_islemler_Click);
            this.btn_islemler.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_islemler.MouseHover += new System.EventHandler(this.button_mousehover);
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
            this.btn_ekle.Location = new System.Drawing.Point(515, 490);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(66, 34);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
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
            this.btn_guncelle.Location = new System.Drawing.Point(613, 490);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(66, 34);
            this.btn_guncelle.TabIndex = 6;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sil.BackColor = System.Drawing.Color.Firebrick;
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sil.Location = new System.Drawing.Point(707, 490);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(66, 34);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // textBoxArama
            // 
            this.textBoxArama.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxArama.Location = new System.Drawing.Point(1036, 498);
            this.textBoxArama.Name = "textBoxArama";
            this.textBoxArama.Size = new System.Drawing.Size(147, 20);
            this.textBoxArama.TabIndex = 9;
            this.textBoxArama.Text = "Kitap ID veya İsmi Giriniz..";
            this.textBoxArama.Enter += new System.EventHandler(this.textBoxArama_Enter);
            this.textBoxArama.Leave += new System.EventHandler(this.textBoxArama_Leave);
            // 
            // btn_ara
            // 
            this.btn_ara.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ara.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ara.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ara.ForeColor = System.Drawing.Color.White;
            this.btn_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ara.Location = new System.Drawing.Point(1187, 484);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(66, 48);
            this.btn_ara.TabIndex = 10;
            this.btn_ara.Text = "Detaylı Bilgi";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_grafik
            // 
            this.btn_grafik.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_grafik.BackColor = System.Drawing.Color.Maroon;
            this.btn_grafik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grafik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_grafik.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grafik.ForeColor = System.Drawing.Color.White;
            this.btn_grafik.Image = ((System.Drawing.Image)(resources.GetObject("btn_grafik.Image")));
            this.btn_grafik.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_grafik.Location = new System.Drawing.Point(80, 380);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(152, 73);
            this.btn_grafik.TabIndex = 11;
            this.btn_grafik.Text = "Grafik";
            this.btn_grafik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_grafik.UseVisualStyleBackColor = false;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            this.btn_grafik.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_grafik.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // Kitaplar
            // 
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.btn_grafik);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.textBoxArama);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_kitaplar);
            this.Controls.Add(this.btn_ogrenciler);
            this.Controls.Add(this.btn_islemler);
            this.Controls.Add(this.panelKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.panelKitaplar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.Panel panelKitaplar;
        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Button btn_ogrenciler;
        private System.Windows.Forms.Button btn_islemler;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox textBoxArama;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_grafik;
    }
}

