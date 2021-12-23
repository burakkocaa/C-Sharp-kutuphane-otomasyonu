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
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Formun çerçevesini kapat

        }
        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tb_ad.Text.Equals("") || tb_soyad.Text.Equals("") || tb_okulNo.Text.Equals("") || tb_tcNo.Text.Equals("") || tb_telNo.Text.Equals("")) // textboxlar boş mu kontrol ettim
            {
                MessageBox.Show("Lütfen boş geçmeyiniz.");
            }
            else
            {
                OgrenciManager ogrenciManager = new OgrenciManager();
                if (!ogrenciManager.ekle(tb_ad.Text, tb_soyad.Text, tb_okulNo.Text, tb_tcNo.Text, tb_telNo.Text))  // Ekleme işlemini yapmayı denedim. Başarısız olursa uyardım
                {
                    MessageBox.Show("Lütfen geçerli veriler giriniz. \n\n Örnek Veri Girişi;\n\n Öğrenci No: 182114053 (9 haneli) \n TC No: 11122233344 (11 haneli) \n Tel No: 5361112233 (10 haneli)");
                }
                else this.Close();
            }
        }
    }
}
