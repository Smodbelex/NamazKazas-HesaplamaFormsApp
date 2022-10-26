namespace namazkazasihesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan fark = Convert.ToDateTime(dateTimePicker1.Text) - Convert.ToDateTime(dateTimePicker2.Value);

            int fark1 = Convert.ToInt32(fark.TotalDays);

            if ((fark1 * (-1)) == fark1) fark1 -= 1;

            else fark1 += 1;

            label3.Text = fark1.ToString();
            label19.Text = label3.Text;
            label20.Text = label3.Text;
            label21.Text = label3.Text;
            label22.Text = label3.Text;
            label23.Text = label3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label19.Text = Convert.ToString(Convert.ToInt32(label19.Text) + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label19.Text = Convert.ToString(Convert.ToInt32(label19.Text) - 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label20.Text = Convert.ToString(Convert.ToInt32(label20.Text) + 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label21.Text = Convert.ToString(Convert.ToInt32(label21.Text) + 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label22.Text = Convert.ToString(Convert.ToInt32(label22.Text) + 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label23.Text = Convert.ToString(Convert.ToInt32(label23.Text) + 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label20.Text = Convert.ToString(Convert.ToInt32(label20.Text) - 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label21.Text = Convert.ToString(Convert.ToInt32(label21.Text) - 1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label22.Text = Convert.ToString(Convert.ToInt32(label22.Text) - 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label23.Text = Convert.ToString(Convert.ToInt32(label23.Text) - 1);
        }
    }
}