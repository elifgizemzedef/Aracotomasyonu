using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class frmSozlesme : Form
    {
        Arac_Kiralama arac = new Arac_Kiralama();
        public frmSozlesme()
        {
            InitializeComponent();
        }

        private void frmSozlesme_Load(object sender, EventArgs e)
        {
            Bos_Araclar();
            Yenile();
        }
        private void Bos_Araclar()//yalnızca müsait olan araçların comboboxta çıkmasını sağlar
        {
            string sorgu2 = "select *from araç where durum='BOS'";
            arac.Bos_Araclar(comboAraclar, sorgu2);
        }

        private void Yenile()//gerçekleştirilmiş sözleşmeleri listeler
        {
            string sorgu3 = "select *from sozlesme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)//tc kimlik numarsaı doğru girilmiş kişinin kalan bilgilerini doldurur
        {
            if (txtTc.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select *from müşteri where tc ='" + txtTc.Text.ToString() + "'";
            arac.TC_Ara(txtTc, txtAdSoyad, txtTelefon, sorgu2);
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e) // datagridde girilen tc değerine yakın olan tc değerlerini getirir
        {
            string sorgu = "select *from sozlesme where tc like '%" + txtTcAra.Text + "%'";
            SqlDataAdapter adtr = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr, sorgu);
        }

        private void comboAraclar_SelectedIndexChanged(object sender, EventArgs e) //aracın plakasına göre bilgileri doldurur
        {
            string sorgu2 = "select *from araç where plaka like'" + comboAraclar.SelectedItem + "'";
            arac.CombodanGetir(comboAraclar, txtMarka, txtSeri, txtYil, txtRenk, sorgu2);
        }

        private void comboKiraSekli_SelectedIndexChanged(object sender, EventArgs e)//seçilen kira şekline göre databaseden aldığı bilgiyle ücreti hesaplar
        {
            string sorgu2 = "select *from araç where plaka like'" + comboAraclar.SelectedItem + "'";
            arac.Ucret_Hesapla(comboKiraSekli, txtKiraUcreti, sorgu2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)//toplam ücreti hesaplar
        {
            TimeSpan gun = DateTime.Parse(dateDonus.Text) - DateTime.Parse(dateCikis.Text);
            int gun2 = gun.Days;
            txtGun.Text = gun2.ToString();
            txtTutar.Text = (gun2 * int.Parse(txtKiraUcreti.Text)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()//kirayla alakalı olan bilgileri temizler
        {
            dateCikis.Text = DateTime.Now.ToShortDateString();
            dateDonus.Text = DateTime.Now.ToShortDateString();
            comboKiraSekli.Text = "";
            txtKiraUcreti.Text = "";
            txtGun.Text = "";
            txtTutar.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)//girilen bilgilerin database'e eklenemsini sağlar
        {
            string sorgu = "insert into sozlesme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,ctarih,dtarihi)" +
                " values(@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarihi)";
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@tc", txtTc.Text);
            command.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            command.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            command.Parameters.AddWithValue("@ehliyetno", txtE_No.Text);
            command.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
            command.Parameters.AddWithValue("@e_yer", txtE_Yer.Text);
            command.Parameters.AddWithValue("@plaka", comboAraclar.Text);
            command.Parameters.AddWithValue("@marka", txtMarka.Text);
            command.Parameters.AddWithValue("@seri", txtSeri.Text);
            command.Parameters.AddWithValue("@yil", txtYil.Text);
            command.Parameters.AddWithValue("@renk", txtRenk.Text);
            command.Parameters.AddWithValue("@kirasekli", comboKiraSekli.Text);
            command.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));
            command.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            command.Parameters.AddWithValue("@ctarih", dateCikis.Text);
            command.Parameters.AddWithValue("@dtarihi", dateDonus.Text);
            command.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));

            arac.Ekle_sil_guncelle(command, sorgu);
            string sorgu2 = "update araç set durum='DOLU' where plaka='" + comboAraclar.Text + "'";//sözleşmesi gerçekleştirilmiş aracın durumunu dolu olarak günceller
            SqlCommand command2 = new SqlCommand();
            arac.Ekle_sil_guncelle(command2, sorgu2);
            comboAraclar.Items.Clear();
            Bos_Araclar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboAraclar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme eklendi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update sozlesme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,e_tarih=@e_tarih,e_yer=@e_yer,marka=@marka,seri=@seri,yil=@yil,renk=@renk,kirasekli=@kirasekli,kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,ctarih=@ctarih,dtarihi=@dtarihi where plaka=@plaka";
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@tc", txtTc.Text);
            command.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            command.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            command.Parameters.AddWithValue("@ehliyetno", txtE_No.Text);
            command.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
            command.Parameters.AddWithValue("@e_yer", txtE_Yer.Text);
            command.Parameters.AddWithValue("@plaka", comboAraclar.Text);
            command.Parameters.AddWithValue("@marka", txtMarka.Text);
            command.Parameters.AddWithValue("@seri", txtSeri.Text);
            command.Parameters.AddWithValue("@yil", txtYil.Text);
            command.Parameters.AddWithValue("@renk", txtRenk.Text);
            command.Parameters.AddWithValue("@kirasekli", comboKiraSekli.Text);
            command.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));
            command.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            command.Parameters.AddWithValue("@ctarih", dateCikis.Text);
            command.Parameters.AddWithValue("@dtarihi", dateDonus.Text);
            command.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            arac.Ekle_sil_guncelle(command, sorgu);
            comboAraclar.Items.Clear();
            Bos_Araclar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboAraclar.Text = "";
            Temizle();//kirayla alakalı olan bilgileri temizler
            MessageBox.Show("Sözleşme güncellendi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//cift tıklanan sözleşme bilgilerini ilgili boşluklara getirir
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtE_No.Text = satır.Cells[3].Value.ToString();
            txtE_Tarih.Text = satır.Cells[4].Value.ToString();
            txtE_Yer.Text = satır.Cells[5].Value.ToString();
            comboAraclar.Text = satır.Cells[6].Value.ToString();
            txtMarka.Text = satır.Cells[7].Value.ToString();
            txtSeri.Text = satır.Cells[8].Value.ToString();
            txtYil.Text = satır.Cells[9].Value.ToString();
            txtRenk.Text = satır.Cells[10].Value.ToString();
            comboKiraSekli.Text = satır.Cells[11].Value.ToString();            
            txtKiraUcreti.Text = satır.Cells[12].Value.ToString();
            txtGun.Text = satır.Cells[13].Value.ToString();
            txtTutar.Text = satır.Cells[14].Value.ToString();
            dateCikis.Text = satır.Cells[15].Value.ToString();
            dateDonus.Text = satır.Cells[16].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//ilgili sözleşmenin üzerine bir kere tıkladığımızda alacak verecek durumunu hesaplar ve yazar
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(satır.Cells["dtarihi"].Value.ToString());
            int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarki = bugun - donus;
            int _gunfarki = gunfarki.Days;
            int ucretfarki;
            ucretfarki = _gunfarki * ucret;
            txtEkstra.Text = ucretfarki.ToString();
        }

        private void btnAracTeslim_Click(object sender, EventArgs e)//seçilen aracın teslim edilmesini sağlar
        {
            if (int.Parse(txtEkstra.Text) >= 0 || int.Parse(txtEkstra.Text) < 0)
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satır.Cells["tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(satır.Cells["ctarih"].Value.ToString());
                TimeSpan gun = bugun - cikis;
                int _gun = gun.Days;
                int toplamtutar = _gun * ucret;

                string sorgu1 = "delete from sozlesme where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";//aracı plakası sayesinde tespit ederek sözleşme tablosundan siler
                SqlCommand command1 = new SqlCommand();
                arac.Ekle_sil_guncelle(command1, sorgu1);

                string sorgu2 = "update araç set durum='BOS' where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";//aracın durumunu boş olarak günceller
                SqlCommand command2 = new SqlCommand();
                arac.Ekle_sil_guncelle(command2, sorgu2);

                string sorgu3 = "insert into satis(tc,adsoyad,plaka,marka,seri,yil,renk,gun,tutar,tarih1,tarih2,fiyat)" +
               "values(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@tutar,@tarih1,@tarih2,@fiyat)";//satış tablosuna bilgileri kaydeder
                SqlCommand command3 = new SqlCommand();
                command3.Parameters.AddWithValue("@tc", satır.Cells["tc"].Value.ToString());
                command3.Parameters.AddWithValue("@adsoyad", satır.Cells["adsoyad"].Value.ToString());
                command3.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                command3.Parameters.AddWithValue("@marka", satır.Cells["marka"].Value.ToString());
                command3.Parameters.AddWithValue("@seri", satır.Cells["seri"].Value.ToString());
                command3.Parameters.AddWithValue("@yil", satır.Cells["yil"].Value.ToString());
                command3.Parameters.AddWithValue("@renk", satır.Cells["renk"].Value.ToString());
                command3.Parameters.AddWithValue("@gun", _gun);
                command3.Parameters.AddWithValue("@tutar", toplamtutar);
                command3.Parameters.AddWithValue("@tarih1", satır.Cells["ctarih"].Value.ToString());
                command3.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());
                command3.Parameters.AddWithValue("@fiyat", ucret);
                arac.Ekle_sil_guncelle(command3, sorgu3);

                MessageBox.Show("Araç teslim edildi.");
                comboAraclar.Text = "";
                comboAraclar.Items.Clear();
                Bos_Araclar();//boşalan arabayı tekrardan araçlar comboboxuna ekler
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboAraclar.Text = "";
                Temizle();
                txtEkstra.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız", "Uyarı");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtE_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRenk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtTcAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }    
}
