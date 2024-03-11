using System;

namespace TesteEstagio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sequencia = double.Parse(Console.ReadLine());

            if (EFibonacci(sequencia))
            {
                Console.WriteLine($"{sequencia} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{sequencia} não pertence à sequência de Fibonacci.");
            }
        }
        public static bool QuaPerfeito(double n)
        {
            double raiz;
            raiz = Math.Sqrt(n);
            return raiz * raiz == n;
        }
        public static bool EFibonacci(double n)
        {
            return QuaPerfeito(5 * n * n - 4) || QuaPerfeito(5 * n * n + 4);
        }
    }
}
