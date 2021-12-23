namespace Kutuphane.Forms
{
    partial class KitapDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapDetay));
            this.lbl_stok = new System.Windows.Forms.Label();
            this.lbl_sayfa = new System.Windows.Forms.Label();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.lbl_yazar = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.panelKitapDetay = new System.Windows.Forms.Panel();
            this.dataGridViewKitapDetay = new System.Windows.Forms.DataGridView();
            this.lbl_stokVal = new System.Windows.Forms.Label();
            this.lbl_sayfaVal = new System.Windows.Forms.Label();
            this.lbl_turVal = new System.Windows.Forms.Label();
            this.lbl_yazarVal = new System.Windows.Forms.Label();
            this.lbl_adVal = new System.Windows.Forms.Label();
            this.panelKitapDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitapDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stok.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stok.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_stok.Location = new System.Drawing.Point(538, 481);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(140, 23);
            this.lbl_stok.TabIndex = 31;
            this.lbl_stok.Text = "Kitap Adedi :";
            // 
            // lbl_sayfa
            // 
            this.lbl_sayfa.AutoSize = true;
            this.lbl_sayfa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sayfa.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayfa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_sayfa.Location = new System.Drawing.Point(871, 419);
            this.lbl_sayfa.Name = "lbl_sayfa";
            this.lbl_sayfa.Size = new System.Drawing.Size(143, 23);
            this.lbl_sayfa.TabIndex = 29;
            this.lbl_sayfa.Text = "Sayfa Sayısı :";
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tur.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tur.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_tur.Location = new System.Drawing.Point(538, 419);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(132, 23);
            this.lbl_tur.TabIndex = 27;
            this.lbl_tur.Text = "Kitap Türü :";
            // 
            // lbl_yazar
            // 
            this.lbl_yazar.AutoSize = true;
            this.lbl_yazar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yazar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazar.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_yazar.Location = new System.Drawing.Point(118, 360);
            this.lbl_yazar.Name = "lbl_yazar";
            this.lbl_yazar.Size = new System.Drawing.Size(64, 18);
            this.lbl_yazar.TabIndex = 25;
            this.lbl_yazar.Text = "Yazar :";
            // 
            // btn_kapat
            // 
            this.btn_kapat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_kapat.BackColor = System.Drawing.Color.Firebrick;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kapat.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kapat.Location = new System.Drawing.Point(1026, 478);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(66, 34);
            this.btn_kapat.TabIndex = 21;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // panelKitapDetay
            // 
            this.panelKitapDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKitapDetay.BackColor = System.Drawing.Color.Transparent;
            this.panelKitapDetay.Controls.Add(this.dataGridViewKitapDetay);
            this.panelKitapDetay.Location = new System.Drawing.Point(489, 26);
            this.panelKitapDetay.Name = "panelKitapDetay";
            this.panelKitapDetay.Size = new System.Drawing.Size(645, 369);
            this.panelKitapDetay.TabIndex = 32;
            // 
            // dataGridViewKitapDetay
            // 
            this.dataGridViewKitapDetay.AllowUserToAddRows = false;
            this.dataGridViewKitapDetay.AllowUserToDeleteRows = false;
            this.dataGridViewKitapDetay.AllowUserToResizeColumns = false;
            this.dataGridViewKitapDetay.AllowUserToResizeRows = false;
            this.dataGridViewKitapDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKitapDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitapDetay.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewKitapDetay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewKitapDetay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKitapDetay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKitapDetay.ColumnHeadersHeight = 50;
            this.dataGridViewKitapDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKitapDetay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKitapDetay.EnableHeadersVisualStyles = false;
            this.dataGridViewKitapDetay.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewKitapDetay.Location = new System.Drawing.Point(29, 19);
            this.dataGridViewKitapDetay.MultiSelect = false;
            this.dataGridViewKitapDetay.Name = "dataGridViewKitapDetay";
            this.dataGridViewKitapDetay.ReadOnly = true;
            this.dataGridViewKitapDetay.RowHeadersVisible = false;
            this.dataGridViewKitapDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitapDetay.ShowCellToolTips = false;
            this.dataGridViewKitapDetay.ShowEditingIcon = false;
            this.dataGridViewKitapDetay.Size = new System.Drawing.Size(587, 324);
            this.dataGridViewKitapDetay.TabIndex = 0;
            this.dataGridViewKitapDetay.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewKitapDetay_ColumnAdded);
            // 
            // lbl_stokVal
            // 
            this.lbl_stokVal.AutoSize = true;
            this.lbl_stokVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stokVal.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stokVal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_stokVal.Location = new System.Drawing.Point(677, 481);
            this.lbl_stokVal.Name = "lbl_stokVal";
            this.lbl_stokVal.Size = new System.Drawing.Size(128, 23);
            this.lbl_stokVal.TabIndex = 37;
            this.lbl_stokVal.Text = "Kitap Adedi";
            // 
            // lbl_sayfaVal
            // 
            this.lbl_sayfaVal.AutoSize = true;
            this.lbl_sayfaVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sayfaVal.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayfaVal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_sayfaVal.Location = new System.Drawing.Point(1011, 419);
            this.lbl_sayfaVal.Name = "lbl_sayfaVal";
            this.lbl_sayfaVal.Size = new System.Drawing.Size(131, 23);
            this.lbl_sayfaVal.TabIndex = 36;
            this.lbl_sayfaVal.Text = "Sayfa Sayısı";
            // 
            // lbl_turVal
            // 
            this.lbl_turVal.AutoSize = true;
            this.lbl_turVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_turVal.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_turVal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_turVal.Location = new System.Drawing.Point(677, 419);
            this.lbl_turVal.Name = "lbl_turVal";
            this.lbl_turVal.Size = new System.Drawing.Size(120, 23);
            this.lbl_turVal.TabIndex = 35;
            this.lbl_turVal.Text = "Kitap Türü";
            // 
            // lbl_yazarVal
            // 
            this.lbl_yazarVal.AutoSize = true;
            this.lbl_yazarVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yazarVal.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazarVal.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_yazarVal.Location = new System.Drawing.Point(177, 360);
            this.lbl_yazarVal.Name = "lbl_yazarVal";
            this.lbl_yazarVal.Size = new System.Drawing.Size(87, 18);
            this.lbl_yazarVal.TabIndex = 34;
            this.lbl_yazarVal.Text = "Yazar Adı";
            // 
            // lbl_adVal
            // 
            this.lbl_adVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adVal.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adVal.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_adVal.Location = new System.Drawing.Point(159, 245);
            this.lbl_adVal.Name = "lbl_adVal";
            this.lbl_adVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_adVal.Size = new System.Drawing.Size(273, 96);
            this.lbl_adVal.TabIndex = 33;
            this.lbl_adVal.Text = "Kitap Adı";
            this.lbl_adVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KitapDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1151, 535);
            this.Controls.Add(this.lbl_stokVal);
            this.Controls.Add(this.lbl_sayfaVal);
            this.Controls.Add(this.lbl_turVal);
            this.Controls.Add(this.lbl_yazarVal);
            this.Controls.Add(this.lbl_adVal);
            this.Controls.Add(this.panelKitapDetay);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.lbl_sayfa);
            this.Controls.Add(this.lbl_tur);
            this.Controls.Add(this.lbl_yazar);
            this.Controls.Add(this.btn_kapat);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KitapDetay";
            this.Load += new System.EventHandler(this.KitapDetay_Load);
            this.panelKitapDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitapDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.Label lbl_sayfa;
        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.Label lbl_yazar;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Panel panelKitapDetay;
        private System.Windows.Forms.DataGridView dataGridViewKitapDetay;
        private System.Windows.Forms.Label lbl_stokVal;
        private System.Windows.Forms.Label lbl_sayfaVal;
        private System.Windows.Forms.Label lbl_turVal;
        private System.Windows.Forms.Label lbl_yazarVal;
        private System.Windows.Forms.Label lbl_adVal;
    }
}