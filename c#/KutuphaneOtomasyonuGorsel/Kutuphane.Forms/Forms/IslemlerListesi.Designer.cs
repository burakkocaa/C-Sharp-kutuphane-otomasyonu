namespace Kutuphane.Forms
{
    partial class IslemlerListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemlerListesi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.btn_ogrenciler = new System.Windows.Forms.Button();
            this.btn_islemler = new System.Windows.Forms.Button();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.dataGridViewIslemler = new System.Windows.Forms.DataGridView();
            this.btn_grafik = new System.Windows.Forms.Button();
            this.panelIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemler)).BeginInit();
            this.SuspendLayout();
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
            this.btn_kitaplar.TabIndex = 6;
            this.btn_kitaplar.Text = "Kitaplar";
            this.btn_kitaplar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitaplar.UseVisualStyleBackColor = false;
            this.btn_kitaplar.Click += new System.EventHandler(this.btn_kitaplar_Click);
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
            this.btn_ogrenciler.TabIndex = 7;
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
            this.btn_islemler.TabIndex = 8;
            this.btn_islemler.Text = "İşlemler";
            this.btn_islemler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_islemler.UseVisualStyleBackColor = false;
            this.btn_islemler.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_islemler.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // panelIslemler
            // 
            this.panelIslemler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIslemler.Controls.Add(this.dataGridViewIslemler);
            this.panelIslemler.Location = new System.Drawing.Point(353, 42);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(900, 400);
            this.panelIslemler.TabIndex = 5;
            // 
            // dataGridViewIslemler
            // 
            this.dataGridViewIslemler.AllowUserToAddRows = false;
            this.dataGridViewIslemler.AllowUserToDeleteRows = false;
            this.dataGridViewIslemler.AllowUserToResizeColumns = false;
            this.dataGridViewIslemler.AllowUserToResizeRows = false;
            this.dataGridViewIslemler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIslemler.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewIslemler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewIslemler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIslemler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIslemler.ColumnHeadersHeight = 50;
            this.dataGridViewIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewIslemler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewIslemler.EnableHeadersVisualStyles = false;
            this.dataGridViewIslemler.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewIslemler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewIslemler.MultiSelect = false;
            this.dataGridViewIslemler.Name = "dataGridViewIslemler";
            this.dataGridViewIslemler.ReadOnly = true;
            this.dataGridViewIslemler.RowHeadersVisible = false;
            this.dataGridViewIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIslemler.ShowCellToolTips = false;
            this.dataGridViewIslemler.ShowEditingIcon = false;
            this.dataGridViewIslemler.Size = new System.Drawing.Size(900, 400);
            this.dataGridViewIslemler.TabIndex = 0;
            this.dataGridViewIslemler.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewIslemler_ColumnAdded);
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
            this.btn_grafik.TabIndex = 12;
            this.btn_grafik.Text = "Grafik";
            this.btn_grafik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_grafik.UseVisualStyleBackColor = false;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            this.btn_grafik.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_grafik.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // IslemlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.btn_grafik);
            this.Controls.Add(this.btn_kitaplar);
            this.Controls.Add(this.btn_ogrenciler);
            this.Controls.Add(this.btn_islemler);
            this.Controls.Add(this.panelIslemler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IslemlerListesi";
            this.Text = "İşlemler Listesi";
            this.Load += new System.EventHandler(this.IslemlerListesi_Load);
            this.panelIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Button btn_ogrenciler;
        private System.Windows.Forms.Button btn_islemler;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.DataGridView dataGridViewIslemler;
        private System.Windows.Forms.Button btn_grafik;
    }
}