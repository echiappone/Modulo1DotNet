using System;

namespace Lista7CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;

            while (!stop)
            {
                Console.WriteLine("Calculadora\n");
                Console.WriteLine("Digite o numero que deseja calcular: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o operador: ");
                string operador = Console.ReadLine();

                Console.WriteLine("Digite o segundo número do calculo: ");
                int num2 = int.Parse(Console.ReadLine());

                switch (operador)
                {
                    case "+":
                        Console.WriteLine($"Resultado: {Somar(num1, num2)}");
                        break;

                    case "-":
                        Console.WriteLine($"Resultado: {Subtrair(num1, num2)}");
                        break;

                    case "/":
                        Console.WriteLine($"Resultado: {Dividir(num1, num2)}");
                        break;

                    case "*":
                        Console.WriteLine($"Resultado: {Multiplicar(num1, num2)}");
                        break;

                    default:
                        Console.WriteLine("Operador invalido");
                        break;
                }

                Console.WriteLine("Se deseja desligar digite 'sim', se não, digite qualquer tecla");
                string condicao = Console.ReadLine();
                if (condicao == "sim")
                {
                    stop = true;
                }
                else
                {
                    stop = false;
                }
            }
        }

        public static int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }

}