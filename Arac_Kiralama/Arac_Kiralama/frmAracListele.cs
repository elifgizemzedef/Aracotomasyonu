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
    public partial class frmAracListele : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public frmAracListele()
        {
            InitializeComponent();
        }

        private void frmAracListele_Load(object sender, EventArgs e)//tüm araçları listeler
        {
            YenileAraçlarListesi();
            comboAraclar.SelectedIndex = 0;
        }
        private void YenileAraçlarListesi()
        {
            string cümle = "select *from araç";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void btnResim_Click(object sender, EventArgs e)//seçilen aracın resmini günceller
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)//seçilen aracın bilgilerinin değiştirilmesini sağlayana buton
        {
            string cümle = "update araç set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih where plaka=@plaka";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@plaka", Plakatxt.Text);
            command2.Parameters.AddWithValue("@marka", Markacombo.Text);
            command2.Parameters.AddWithValue("@seri", Sericombo.Text);
            command2.Parameters.AddWithValue("@yil", Yiltxt.Text);
            command2.Parameters.AddWithValue("@renk", Renktxt.Text);
            command2.Parameters.AddWithValue("@km", Kmtxt.Text);
            command2.Parameters.AddWithValue("@yakit", Yakitcombo.Text);
            command2.Parameters.AddWithValue("@kiraucreti", int.Parse(Ucrettxt.Text));
            command2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            command2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            arackiralama.Ekle_sil_guncelle(command2, cümle);
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox2.ImageLocation = "";
            YenileAraçlarListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)//seçilen aracı databaseden siler
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from araç where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand command2 = new SqlCommand();
            arackiralama.Ekle_sil_guncelle(command2, cümle);
            YenileAraçlarListesi();
            pictureBox2.ImageLocation = "";
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sericombo.Items.Clear(); //plaka dışında diğer boşlukları temizler
            Sericombo.Text = "";
            Renktxt.Text = "";
            Yiltxt.Text = "";
            Yakitcombo.Text = "";
            Kmtxt.Text = "";
            Ucrettxt.Text = "";

            try//seçilen markaya göre araç modellerinin otomatik olarak eklenmesini sağlar
            {

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

        private void comboAraclar_SelectedIndexChanged(object sender, EventArgs e)//boş veya dolu araçların filtreleme işlemini gerçekleştirir
        {
            try
            {
                if (comboAraclar.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                else if (comboAraclar.SelectedIndex == 1)
                {
                    string cümle = "select *from araç where durum='BOS'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);

                }
                else if (comboAraclar.SelectedIndex == 2)
                {
                    string cümle = "select *from araç where durum='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);

                }
            }
            catch
            {

                ;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//datagridden bilgileri çift tıklayarak uygun boşluklara aktarma
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            Plakatxt.Text = satır.Cells["plaka"].Value.ToString();
            Markacombo.Text = satır.Cells["marka"].Value.ToString();
            Sericombo.Text = satır.Cells["seri"].Value.ToString();
            Yiltxt.Text = satır.Cells["yil"].Value.ToString();
            Renktxt.Text = satır.Cells["renk"].Value.ToString();
            Kmtxt.Text = satır.Cells["km"].Value.ToString();
            Yakitcombo.Text = satır.Cells["yakit"].Value.ToString();
            Ucrettxt.Text = satır.Cells["kiraucreti"].Value.ToString();
            pictureBox2.ImageLocation = satır.Cells["resim"].Value.ToString();
        }

        private void Yiltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Renktxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void Kmtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Ucrettxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
