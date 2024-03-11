using System;

namespace TesteEstagio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = Console.ReadLine();

            Console.WriteLine(new string(new Stack<char>(palavra).ToArray()));          
        }
    }
}