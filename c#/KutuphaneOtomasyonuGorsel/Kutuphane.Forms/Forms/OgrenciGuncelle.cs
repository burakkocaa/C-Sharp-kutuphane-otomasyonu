using Kutuphane.Business.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.Forms
{
    public partial class OgrenciGuncelle : Form
    {
        /* Global Variables */
        int ogrenciID = 0;
        public OgrenciGuncelle()
        {
            InitializeComponent();
        }
        public OgrenciGuncelle(int ogrenciID) // Yapıcı fonksiyon ile öğrenci ID'si aldım
        {
            this.ogrenciID = ogrenciID;
            InitializeComponent();
        }
        private void OgrenciGuncelle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Formun çerçevesini kapat
            OgrenciManager ogrenciManager = new OgrenciManager();

            DataSet dataSet = ogrenciManager.ara(ogrenciID);

            // Güncellemek istediğimiz öğrencinin verilerini textboxlara yazdırdım
            tb_ad.Text = dataSet.Tables[0].Rows[0]["ad"].ToString();
            tb_soyad.Text = dataSet.Tables[0].Rows[0]["soyad"].ToString();
            tb_okulNo.Text = dataSet.Tables[0].Rows[0]["ogrenciNo"].ToString();
            tb_tcNo.Text = dataSet.Tables[0].Rows[0]["tcNo"].ToString();
            tb_telNo.Text = dataSet.Tables[0].Rows[0]["telNo"].ToString();
        }
        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (tb_ad.Text.Equals("") || tb_soyad.Text.Equals("") || tb_okulNo.Text.Equals("") || tb_tcNo.Text.Equals("") || tb_telNo.Text.Equals("")) // textboxlar boş mu kontrol ettim
            {
                MessageBox.Show("Lütfen boş geçmeyiniz.");
            }
            else
            {
                OgrenciManager ogrenciManager = new OgrenciManager();
                if (!ogrenciManager.guncelle(ogrenciID, tb_ad.Text, tb_soyad.Text, tb_okulNo.Text, tb_tcNo.Text, tb_telNo.Text))  // Ekleme işlemini yapmayı denedim. Başarısız olursa uyardım
                {
                    MessageBox.Show("Lütfen geçerli veriler giriniz. \n\n Örnek Veri Girişi;\n\n Öğrenci No: 182114053 (9 haneli) \n TC No: 11122233344 (11 haneli) \n Tel No: 5361112233 (10 haneli)");
                }
                else this.Close();
            }
        }

 
    }
}
