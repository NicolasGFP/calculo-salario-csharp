using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    internal class Program
    {

        private static string setNome() 
        {
            Console.Write("Escreva no nome do usuario: ");
            return Console.ReadLine();
        }

        private static double setSalario()
        {
            Console.Write("Escreva o valor do salario do usuario ");
            return Convert.ToDouble(Console.ReadLine());
        }

        private static double setPercentual()
        {
            Console.Write("Escreva o valor do percentual de reajuste: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        private static double setSalarioFinal(double salarioUsuario, double percentualReajuste)
        {
            return salarioUsuario + (salarioUsuario * (percentualReajuste / 100));
        }

        static void Main(string[] args)
        {
            string nomeUsuario;
            double salarioUsuario;
            double salarioFinal;
            double percentualReajuste;
            
            nomeUsuario        = setNome();
            salarioUsuario     = setSalario();
            percentualReajuste = setPercentual();
            salarioFinal       = setSalarioFinal(salarioUsuario, percentualReajuste);

            Console.WriteLine(salarioFinal);

            Console.ReadLine();
        }
    }
}
