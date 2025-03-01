namespace Calculadora_novo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declarei a variaveis em propriedades get recupera/atibui o valor  e set define o valor da variavel
        private Operacoes operacaoAtual { get; set; }
        private decimal valor { get; set; }
        private decimal resultado { get; set; }

        //criei um enum para nomear e definir as operacoes
        private enum Operacoes
        {

            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
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
            AddDisplay(",");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDisplay("");


        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            textBox1.Text = "=";
        }
        // Fórmula para adicionar o numero no display
        private void AddDisplay(string number)
        {
            textBox1.Text = textBox1.Text + number;
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

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = (",");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            // Switch Fórmula para adicionar o numero no display quando apertar o botao de igual 
            switch (operacaoAtual) { 
            case Operacoes.Adicao:
                    resultado = valor + Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacoes.Subtracao:
                    resultado = valor - Convert.ToDecimal(textBox1.Text);
                    break;
                case
                    Operacoes.Multiplicacao:
                    resultado = valor* Convert.ToDecimal(textBox1.Text);
                    break;
                case 
                    Operacoes.Divisao:
                    if (Convert.ToDecimal (textBox1.Text) == 0)// se e senão (se o valor for igual a zero não dividir)
                    {
                        textBox1.Text = "ERRO!!\n Não é possivel dividir o número 0";
                    }
                    else
                    {
                        resultado = valor / Convert.ToDecimal(textBox1.Text);
                    }
                        break;
            }
            
           // para aparecer o resultado na tela
            textBox1.Text = Convert.ToString(resultado);
        }

        private void button14_Click(object sender, EventArgs e)
        {

            operacaoAtual = Operacoes.Multiplicacao;
            valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

            operacaoAtual = Operacoes.Divisao;
            valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            operacaoAtual = Operacoes.Subtracao;
            valor = Convert.ToDecimal(textBox1.Text);// Estou atribuindo o valor do texto a variavel valor da formula
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacaoAtual = Operacoes.Adicao;
            valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";

        }
 


 
    }
}