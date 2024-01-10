using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıKayıtFormu3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //pictureBox1.Load(@"C:\Users\bayra\Dropbox\Bu_logo.jpg");
            //pictureBox1.Image.Save(@"D:\resim1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        string Bilgiler;
        string Detaylar;
        private void KullanıcıDetaylarınıAç(object sender, EventArgs e)
        {
            Form2 f = new Form2()
            {
                Text = "Kullanıcı Detayları",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedSingle

            };

            f.ShowDialog();
            Detaylar = f.Detaylar;
        }

        private void AnlaşmaKabulu(object sender, EventArgs e)
        {
            //var c = sender as CheckBox;
            //if (c.Checked)
            //    btnTamam.Enabled = true;
            //else
            //    btnTamam.Enabled = false;

            btnTamam.Enabled = chkAnlaşma.Checked;



            if (chkAnlaşma.Checked == true)
            {
                // seçili ise burası çalışır.
                MessageBox.Show("Anlaşma kabul edilmiştir.");
            }
            else
            {
                // seçili değilse burası çalışacak.
                MessageBox.Show("Anlaşmayı kabul etmediniz.");
            }


        }

        private void AnlaşmaMetniniAç(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkAnlasma.LinkVisited = true;
            System.Diagnostics.Process.Start("http://myo.bartin.edu.tr");


        }

        private void ResimSeç(object sender, EventArgs e)
        {
            string dosya = "";

            OpenFileDialog fd = new OpenFileDialog() { Filter = "Resim Dosyaları|*.jpg;*.png;*.bmp;*.jpeg;*.gif" };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                dosya = fd.FileName;
            }

            try
            {
                pictureBox1.Load(dosya);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu");
                pictureBox1.Image = SystemIcons.Error.ToBitmap();
            }
            finally
            {

            }
        }



        private void btnTamam_Click(object sender, EventArgs e)
        {



            if (txtAd.Text == "" || txtSoyad.Text == "" || mtxtTel.Text == "" || txtAdres.Text == "" || dtDTarih.Text == "" || txtŞifre.Text == "" || cbSehir.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜM BİLGİLERİ DOLDURUNUZ");
            }
            else
                MessageBox.Show("Kayıt Başarılı");



        }

        private void KontrolEt(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (t.Text.Trim() == "")
                errorProvider1.SetError(t, "Boş bırakılamaz");
            else
                errorProvider1.SetError(t, "");
        }



        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtŞifre.Text.Length < 10)
                errorProvider1.SetError(txtŞifre, "En az 10 karakter olmalıdır.");
            else
                errorProvider1.SetError(txtŞifre, ""); // uyarıyı silmek için
    
        }



    }

}
