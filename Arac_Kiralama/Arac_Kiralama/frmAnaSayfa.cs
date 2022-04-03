using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class frmAnaSayfa : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public frmAnaSayfa()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()//renk seçimi yapar
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)//eğer renk daha önce seçilmişse tekrar seçer.
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton(object btnsender)//theme color kısmından seçilen rengi butonun rengine atar
        {
            DisableButton();
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.FlatAppearance.MouseOverBackColor = color;                    
                }

            }
        }
        private void DisableButton()//butonun tıklandıktan sonra değişen rengini orijinal haline döndürür
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(18, 32, 45);
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//müşteri ekle formunu örnekler
        {
            ActiveButton(sender);
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//müşteri listele formunu örnekler
        {
            ActiveButton(sender);
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)//araç kayıt formunu örnekler
        {
            ActiveButton(sender);
            frmAracKayit kayit = new frmAracKayit();
            kayit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)//araç listeleme formunu örnekler
        {
            ActiveButton(sender);
            frmAracListele listele = new frmAracListele();
            listele.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)//sözleşme formunu örnekler
        {
            ActiveButton(sender);
            frmSozlesme sozlesme = new frmSozlesme();
            sozlesme.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)//tsaış formunu örnekler
        {
            ActiveButton(sender);
            frmSatis satis = new frmSatis();
            satis.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)//çıkış yapar
        {
            this.Close();
        }
    }
}
