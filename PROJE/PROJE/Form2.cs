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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection("Data Source=SEMIHBAŞER\\SQLEXPRESS;Initial Catalog=DiziFilmListe;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();           
            fr3.Show();
            this.Hide();

            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
