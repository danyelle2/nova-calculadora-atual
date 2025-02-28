using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public decimal Resultado { get; set; };
        public decimal Valor { get; set; };
        private operacao operacaoSelecionada { get; set; }

        private enum operacao
            adicao
            subtracao 
        
         switch (operacaoSelecionada)
     {
      case operacao.adicao:
        Resultado = valor + Convert.ToDecimal(txtResultado.Text);
        break


     case operacao.subtracao:
        Resultado = valor - Convert.ToDecimal(txtResultado.Text);
        break

            case operacao.multiplicacao
        Resultado = valor * Convert.ToDecimal(txtResultado.Text);
        break





       }
    txtResultado.Text = Convert.ToString(resultado);
     }
    } 
}
      
    
