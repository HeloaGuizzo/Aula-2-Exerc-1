using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            int dataAtual = 2022;

            Console.WriteLine("Ano do seu Nascimento: ");
            int data = Convert.ToInt32(Console.ReadLine());

            int idade = dataAtual - data;

            Console.WriteLine("Sua idade é: " + (idade) + "anos.");
        }
    }
}