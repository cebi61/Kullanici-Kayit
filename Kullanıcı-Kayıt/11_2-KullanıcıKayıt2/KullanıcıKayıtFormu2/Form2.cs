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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string Detaylar = "";

        string ilgilendiğiSporlar = "";
        string kanGrubu = "";
        string takım = "";
        decimal maaş =0;
        DateTime tarih ;
        private void İlgilendiğiSporBelirle(object sender, EventArgs e)
        {
            ilgilendiğiSporlar = "";
            foreach(var ctrl in groupBox3.Controls)
            {
                var c = ctrl as CheckBox;
                if (c.Checked)
                    ilgilendiğiSporlar += "\r\n *" + c.Text;
            }

            DetayGüncelle();
        }

        private void DetayGüncelle()
        {
            Detaylar =
                $"Kan Grubu\t: {kanGrubu}\r\n" +
                $"Maaş\t\t: {maaş:C2}\r\n" +
                $"İşe Başlama Tarihi\t: {tarih:F}\r\n" +

                $"Tuttuğu Takım\t: {takım}\r\n" +
                $"İlgilendiği Sporlar\t: {ilgilendiğiSporlar}";


            textBox1.Text = Detaylar;
        }

        private void KanGrubuSeç(object sender, EventArgs e)
        {
            var r = sender as RadioButton;
            if (r.Checked)
                kanGrubu = r.Text;

            DetayGüncelle();
        }

        private void TakımSeç(object sender, EventArgs e)
        {
            var r = sender as RadioButton;
            if (r.Checked)
                takım = r.Text;

            DetayGüncelle();
        }

        private void MaaşBelirle(object sender, EventArgs e)
        {
            maaş = numericUpDown1.Value;
            DetayGüncelle();
        }

        private void İşeBaşlamaTarihiSeç(object sender, EventArgs e)
        {
            tarih = dateTimePicker1.Value;
            DetayGüncelle();
        }
    }
}
