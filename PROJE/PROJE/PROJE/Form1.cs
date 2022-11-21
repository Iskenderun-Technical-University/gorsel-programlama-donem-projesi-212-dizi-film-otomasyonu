namespace PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add (textBox1.Text+ " - " + textBox2.Text );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Text = (textBox5.Text + comboBox1.Text + textBox3.Text + comboBox2.Text + textBox4.Text);
        }
    }
}