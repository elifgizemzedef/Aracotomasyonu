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
using System.Globalization; //CultureInfo.CurrentCulture.TextInfo.ToTitleCase()  ==> fonskiyonunun çalışması için gereken using

namespace Arac_Kiralama
{
    public partial class frmMusteriEkle : Form
    {
        Arac_Kiralama arac_kiralama = new Arac_Kiralama();
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            long kimlikNO = long.Parse(txtTc.Text);
            int yil = int.Parse(txtYil.Text);
            string ad = txtAd.Text.Trim().ToLower();
            ad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ad);//her kelimenin sadece baş harfini büyütür  
            string soyad = txtSoyad.Text.Trim().ToLower();
            soyad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(soyad);
            string telefon = txtTelefon.Text;
            string adres = txtAdres.Text;
            string email = txtEmail.Text;
            bool? durum;

            try
            {
                using (KimlikTC.KPSPublicSoapClient service = new KimlikTC.KPSPublicSoapClient())//kişinin kontrolü bu site aracılığıyla sağlanır
                {
                    durum = service.TCKimlikNoDogrula(kimlikNO, ad.ToUpper(), soyad.ToUpper(), yil);
                }
            }

            catch
            {
                durum = null;
            }

            if (durum == false)
            {
                txtTc.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtYil.Clear();
            }

            bool validmi = true;//kimlik bilgileri uyuşuyorsa kaydediyor uyuşmuyorsa ya da textboxlarda boşluk varsa uyarı mesajı veriyor

            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    if (control.Text == String.Empty && durum == false)
                    {
                        MessageBox.Show("Girilen kişi bilgileri bulunmamaktadır boşlukları tekrar doldurunuz.");
                        validmi = false;
                    }
                    else if (control.Text == String.Empty && durum == true)
                    {
                        MessageBox.Show("Lütfen tüm boşlukları doldurunuz.");
                        validmi = false;
                    }
                }

                if (!validmi)
                    return;
            }

            string cümle = "insert into müşteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)"; //veri tabanına kaydetme sorgusu
            SqlCommand command2 = new SqlCommand();

            command2.Parameters.AddWithValue("@tc", kimlikNO);
            command2.Parameters.AddWithValue("@adsoyad", ad + " " + soyad);
            command2.Parameters.AddWithValue("@telefon", telefon);
            command2.Parameters.AddWithValue("@adres", adres);
            command2.Parameters.AddWithValue("@email", email);
            arac_kiralama.Ekle_sil_guncelle(command2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("Başarılı bir şekilde kaydedildi");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();//sayfayı kapatır
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)//sadece harf ya da sadece rakam
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtYil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
