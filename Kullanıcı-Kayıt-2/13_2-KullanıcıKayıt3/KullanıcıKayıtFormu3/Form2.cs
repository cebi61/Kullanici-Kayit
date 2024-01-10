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
        string oprt = "";
        string meyveler = "";

        DateTime tarih ;
        private void İlgilendiğiSporBelirle(object sender, EventArgs e)
        {
            ilgilendiğiSporlar = "";
            foreach(var ctrl in groupBox3.Controls)
            {
                var c = ctrl as CheckBox;
                if (c.Checked)
                    ilgilendiğiSporlar += "\r\n * " + c.Text;
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
                $"İlgilendiği Sporlar\t: {ilgilendiğiSporlar}\r\n" +
                $"Meyve\t\t: {meyveler}\r\n" +
                $"Operatör\t\t: {oprt}";


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

        private void btnTamam_Click(object sender, EventArgs e)
        {
            bool b = false;
            foreach (var r in groupBox2.Controls)
            {
                if (((RadioButton)r).Checked)
                {
                    b = true;
                    break;
                }

            }
            if (!b)
                errorProvider1.SetError(groupBox2, "Takım seçmeniz gerekmektedir.");
            else
                errorProvider1.SetError(groupBox2, "");


            if (listBox1.SelectedItem == null)
                errorProvider1.SetError(listBox1, "Operatör seçin.");
            else
                errorProvider1.SetError(listBox1, "");
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            meyveler = "";
            foreach (var o in checkedListBox1.CheckedItems)
                meyveler += "\r\n * "+o.ToString() ;

            DetayGüncelle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            oprt = listBox1.SelectedItem.ToString();
            DetayGüncelle();
        }
    }
}
