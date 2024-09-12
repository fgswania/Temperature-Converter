namespace temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            double c;
            double f;
            value = Convert.ToInt32(txtvalue.Text);
            if (radioButton1.Checked == true)
            {
                c = (value * 1.8) + 32;
                label3.Text = c.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                f = (value - 32) * (.555);
                label3.Text = f.ToString();
            }
            else
            {
                MessageBox.Show("please select an option");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
