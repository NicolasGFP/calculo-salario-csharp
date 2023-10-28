using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2
{
    internal class Program
    {
        public static void reajuste(string nome, double salario, double percentual)
        {   
            double salarioAtual = salario + (salario * percentual) / 100;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("             TABELA DE REAJUSTE SALARIAL");
            Console.WriteLine("-------------------------------------------------------\n");

            Console.WriteLine(" Funcionário: {0}", nome);
            Console.WriteLine("\n Salário Antigo: [{0}]", salario);
            Console.WriteLine("\n Salário Atual com reajuste de [{0}%]: [{1}]", percentual, salarioAtual);

            Console.WriteLine("\n-------------------------------------------------------\n");
        }
        static void Main(string[] args)
        {
            string nome;
            double salario;
            double percentual;

            Console.Write("Escreva o nome do funcionário: ");
            nome = Console.ReadLine();

            Console.Write("\nEscreva o salário do funcionário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEscreva o percentual do funcionário: ");
            percentual = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            reajuste(nome, salario, percentual);

            Console.Write("Aperte Enter para finalizar... ");
            Console.ReadLine();
        }
    }
}
