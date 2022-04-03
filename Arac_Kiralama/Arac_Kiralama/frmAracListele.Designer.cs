
namespace Arac_Kiralama
{
    partial class frmAracListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Ucrettxt = new System.Windows.Forms.TextBox();
            this.Markacombo = new System.Windows.Forms.ComboBox();
            this.Sericombo = new System.Windows.Forms.ComboBox();
            this.Yakitcombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.comboAraclar = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Plakatxt
            // 
            this.Plakatxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Plakatxt.Location = new System.Drawing.Point(124, 106);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(136, 21);
            this.Plakatxt.TabIndex = 0;
            // 
            // Yiltxt
            // 
            this.Yiltxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yiltxt.Location = new System.Drawing.Point(124, 205);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(136, 21);
            this.Yiltxt.TabIndex = 1;
            this.Yiltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Yiltxt_KeyPress);
            // 
            // Renktxt
            // 
            this.Renktxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Renktxt.Location = new System.Drawing.Point(124, 238);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(136, 21);
            this.Renktxt.TabIndex = 2;
            this.Renktxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Renktxt_KeyPress);
            // 
            // Kmtxt
            // 
            this.Kmtxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kmtxt.Location = new System.Drawing.Point(124, 271);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(136, 21);
            this.Kmtxt.TabIndex = 3;
            this.Kmtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kmtxt_KeyPress);
            // 
            // Ucrettxt
            // 
            this.Ucrettxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ucrettxt.Location = new System.Drawing.Point(124, 338);
            this.Ucrettxt.Name = "Ucrettxt";
            this.Ucrettxt.Size = new System.Drawing.Size(136, 21);
            this.Ucrettxt.TabIndex = 4;
            this.Ucrettxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ucrettxt_KeyPress);
            // 
            // Markacombo
            // 
            this.Markacombo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Markacombo.FormattingEnabled = true;
            this.Markacombo.Location = new System.Drawing.Point(124, 138);
            this.Markacombo.Name = "Markacombo";
            this.Markacombo.Size = new System.Drawing.Size(136, 20);
            this.Markacombo.TabIndex = 5;
            this.Markacombo.SelectedIndexChanged += new System.EventHandler(this.Markacombo_SelectedIndexChanged);
            // 
            // Sericombo
            // 
            this.Sericombo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sericombo.FormattingEnabled = true;
            this.Sericombo.Location = new System.Drawing.Point(124, 171);
            this.Sericombo.Name = "Sericombo";
            this.Sericombo.Size = new System.Drawing.Size(136, 20);
            this.Sericombo.TabIndex = 6;
            // 
            // Yakitcombo
            // 
            this.Yakitcombo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yakitcombo.FormattingEnabled = true;
            this.Yakitcombo.Location = new System.Drawing.Point(124, 305);
            this.Yakitcombo.Name = "Yakitcombo";
            this.Yakitcombo.Size = new System.Drawing.Size(136, 20);
            this.Yakitcombo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Model(Yıl)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kira Ücreti";
            // 
            // btnResim
            // 
            this.btnResim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btnResim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btnResim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResim.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.ForeColor = System.Drawing.Color.White;
            this.btnResim.Location = new System.Drawing.Point(124, 377);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(135, 23);
            this.btnResim.TabIndex = 16;
            this.btnResim.Text = "Resim Değiştir";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(112)))), ((int)(((byte)(79)))));
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(112)))), ((int)(((byte)(79)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(112, 498);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnIptal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(194, 498);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 18;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(754, 77);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // comboAraclar
            // 
            this.comboAraclar.FormattingEnabled = true;
            this.comboAraclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.comboAraclar.Location = new System.Drawing.Point(608, 77);
            this.comboAraclar.Name = "comboAraclar";
            this.comboAraclar.Size = new System.Drawing.Size(135, 21);
            this.comboAraclar.TabIndex = 20;
            this.comboAraclar.SelectedIndexChanged += new System.EventHandler(this.comboAraclar_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(279, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(550, 414);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(124, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // frmAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(878, 563);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboAraclar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yakitcombo);
            this.Controls.Add(this.Sericombo);
            this.Controls.Add(this.Markacombo);
            this.Controls.Add(this.Ucrettxt);
            this.Controls.Add(this.Kmtxt);
            this.Controls.Add(this.Renktxt);
            this.Controls.Add(this.Yiltxt);
            this.Controls.Add(this.Plakatxt);
            this.Name = "frmAracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listesi / Güncelleme";
            this.Load += new System.EventHandler(this.frmAracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.TextBox Ucrettxt;
        private System.Windows.Forms.ComboBox Markacombo;
        private System.Windows.Forms.ComboBox Sericombo;
        private System.Windows.Forms.ComboBox Yakitcombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox comboAraclar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}