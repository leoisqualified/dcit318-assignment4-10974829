namespace login_screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text1 = textBox1.Text;
            String text2 = textBox2.Text;
            MessageBox.Show("Your credentials are: \nUsername: " + text1 + "\nPassword: " + text2);

        }
    }
}
