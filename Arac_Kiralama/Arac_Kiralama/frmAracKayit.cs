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
    public partial class frmAracKayit : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public frmAracKayit()
        {
            InitializeComponent();
        }

        private void btnResim_Click(object sender, EventArgs e)//resim ekleme butonu
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validmi = true;
            foreach (Control control in this.Controls)//herhangi bir boşluk olması durumunda uyarı verir
            {
                if (control is TextBox || control is ComboBox)
                {
                    if (control.Text == String.Empty)
                    {
                        MessageBox.Show("Lütfen tüm boşlukları doldurunuz.");
                        validmi = false;
                    }
                }
                if (!validmi)
                    return;
            }
            foreach (var control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if (pictureBox1.Image == null)
                    {
                        MessageBox.Show("Lütfen tüm boşlukları doldurunuz(resim koyun).");
                        validmi = false;
                    }
                }

                if (!validmi)
                    return;

            }
            MessageBox.Show("Başarıyla kaydedildi.");


            string cümle = "insert into araç(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,tarih,durum) values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@tarih,@durum)";

            SqlCommand command2 = new SqlCommand();//araç bilgilerinin veri tabanına aktarılması
            command2.Parameters.AddWithValue("@plaka", Plakatxt.Text);
            command2.Parameters.AddWithValue("@marka", Markacombo.Text);
            command2.Parameters.AddWithValue("@seri", Sericombo.Text);
            command2.Parameters.AddWithValue("@yil", Yiltxt.Text);
            command2.Parameters.AddWithValue("@renk", Kmtxt.Text);
            command2.Parameters.AddWithValue("@km", Kmtxt.Text);
            command2.Parameters.AddWithValue("@yakit", Yakitcombo.Text);
            command2.Parameters.AddWithValue("@kiraucreti", int.Parse(Ucrettxt.Text));
            command2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            command2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            command2.Parameters.AddWithValue("@durum", "BOS");

            arackiralama.Ekle_sil_guncelle(command2, cümle);
            //butona bastıktan sonra kutucukları ve boşlukları temizler
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//seçilen markaya göre araç modellerinin otomatik olarak eklenmesini sağlar
        {
            try
            {
                Sericombo.Items.Clear();
                Sericombo.Text = "";
                Yakitcombo.Text = "";
                Yiltxt.Text = "";
                Kmtxt.Text = "";
                Kmtxt.Text = "";
                Ucrettxt.Text = "";

                if (Markacombo.SelectedIndex == 0)
                {
                    Sericombo.Items.Add("Astra");
                    Sericombo.Items.Add("Vectra");
                    Sericombo.Items.Add("Corsa");
                }
                else if (Markacombo.SelectedIndex == 1)
                {
                    Sericombo.Items.Add("Megan");
                    Sericombo.Items.Add("Clio");
                    Sericombo.Items.Add("Talisman");
                    Sericombo.Items.Add("Kadjar");
                }
                else if (Markacombo.SelectedIndex == 2)
                {
                    Sericombo.Items.Add("Linea");
                    Sericombo.Items.Add("Egea");
                    Sericombo.Items.Add("Doblo");
                }
                else if (Markacombo.SelectedIndex == 3)
                {
                    Sericombo.Items.Add("Fiesta");
                    Sericombo.Items.Add("Focus");
                    Sericombo.Items.Add("Mondeo");
                }
            }

            catch
            {

                ;
            }
        }

        //https://www.muratyazici.com/c-textboxa-sadece-harf-girme-sadece-sayi-girme.html

        private void Yiltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Kmtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Ucrettxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Renktxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
