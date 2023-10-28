using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula8 // Area de trabalho
{
    internal class Program
    {
        public static int adicionar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args) // Main = método construtor
        {
            int opcao;
            int num1 ;
            int num2 ;

            Console.Write("Escreva o valor do número 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEscreva o valor do número 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            /*
             * soma(2, 5);
             * soma(77, 51); -> Desta forma não é precisso repetir as somas para criar varias vezes :D
             * soma(6, 2);
            */

            Console.WriteLine("\nQual operação você gostaria de realizar?: \n");
            Console.WriteLine("[1] - somar");
            Console.WriteLine("[2] - subtrair");
            Console.WriteLine("[3] - multiplicar");
            Console.WriteLine("[4] - dividir\n");
            Console.Write("Opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            while(opcao <= 0 || opcao > 4)
            {
                Console.Write("\nEscolha uma opção dentro da tabela: ");
                opcao = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("O resultado foi: [{0}]", adicionar(num1, num2));
                break;
                    
                case 2:
                    Console.WriteLine("O resultado foi: [{0}]", subtrair(num1, num2));
                break;

                case 3:
                    Console.WriteLine("O resultado foi: [{0}]", multiplicar(num1, num2));
                break;

                case 4:
                    Console.WriteLine("O resultado foi: [{0}]", dividir(num1, num2));
                break;
            }

            Console.Write("\nAperte enter para finalizar... ");
            Console.ReadLine();
        }
    }
}