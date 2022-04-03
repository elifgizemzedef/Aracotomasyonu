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
    public partial class frmMusteriListele : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public frmMusteriListele()
        {
            InitializeComponent(); //formu oluşturur
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            YenileListele(); //müşterilerin güncel halini listeler
        }
        private void YenileListele()
        {
            string cümle = "select *from müşteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();

            //Kolon isimlerinin şeklini değiştirme
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "TELEFON";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "E-MAİL";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//tc benzerliğine göre arama yapıp listeler
        {
            string cümle = "select *from müşteri where tc like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//çift tıklandığında müşteri bilgilerini ilgili boşluklara aktarır
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            label8.Text = satır.Cells[0].Value.ToString();
            label7.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtAdres.Text = satır.Cells[3].Value.ToString();
            txtEmail.Text = satır.Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)//müşteri bilgilerini güncelleme butonu
        {
            string cümle = "update müşteri set telefon=@telefon,adres=@adres,email=@email where tc=@tc";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@tc", label8.Text);            
            command2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            command2.Parameters.AddWithValue("@adres", txtAdres.Text);
            command2.Parameters.AddWithValue("@email", txtEmail.Text);
            arackiralama.Ekle_sil_guncelle(command2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            label7.Text = "";
            label8.Text = "";
            YenileListele();//listenin en güncel halini listeler
        }

        private void btnSil_Click(object sender, EventArgs e)//siliyor
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from müşteri where tc='" + satır.Cells["tc"].Value.ToString() + "'";
            SqlCommand command2 = new SqlCommand();
            arackiralama.Ekle_sil_guncelle(command2, cümle);
            YenileListele();
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
