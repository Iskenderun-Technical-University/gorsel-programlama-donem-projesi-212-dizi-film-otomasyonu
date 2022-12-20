using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = "Senabaserr";
            string kullaniciAdi2 = "Ezgigunayy";
            string kullaniciAdi3 = "Cihanbulutt";
            int sifre = 123456789;
            int sifre2 = 123456;
            int sifre3 = 12345678;


            if (txtKullaniciAdi.Text==kullaniciAdi || txtSifre.Text==sifre.ToString())
            {
                Form2 fr = new Form2();
                fr.Show();
            }else if(txtKullaniciAdi.Text==kullaniciAdi2 || txtSifre.Text==sifre2.ToString())
            {
                Form2 fr = new Form2();
                fr.Show();
            }
            else if (txtKullaniciAdi.Text == kullaniciAdi3 || txtSifre.Text == sifre3.ToString())
            {
                Form2 fr = new Form2();
                fr.Show();
            }
            else
            {
                label9.Text = "Kullanici Adi veya Sifre Hatali !!!";
            }
            this.Hide();
        }
    }
}
