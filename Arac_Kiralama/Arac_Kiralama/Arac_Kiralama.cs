using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    class Arac_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Araç_Kiralama;Integrated Security=True");
        DataTable tablo;
        public void Ekle_sil_guncelle(SqlCommand command, string sorgu)//sorgudaki komuta göre ekleme silme ya da güncelleme işlemlerinden birisini yapmaya yarar
        {
            baglanti.Open();
            command.Connection = baglanti;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();// işlemi onaylama
            baglanti.Close();

        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)//tabloya databaseden alınan bilgiler listelenir
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void Bos_Araclar(ComboBox combo, string sorgu)//boş olan araçları seçer ve plakalarını araçlar comboboxuna yerleştirir
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }

        public void TC_Ara(TextBox tc, TextBox adsoyad, TextBox telefon, string sorgu)//databsede eşleşen tcye göre diğer bilgilerin doldurulmasını sağlar
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        public void CombodanGetir(ComboBox araclar, TextBox marka, TextBox seri, TextBox yil, TextBox renk, string sorgu)//seçilen araca göre diğer bilgilerin getirilmesini sağlar
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();

            }
            baglanti.Close();
        }

        public void Ucret_Hesapla(ComboBox combokirasekli, TextBox ucret, string sorgu)//seçilen kira türüne göre ücreti hesaplar
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                if (combokirasekli.SelectedIndex == 0)
                {
                    ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1.00).ToString();
                }

                if (combokirasekli.SelectedIndex == 1)
                {
                    ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.80).ToString();
                }

                if (combokirasekli.SelectedIndex == 2)
                {
                    ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.70).ToString();
                }
            }
            baglanti.Close();
        }

        public void satishesapla(Label lbl)//satışlar kısmındaki toplam kazancı hesplar
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("select sum(tutar) from satis", baglanti);
            lbl.Text = "Toplam Tutar : " + command.ExecuteScalar() + "TL";
            baglanti.Close();
        }
    }
}
