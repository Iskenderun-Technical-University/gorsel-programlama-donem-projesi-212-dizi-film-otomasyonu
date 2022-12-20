using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /*SqlConnection baglanti = new SqlConnection("Data Source=SEMIHBAŞER\\SQLEXPRESS;Initial Catalog=DiziFilmListe;Integrated Security=True");*/

        
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.dataGridView1.Rows.Add(txtDiziAdi.Text, cmbDiziTuru.Text, txtDurum.Text, txtPlatform.Text, dateTimePicker1.Text);
            frm2.Show();
            this.Hide();



        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}