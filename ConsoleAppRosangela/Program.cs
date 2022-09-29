using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRosangela
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine(" ****** Programa da Rosangela ****** \n\n");
            Console.WriteLine(" --- Soma de dois Números --- \n\n");

            Console.WriteLine("Informe um número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado: {num1+num2}");


            Console.ReadLine();
        }
    }
}
