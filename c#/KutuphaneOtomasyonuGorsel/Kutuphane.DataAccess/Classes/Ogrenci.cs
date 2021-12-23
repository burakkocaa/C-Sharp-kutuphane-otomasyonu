using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Classes
{
    public class Ogrenci
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
            adapter = new OleDbDataAdapter("select * from tbl_ogrenci", connection);

            // DataSet ile Veritabanı arasındaki köprüyü DataAdapter ile sağladım
            adapter.Fill(dataSet);
            accessConnection.close();

            return dataSet;
        }
        public Boolean ekle(string ad, string soyad, string ogrenciNo, string tcNo, string telNo, int borc , Boolean kitapAlabilirMi)
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();

            // SQL insert into komutu (veritabanındaki öğrenci tablosuna gerekli bilgileri ekliyor)
            cmd = new OleDbCommand("insert into tbl_ogrenci (ad,soyad,ogrenciNo,tcNo,telNo,borc, kitapAlabilirMi) values ('" + ad + "','" + soyad + "','" + ogrenciNo + "','" + tcNo + "','" + telNo + "'," + borc + "," + kitapAlabilirMi + ")", connection);

            cmd.ExecuteNonQuery();

            accessConnection.close();

            return true;
        }
        public DataSet ara(int id) // id'ye göre öğrenci arama
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();
            dataSet = new DataSet();

            cmd = new OleDbCommand("Select * from tbl_ogrenci where ID = " + id, connection);

            adapter = new OleDbDataAdapter(cmd);

            adapter.Fill(dataSet);

            accessConnection.close();
            return dataSet;
        }
        public DataSet ara(string ad) // // ada göre öğrenci arama
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();
            dataSet = new DataSet();

            cmd = new OleDbCommand("Select * from tbl_ogrenci where ad like '%" + ad + "%'", connection);

            adapter = new OleDbDataAdapter(cmd);

            adapter.Fill(dataSet);
            accessConnection.close();

            return dataSet;
        }
        public Boolean guncelle(int id, string ad, string soyad, string ogrenciNo, string tcNo, string telNo) // bütün verileri gelen veriler ile güncelle
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();

            cmd = new OleDbCommand("update tbl_ogrenci set ad = '" + ad + "', soyad = '" + soyad + "', ogrenciNo = '" + ogrenciNo + "', tcNo = '" + tcNo + "', telNo = '" + telNo + "' where ID = " + id, connection);

            cmd.ExecuteNonQuery();

            accessConnection.close();

            return true;
        }
        public Boolean guncelle(int id, int borc) // ID'ye göre borç verisini güncelle (Overloading)
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();

            cmd = new OleDbCommand("update tbl_ogrenci set borc = " + borc + " where ID = " + id, connection);

            cmd.ExecuteNonQuery();

            accessConnection.close();

            return true;
        }
        public Boolean guncelle(int id, Boolean kitapAlabilirMi) // ID'ye göre kitap alabilme durumunu güncelle (Overloading)
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();

            cmd = new OleDbCommand("update tbl_ogrenci set kitapAlabilirMi = " + kitapAlabilirMi + " where ID = " + id, connection);

            cmd.ExecuteNonQuery();

            accessConnection.close();

            return true;
        }
        public Boolean sil(int id) // benzersiz olan id'ye göre kesin sonuç alarak silme
        {
            accessConnection = new DBAccessConnection();
            connection = accessConnection.connect();

            cmd = new OleDbCommand("delete * from tbl_ogrenci where ID = " + id, connection);
            cmd.ExecuteNonQuery();

            accessConnection.close();

            return true;
        }
    }
}
