using static System.Console;
using static System.Convert;

namespace TrabalhoMarcelo.Factorial.Recursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Digite um número:");
            int numero =  ToInt32(ReadLine());
            WriteLine("fatorial de {0} é {1}", numero, calculaFatorial(numero));           
            ReadKey();
        }

        private static int calculaFatorial(int numero)
        {
            if (numero.Equals(0))
                return 1;
            return numero * calculaFatorial(--numero);
        }
    }
}
