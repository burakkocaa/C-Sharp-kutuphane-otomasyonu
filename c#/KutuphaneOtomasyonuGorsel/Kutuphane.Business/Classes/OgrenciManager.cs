using Kutuphane.DataAccess.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Classes
{
    public class OgrenciManager
    {
        DataSet dataSet;
        Ogrenci ogrenci;
        public DataSet listele()
        {
            dataSet = new DataSet();
            ogrenci = new Ogrenci(); // Veritabanı katmanındaki Ogrenciden nesne oluşturdum

            return ogrenci.listele(); // listele fonksiyonunu aynen çağırıp gönderdim
        }
        public Boolean ekle(string ad, string soyad, string ogrenciNo, string tcNo, string telNo)
        {
            ogrenci = new Ogrenci();

            if (ogrenciNo.Length == 9 & tcNo.Length == 11 & telNo.Length == 10)
            {
                ogrenci.ekle(ad, soyad, ogrenciNo, tcNo, telNo, 0, true);
                return true;
            }
            else return false;
        }
        public Boolean guncelle(int id, string ad, string soyad, string ogrenciNo, string tcNo, string telNo) 
        {
            ogrenci = new Ogrenci();
            
            if (ogrenciNo.Length == 9 & tcNo.Length == 11 & telNo.Length == 10)
            {
                ogrenci.guncelle(id, ad, soyad, ogrenciNo, tcNo, telNo); // Gelen verilerle guncelle fonksiyonunu aynen çağırdım
                return true;
            }
            else return false;    
        }
        public Boolean guncelle(int id, int borc)
        {
            ogrenci = new Ogrenci();

            ogrenci.guncelle(id, borc); // Gelen verilerle guncelle fonksiyonunu aynen çağırdım

            return true;
        }
        public Boolean guncelle(int id, Boolean KitapAlabilirMi)
        {
            ogrenci = new Ogrenci();

            ogrenci.guncelle(id, KitapAlabilirMi); // Gelen verilerle guncelle fonksiyonunu aynen çağırdım

            return true;
        }
        public DataSet ara(int id) // ID'ye göre ara
        {
            ogrenci = new Ogrenci();
            dataSet = new DataSet();

            dataSet = ogrenci.ara(id);

            return dataSet;
        }
        public DataSet ara(string ad) // Ada göre ara (Overloading)
        {
            ogrenci = new Ogrenci();
            dataSet = new DataSet();

            dataSet = ogrenci.ara(ad);

            return dataSet;
        }
        public Boolean sil(int id)
        {
            ogrenci = new Ogrenci();

            ogrenci.sil(id); // Gelen verilerle sil fonksiyonunu aynen çağırdım

            return true;
        }
    }
}
