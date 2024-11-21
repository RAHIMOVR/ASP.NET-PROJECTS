namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text += "0";
            }
        }

        private void Dot_Click_1(object sender, EventArgs e)
        {
            if(!TextBox.Text.Contains("."))
            {
                TextBox.Text += ".";
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text += "1";
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {

        }

        private void Three_Click(object sender, EventArgs e)
        {

        }

        private void Four_Click(object sender, EventArgs e)
        {

        }

        private void Five_Click(object sender, EventArgs e)
        {

        }

        private void Six_Click(object sender, EventArgs e)
        {

        }

        private void Seven_Click(object sender, EventArgs e)
        {

        }

        private void Eight_Click(object sender, EventArgs e)
        {

        }

        private void Nine_Click(object sender, EventArgs e)
        {

        }
        private void Equal_Click(object sender, EventArgs e)
        {

        }
    }
}
