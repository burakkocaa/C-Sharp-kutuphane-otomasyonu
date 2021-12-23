using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Classes
{
    public class EmanetIslemleri
    {
        DBAccessConnection accessConnection;
        OleDbConnection connection;
        OleDbDataAdapter adapter;
        DataSet dataSet;
        OleDbCommand cmd;
        public DataSet listele() // dataset döndüren listele fonksiyonu
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();
            dataSet = new DataSet();

            // SQL select komutu
            adapter = new OleDbDataAdapter("select * from tbl_emanet", connection);

            // DataSet ile Veritabanı arasındaki köprüyü DataAdapter ile sağladım
            adapter.Fill(dataSet);
            accessConnection.close();

            return dataSet;
        }
        public Boolean kitapAlma(int ogrenciID, int kitapID, int borc, DateTime teslimTarihi, DateTime emanetTarihi, Boolean teslimDurumu)
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();

            // SQL insert into komutu (veritabanındaki emanet tablosuna gerekli bilgileri ekliyor)
            cmd = new OleDbCommand("insert into tbl_emanet (ogrenciID, kitapID, teslimTarihi, emanetTarihi, teslimDurumu) values (" + ogrenciID + "," + kitapID  + ",'" + teslimTarihi + "','" + emanetTarihi + "'," + teslimDurumu + ")", connection);

            // Komutu çalıştır
            cmd.ExecuteNonQuery();

            // kitapIslemleri fonksiyonunu ID'ler ile çağırdım
            kitapIslemleri(kitapID, ogrenciID, false, false);

            accessConnection.close();

            return true;
        }
        public Boolean kitapIade(int islemID, int kitapID, int ogrenciID)
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();

            // SQL update komutu (veritabanındaki teslim durumunu güncelliyor, teslim edilen tarihi giriyor)
            cmd = new OleDbCommand("update tbl_emanet set teslimDurumu = " + true + ", teslimEdilenTarih = '"+ DateTime.Now.Date +"' where ID = " + islemID, connection);

            // Komutu çalıştır
            cmd.ExecuteNonQuery();

            // kitapIslemleri fonksiyonunu ID'ler ile çağırdım
            kitapIslemleri(kitapID, ogrenciID, true, true);
            
            accessConnection.close();

            return true;
        }
        private void kitapIslemleri(int kitapID, int ogrenciID, Boolean kitapStok, Boolean kitapAlabilirMi)
        {
            // Fonksiyonun çağrılma şekline göre 2 farklı işlem yaptırdım
            if (kitapStok) // true ise stok arttır
            {
                cmd = new OleDbCommand("update tbl_kitap set stok = stok + 1 where ID = " + kitapID, connection);
                cmd.ExecuteNonQuery();
            }
            else // false ise stok azalt
            {
                cmd = new OleDbCommand("update tbl_kitap set stok = stok - 1 where ID = " + kitapID, connection);
                cmd.ExecuteNonQuery();
            }
            
            // Öğrencinin kitap alıp alamayağı verisini güncelle
            cmd = new OleDbCommand("update tbl_ogrenci set kitapAlabilirMi = "+ kitapAlabilirMi +" where ID = " + ogrenciID, connection);
            cmd.ExecuteNonQuery();  
        }
        public DataSet ara(int ID , String ogrenci_kitap) // emanet arama öğrenci veya kitap ID ile yapılabilir. Bunu sağlamak için ogrenci_kitap değişkenini kullandım
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();
            dataSet = new DataSet();

            if(ogrenci_kitap.Equals("öğrenci")) // öğrenci tablosunda arama
                cmd = new OleDbCommand("Select * from tbl_emanet where ogrenciID = " + ID, connection);
            else if(ogrenci_kitap.Equals("kitap")) // kitap tablosunda arama
                cmd = new OleDbCommand("Select * from tbl_emanet where kitapID = " + ID, connection);

            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataSet);

            accessConnection.close();
            return dataSet; // geri dataset gönder
        }
        public DataSet dahaOnceTeslimEdildiMi(int islemID) // kitap iade ederken daha önce iade edildiyse uyarmak için bu fonksiyonu tasarladım
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();
            dataSet = new DataSet();

            cmd = new OleDbCommand("Select teslimDurumu from tbl_emanet where ID = " + islemID, connection);
              
            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataSet);
            accessConnection.close();

            return dataSet;
        }
        public DataSet getborcHesapla() // Business katmanında borç hesaplayabilmek için gerekli verileri dataset ile gönderdim
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();
            dataSet = new DataSet();

            cmd = new OleDbCommand("Select ogrenciID, teslimTarihi, teslimDurumu from tbl_emanet", connection);

            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataSet);

            accessConnection.close();

            return dataSet;
        }
        public int emanetVerilenKitapSayisi()
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();
            dataSet = new DataSet();
            int emanetVerilenKitapSayisi = 0;

            // SQL Count komutu ile teslim edilmemiş kitapları sayarak verilen kitap sayısına ulaştık

            cmd = new OleDbCommand("Select COUNT(*) from tbl_emanet where teslimDurumu = " + false, connection);

            OleDbDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows) // tablo boş değilse 
            {
                dataReader.Read();
                emanetVerilenKitapSayisi = dataReader.GetInt32(0);
            }

            accessConnection.close();

            return emanetVerilenKitapSayisi;
        }
    }
}
