using System;

namespace TrabalhoMarcelo.Recursivo.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Digite um número");
                var number = Convert.ToInt32(Console.ReadLine());
                Fibonacci(0, 1, 1, number);
                Console.ReadKey();
        }
        public static void Fibonacci(int valor1, int valor2, int contador, int numero)
        {
            Console.WriteLine(valor1);
            if (contador < numero)
                Fibonacci(valor2, valor1 + valor2, contador + 1, numero);
        }
    }
}
