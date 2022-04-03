
namespace Arac_Kiralama
{
    partial class frmAracKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracKayit));
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Ucrettxt = new System.Windows.Forms.TextBox();
            this.Markacombo = new System.Windows.Forms.ComboBox();
            this.Sericombo = new System.Windows.Forms.ComboBox();
            this.Yakitcombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnResim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Plakatxt
            // 
            this.Plakatxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Plakatxt.Location = new System.Drawing.Point(212, 102);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(121, 21);
            this.Plakatxt.TabIndex = 0;
            // 
            // Yiltxt
            // 
            this.Yiltxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yiltxt.Location = new System.Drawing.Point(212, 196);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(121, 21);
            this.Yiltxt.TabIndex = 1;
            this.Yiltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Yiltxt_KeyPress);
            // 
            // Renktxt
            // 
            this.Renktxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Renktxt.Location = new System.Drawing.Point(212, 228);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(121, 21);
            this.Renktxt.TabIndex = 2;
            this.Renktxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Renktxt_KeyPress);
            // 
            // Kmtxt
            // 
            this.Kmtxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kmtxt.Location = new System.Drawing.Point(212, 260);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(121, 21);
            this.Kmtxt.TabIndex = 3;
            this.Kmtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kmtxt_KeyPress);
            // 
            // Ucrettxt
            // 
            this.Ucrettxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ucrettxt.Location = new System.Drawing.Point(212, 323);
            this.Ucrettxt.Name = "Ucrettxt";
            this.Ucrettxt.Size = new System.Drawing.Size(121, 21);
            this.Ucrettxt.TabIndex = 4;
            this.Ucrettxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ucrettxt_KeyPress);
            // 
            // Markacombo
            // 
            this.Markacombo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Markacombo.FormattingEnabled = true;
            this.Markacombo.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.Markacombo.Location = new System.Drawing.Point(212, 134);
            this.Markacombo.Name = "Markacombo";
            this.Markacombo.Size = new System.Drawing.Size(121, 20);
            this.Markacombo.TabIndex = 5;
            this.Markacombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Sericombo
            // 
            this.Sericombo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sericombo.FormattingEnabled = true;
            this.Sericombo.Location = new System.Drawing.Point(212, 165);
            this.Sericombo.Name = "Sericombo";
            this.Sericombo.Size = new System.Drawing.Size(121, 20);
            this.Sericombo.TabIndex = 6;
            // 
            // Yakitcombo
            // 
            this.Yakitcombo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yakitcombo.FormattingEnabled = true;
            this.Yakitcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg"});
            this.Yakitcombo.Location = new System.Drawing.Point(212, 292);
            this.Yakitcombo.Name = "Yakitcombo";
            this.Yakitcombo.Size = new System.Drawing.Size(121, 20);
            this.Yakitcombo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(112)))), ((int)(((byte)(79)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(112)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(146, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(257, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResim
            // 
            this.btnResim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btnResim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btnResim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResim.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.ForeColor = System.Drawing.Color.White;
            this.btnResim.Location = new System.Drawing.Point(479, 319);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(80, 25);
            this.btnResim.TabIndex = 10;
            this.btnResim.Text = "Resim Ekle";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(373, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(112, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Model(Yıl)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(112, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(112, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(112, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(112, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kira Ücreti";
            // 
            // frmAracKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(747, 479);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Yakitcombo);
            this.Controls.Add(this.Sericombo);
            this.Controls.Add(this.Markacombo);
            this.Controls.Add(this.Ucrettxt);
            this.Controls.Add(this.Kmtxt);
            this.Controls.Add(this.Renktxt);
            this.Controls.Add(this.Yiltxt);
            this.Controls.Add(this.Plakatxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAracKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}