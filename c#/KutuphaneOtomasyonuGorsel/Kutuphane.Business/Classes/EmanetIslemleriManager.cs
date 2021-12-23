using Kutuphane.DataAccess.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Classes
{
    public class EmanetIslemleriManager
    {
        DataSet dataSet;
        EmanetIslemleri emanetIslemleri;
        public DataSet listele()
        {
            dataSet = new DataSet();
            emanetIslemleri = new EmanetIslemleri(); // Veritabanı katmanındaki EmanetIslemlerinden nesne oluşturdum

            dataSet = emanetIslemleri.listele(); // listele fonksiyonunu aynen çağırıp kullandım

            return dataSet;
        }
        public Boolean kitapAlma(int ogrenciID, int kitapID)
        {
            emanetIslemleri = new EmanetIslemleri();

            int borc = 0;
            DateTime emanetTarihi = DateTime.Now;
            DateTime teslimTarihi = emanetTarihi.AddDays(15);
            Boolean teslimDurumu = false;

            OgrenciManager ogrenciManager = new OgrenciManager();
            KitapManager kitapManager = new KitapManager();

            DataSet dataSetOgrenci = ogrenciManager.ara(ogrenciID); // Öğrencinin kitap alabilme durumunu aldım
            DataSet dataSetKitap = kitapManager.ara(kitapID);

            Boolean kitapAlabilirMi = Boolean.Parse(dataSetOgrenci.Tables[0].Rows[0]["kitapAlabilirMi"].ToString());
            int kitapStok = Int32.Parse(dataSetKitap.Tables[0].Rows[0]["stok"].ToString());
            
            // Kontrol edip yalnızca kitap alabiliyorsa ve kitap stokta varsa kitap alma işlemini yaptım
            if (kitapAlabilirMi & kitapStok > 0){ 
                emanetIslemleri.kitapAlma(ogrenciID, kitapID, borc, teslimTarihi.Date, emanetTarihi.Date, teslimDurumu);
                return true; // işlem başarılı mesajı için
            }
            else
            {
                return false; // işlem başarısız mesajı için
            }   
        }
        public Boolean kitapIade(int islemID, int kitapID, int ogrenciID)
        {
            emanetIslemleri = new EmanetIslemleri();
            DataSet dataSet = emanetIslemleri.dahaOnceTeslimEdildiMi(islemID);

            // emanetIslemlerinden gelen teslim durumunu aldım
            Boolean kontrol = Boolean.Parse(dataSet.Tables[0].Rows[0]["teslimDurumu"].ToString());

            if (!kontrol) // daha önce teslim edilmemişse teslim et true gönder
            {
                emanetIslemleri.kitapIade(islemID, kitapID, ogrenciID);

                OgrenciManager ogrenciManager = new OgrenciManager();
                ogrenciManager.guncelle(ogrenciID, 0);

                return true;
            }
            else // teslim işlemini yapma false gönder
            {
                return false;
            }  
        }
        public DataSet ara(int id, String ogrenci_kitap) // ara fonksyinonunu aynen çağırdım
        {
            emanetIslemleri = new EmanetIslemleri();

            dataSet = emanetIslemleri.ara(id, ogrenci_kitap);

            return dataSet;
        }
        public void borcHesapla()
        {
            emanetIslemleri = new EmanetIslemleri();
            DataSet dataSetEmanet = emanetIslemleri.getborcHesapla(); // borç hesaplamak için gereken verileri aldım

            foreach(DataRow row in dataSetEmanet.Tables[0].Rows) // her emanet işlemi için borç hesaplaması yaptım
            {
                int ogrenciID = Int32.Parse(row[0].ToString());
                DateTime teslimTarihi = DateTime.Parse(row[1].ToString());
                Boolean teslimDurumu = Boolean.Parse(row[2].ToString());

                DateTime now = DateTime.Now;

                if (!teslimDurumu) // teslim edilmemişse
                {
                    if (now > teslimTarihi) // teslim tarihi geçmişse
                    {
                        Ogrenci ogrenci = new Ogrenci();

                        TimeSpan gecikenGun = now.Subtract(teslimTarihi); // günümüzden teslim tarihini çıkar

                        int borc = gecikenGun.Days; // geciken günü borca eşitle

                        ogrenci.guncelle(ogrenciID, borc); // öğrencinin borç verisini güncelle
                    }
                }
            }
        }
        public int emanetVerilenKitapSayisi()
        {
            emanetIslemleri = new EmanetIslemleri();

            int emanetVerilenKitapSayisi = emanetIslemleri.emanetVerilenKitapSayisi();

            return emanetVerilenKitapSayisi;
        }
    }
}
