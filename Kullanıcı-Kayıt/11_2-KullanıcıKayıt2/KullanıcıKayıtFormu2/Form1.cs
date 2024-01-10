using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıKayıtFormu2
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
        private object toolTip1;

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

            btnTamam.Enabled = chkAnlaşma.Checked;

            if (chkAnlaşma.Checked == true)
            {
                MessageBox.Show("Anlaşma kabul edilmiştir.");
            }
            else
            {
                MessageBox.Show("Anlaşmayı kabul etmediniz.");
            }




        }

        private void AnlaşmaMetniniAç(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://myo.bartin.edu.tr");
        }

        private void ResimSeç(object sender, EventArgs e)
        {
            string dosya = "";

            OpenFileDialog fd = new OpenFileDialog() { Filter = "Resim Dosyaları|*.jpg;*.png;*.bmp;*.txt" };
            if(fd.ShowDialog()== DialogResult.OK)
            {
                dosya = fd.FileName;
            }

            try
            {
                pictureBox1.Load(dosya);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu");
                pictureBox1.Image = SystemIcons.Error.ToBitmap();
            }
            finally
            {

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;


            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;



        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            maskedTextBox1.Mask = "00/00/0000";

            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            maskedTextBox1.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);


        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();
            //    toolTip1.Hide(maskedTextBox1);
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || maskedTextBox1.Text == "" || textBox5.Text == "" || dateTimePicker1.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜM BİLGİLERİ DOLDURUNUZ");
            }
            else
                MessageBox.Show("Kayıt Başarılı");


        }
    }
}
