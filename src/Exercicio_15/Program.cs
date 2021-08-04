using System;

namespace Exercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 15     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if (numero >= 0)
            {
                Console.WriteLine($"O número {numero} é POSITIVO.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é NEGATIVO.");
            }

            Console.ReadKey();
        }
    }
}
