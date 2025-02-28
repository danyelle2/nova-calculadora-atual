namespace Calculadora_novo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDisplay("");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddDisplay("");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = ",";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDisplay("");


        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "=";
        }
        private void AddDisplay(string number)
        {
            textBox1.Text = textBox1.Text + number;
        }
        private void buttonlimpar_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddDisplay("1");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddDisplay("2");
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            AddDisplay("3");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddDisplay("4");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddDisplay("5");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddDisplay("6");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AddDisplay("7");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AddDisplay("8");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            AddDisplay("9");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AddDisplay("0");
        }
    }
}
