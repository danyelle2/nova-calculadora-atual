namespace Calculadora_novo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                case
                    
                    operacoes.Multiplicacao:
                    resultado = valor* Convert.ToDecimal(textBox1.Text);
                    break;

                case operacoes.Divisao:
                    if (Convert.ToDecimal (textBox1.Text) == 0)// se e senão (se o valor for igual a zero não dividir)
                    {
                        textBox1.Text = "ERRO!!\n Não é possivel dividir o número 0";
                    }
                    else
                    {
                        resultado = valor / Convert.ToDecimal(textBox1.Text);
                    }

            }
    }
}
