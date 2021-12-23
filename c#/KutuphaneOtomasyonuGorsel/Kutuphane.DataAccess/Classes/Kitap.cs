using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Classes
{
    public class Kitap
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
            adapter = new OleDbDataAdapter("select * from tbl_kitap", connection);

            // DataSet ile Veritabanı arasındaki köprüyü DataAdapter ile sağladım
            adapter.Fill(dataSet);
            accessConnection.close();

            return dataSet;
        }
        public Boolean ekle(string ad, string yazar, string tur, int sayfa, int stok)
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();

            // SQL insert into komutu (veritabanındaki kitap tablosuna gerekli bilgileri ekliyor)
            cmd = new OleDbCommand("insert into tbl_kitap (ad,yazar,tur,sayfa,stok) values ('" + ad + "','" + yazar + "','" +
                tur + "','" + sayfa + "','" + stok + "')",connection);
 
            cmd.ExecuteNonQuery();

            accessConnection.close();

            return true;
        }
        public DataSet ara(int id) // id'ye göre kitap arama
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();
            dataSet = new DataSet();

            // SQL select komutu
            cmd = new OleDbCommand("Select * from tbl_kitap where ID = "+ id, connection);

            adapter = new OleDbDataAdapter(cmd);

            adapter.Fill(dataSet);
           
            accessConnection.close();
            return dataSet;
        }
        public DataSet ara(string ad) // ada göre kitap arama (Overloading)
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();
            dataSet = new DataSet();

            // SQL select komutu
            cmd = new OleDbCommand("Select * from tbl_kitap where ad like '%" + ad + "%'", connection);

            adapter = new OleDbDataAdapter(cmd);

            adapter.Fill(dataSet);
            accessConnection.close();

            return dataSet;
        }
        public Boolean guncelle(int id, string ad, string yazar, string tur, int sayfa, int stok) // bütün verileri gelen veriler ile güncelle
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();

            cmd = new OleDbCommand("update tbl_kitap set ad = '"+ ad +"', yazar = '"+ yazar +"', tur = '"+ tur +"', sayfa = "+ 
                sayfa +", stok = "+ stok +" where ID = " + id, connection);

            cmd.ExecuteNonQuery();

            accessConnection.close();

            return true;
        }
        public Boolean sil(int id) // benzersiz olan id'ye göre kesin sonuç alarak silme
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();

            cmd = new OleDbCommand("delete * from tbl_kitap where ID = " + id, connection);
            cmd.ExecuteNonQuery();

            accessConnection.close();

            return true;
        }
        public int kitapSayisi() 
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();
            dataSet = new DataSet();
            int kitapSayisi = 0;

            // SQL Count komutu ile satırları sayarak kitap sayısına ulaştık

            cmd = new OleDbCommand("Select COUNT(*) from tbl_kitap ", connection);

            OleDbDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows) // tablo boş değilse 
            {
                dataReader.Read();
                kitapSayisi = dataReader.GetInt32(0);
            }

            accessConnection.close();

            return kitapSayisi;
        }
    }
}
