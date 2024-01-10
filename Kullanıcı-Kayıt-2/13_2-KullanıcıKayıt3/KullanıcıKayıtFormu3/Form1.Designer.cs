
namespace KullanıcıKayıtFormu3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBayan = new System.Windows.Forms.RadioButton();
            this.rbBay = new System.Windows.Forms.RadioButton();
            this.nmBoy = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmAğırlık = new System.Windows.Forms.NumericUpDown();
            this.lnkAnlasma = new System.Windows.Forms.LinkLabel();
            this.chkAnlaşma = new System.Windows.Forms.CheckBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.btnDiğerDetay = new System.Windows.Forms.Button();
            this.btnResim = new System.Windows.Forms.Button();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.dtDTarih = new System.Windows.Forms.DateTimePicker();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.lsKan = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsExtra = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAğırlık)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::KullanıcıKayıtFormu3.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(3, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBayan);
            this.groupBox2.Controls.Add(this.rbBay);
            this.groupBox2.Location = new System.Drawing.Point(15, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cinsiyet:";
            // 
            // rbBayan
            // 
            this.rbBayan.AutoSize = true;
            this.rbBayan.Location = new System.Drawing.Point(122, 28);
            this.rbBayan.Name = "rbBayan";
            this.rbBayan.Size = new System.Drawing.Size(80, 28);
            this.rbBayan.TabIndex = 1;
            this.rbBayan.TabStop = true;
            this.rbBayan.Text = "Bayan";
            this.rbBayan.UseVisualStyleBackColor = true;
            // 
            // rbBay
            // 
            this.rbBay.AutoSize = true;
            this.rbBay.Location = new System.Drawing.Point(32, 28);
            this.rbBay.Name = "rbBay";
            this.rbBay.Size = new System.Drawing.Size(59, 28);
            this.rbBay.TabIndex = 0;
            this.rbBay.TabStop = true;
            this.rbBay.Text = "Bay";
            this.rbBay.UseVisualStyleBackColor = true;
            // 
            // nmBoy
            // 
            this.nmBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmBoy.Location = new System.Drawing.Point(134, 526);
            this.nmBoy.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nmBoy.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmBoy.Name = "nmBoy";
            this.nmBoy.Size = new System.Drawing.Size(125, 26);
            this.nmBoy.TabIndex = 2;
            this.nmBoy.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boy (cm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ağırlık (kg):";
            // 
            // nmAğırlık
            // 
            this.nmAğırlık.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmAğırlık.Location = new System.Drawing.Point(134, 561);
            this.nmAğırlık.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nmAğırlık.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmAğırlık.Name = "nmAğırlık";
            this.nmAğırlık.Size = new System.Drawing.Size(125, 26);
            this.nmAğırlık.TabIndex = 5;
            this.nmAğırlık.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // lnkAnlasma
            // 
            this.lnkAnlasma.AutoSize = true;
            this.lnkAnlasma.Location = new System.Drawing.Point(435, 477);
            this.lnkAnlasma.Name = "lnkAnlasma";
            this.lnkAnlasma.Size = new System.Drawing.Size(256, 24);
            this.lnkAnlasma.TabIndex = 11;
            this.lnkAnlasma.TabStop = true;
            this.lnkAnlasma.Text = "Anlaşma metni için tıklayınız...";
            this.lnkAnlasma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AnlaşmaMetniniAç);
            // 
            // chkAnlaşma
            // 
            this.chkAnlaşma.AutoSize = true;
            this.chkAnlaşma.Location = new System.Drawing.Point(439, 504);
            this.chkAnlaşma.Name = "chkAnlaşma";
            this.chkAnlaşma.Size = new System.Drawing.Size(249, 28);
            this.chkAnlaşma.TabIndex = 12;
            this.chkAnlaşma.Text = "Anlaşmayı kabul ediyorum";
            this.chkAnlaşma.UseVisualStyleBackColor = true;
            this.chkAnlaşma.CheckedChanged += new System.EventHandler(this.AnlaşmaKabulu);
            // 
            // btnTamam
            // 
            this.btnTamam.Enabled = false;
            this.btnTamam.Location = new System.Drawing.Point(424, 543);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(141, 44);
            this.btnTamam.TabIndex = 13;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(580, 543);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(141, 44);
            this.btnİptal.TabIndex = 14;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(424, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(297, 29);
            this.txtAd.TabIndex = 15;
            this.txtAd.Validated += new System.EventHandler(this.KontrolEt);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Soyadı:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(424, 47);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(297, 29);
            this.txtSoyad.TabIndex = 17;
            this.txtSoyad.Validated += new System.EventHandler(this.KontrolEt);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Şehir:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(424, 190);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdres.Size = new System.Drawing.Size(297, 116);
            this.txtAdres.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Doğum Tarihi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "Şifre:";
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(424, 347);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '*';
            this.txtŞifre.Size = new System.Drawing.Size(297, 29);
            this.txtŞifre.TabIndex = 27;
            this.txtŞifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // btnDiğerDetay
            // 
            this.btnDiğerDetay.Location = new System.Drawing.Point(424, 382);
            this.btnDiğerDetay.Name = "btnDiğerDetay";
            this.btnDiğerDetay.Size = new System.Drawing.Size(297, 35);
            this.btnDiğerDetay.TabIndex = 29;
            this.btnDiğerDetay.Text = "Diğer Detaylar";
            this.btnDiğerDetay.UseVisualStyleBackColor = true;
            this.btnDiğerDetay.Click += new System.EventHandler(this.KullanıcıDetaylarınıAç);
            // 
            // btnResim
            // 
            this.btnResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.Location = new System.Drawing.Point(12, 251);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(250, 34);
            this.btnResim.TabIndex = 30;
            this.btnResim.Text = "Resim Eklemek için Tıklayın...";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.ResimSeç);
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(424, 82);
            this.mtxtTel.Mask = "\\0(599) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(297, 29);
            this.mtxtTel.TabIndex = 31;
            // 
            // dtDTarih
            // 
            this.dtDTarih.Location = new System.Drawing.Point(424, 117);
            this.dtDTarih.Name = "dtDTarih";
            this.dtDTarih.Size = new System.Drawing.Size(297, 29);
            this.dtDTarih.TabIndex = 32;
            // 
            // cbSehir
            // 
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Items.AddRange(new object[] {
            "Ankara",
            "Adıyaman",
            "Adana",
            "İzmir",
            "İstanbul",
            "Bartın",
            "Bursa",
            "Zonguldak",
            "Karabük"});
            this.cbSehir.Location = new System.Drawing.Point(424, 152);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(297, 32);
            this.cbSehir.TabIndex = 33;
            // 
            // lsKan
            // 
            this.lsKan.ColumnWidth = 40;
            this.lsKan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsKan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsKan.FormattingEnabled = true;
            this.lsKan.ItemHeight = 20;
            this.lsKan.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "0+",
            "A-",
            "B-",
            "AB-",
            "0-"});
            this.lsKan.Location = new System.Drawing.Point(3, 47);
            this.lsKan.MultiColumn = true;
            this.lsKan.Name = "lsKan";
            this.lsKan.Size = new System.Drawing.Size(107, 102);
            this.lsKan.TabIndex = 34;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsKan);
            this.groupBox3.Location = new System.Drawing.Point(15, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(113, 152);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kan Grubu:";
            // 
            // lsExtra
            // 
            this.lsExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsExtra.FormattingEnabled = true;
            this.lsExtra.Items.AddRange(new object[] {
            "Bilgisayar",
            "İngilizce",
            "Ehliyet",
            "Yüzme"});
            this.lsExtra.Location = new System.Drawing.Point(3, 47);
            this.lsExtra.Name = "lsExtra";
            this.lsExtra.Size = new System.Drawing.Size(122, 102);
            this.lsExtra.TabIndex = 36;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsExtra);
            this.groupBox4.Location = new System.Drawing.Point(134, 368);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(128, 152);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Axtra Kabiliyetler:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "e-Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(424, 312);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(297, 29);
            this.txtMail.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 608);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.nmBoy);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmAğırlık);
            this.Controls.Add(this.cbSehir);
            this.Controls.Add(this.dtDTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtTel);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.btnDiğerDetay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.chkAnlaşma);
            this.Controls.Add(this.lnkAnlasma);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Kullanıcı Kayıt Formu [3.0]";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAğırlık)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBayan;
        private System.Windows.Forms.RadioButton rbBay;
        private System.Windows.Forms.NumericUpDown nmBoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmAğırlık;
        private System.Windows.Forms.LinkLabel lnkAnlasma;
        private System.Windows.Forms.CheckBox chkAnlaşma;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.Button btnDiğerDetay;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.DateTimePicker dtDTarih;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.ListBox lsKan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox lsExtra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
    }
}

