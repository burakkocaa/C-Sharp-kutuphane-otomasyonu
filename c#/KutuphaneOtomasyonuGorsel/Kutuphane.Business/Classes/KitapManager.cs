using Kutuphane.DataAccess.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Classes
{
    public class KitapManager
    {
        DataSet dataSet;
        Kitap kitap;
        public DataSet listele()
        {
            dataSet = new DataSet();
            kitap = new Kitap(); // Veritabanı katmanındaki Kitaptan nesne oluşturdum

            return kitap.listele(); // listele fonksiyonunu aynen çağırıp gönderdim
        }
        public Boolean ekle(string ad, string yazar, string tur, string sayfa, string stok)
        {
            kitap = new Kitap();
            int intSayfa;
            int intStok;
            if (Int32.TryParse(sayfa, out intSayfa) & Int32.TryParse(stok, out intStok))
            {
                kitap.ekle(ad, yazar, tur, intSayfa, intStok);
                return true;
            }
            else return false;
        }
        public DataSet ara(int id) // ID'ye göre ara
        {
            kitap = new Kitap();
            dataSet = new DataSet();

            dataSet = kitap.ara(id);

            return dataSet;
        }
        public DataSet ara(string ad) // Ada göre ara (Overloading)
        {
            kitap = new Kitap();
            dataSet = new DataSet();

            dataSet = kitap.ara(ad); 

            return dataSet;
        }
        public Boolean guncelle(int id, string ad, string yazar, string tur, string sayfa, string stok)
        {
            kitap = new Kitap();
            int intSayfa;
            int intStok;
            if (Int32.TryParse(sayfa, out intSayfa) & Int32.TryParse(stok, out intStok))
            {
                kitap.guncelle(id, ad, yazar, tur, intSayfa, intStok);
                return true;
            }
            else return false;
        }
        public Boolean sil(int id)
        {
            kitap = new Kitap();

            kitap.sil(id); // Gelen verilerle sil fonksiyonunu aynen çağırdım

            return true;
        }
        public int kitapSayisi()
        {
            kitap = new Kitap();

            int kitapSayisi = kitap.kitapSayisi();

            return kitapSayisi;
        }
    }
}
