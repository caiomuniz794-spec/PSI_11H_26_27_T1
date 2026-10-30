using System;
using System.Xml;


class program
{

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Numero 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Operação (+, -, *, /)");
            string op = Console.ReadLine().Trim();
            Console.WriteLine("Numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine($"A soma de {num1} + {num2} é igual a {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"A subtração de {num1} - {num2} é igual a {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"A Mutiplicação de {num1} * {num2} é igual a {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"A divisão de {num1} / {num2} é igual a {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Operação invertida!");
                    break;
            }

            Console.ReadKey();
            Console.Clear();

        }

    }
}