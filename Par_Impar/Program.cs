﻿internal class Program
{
    private static void Main(string[] args)
    {
        int x;

        Console.WriteLine("Informe um número: ");
        x = int.Parse(Console.ReadLine());

        if (x % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}