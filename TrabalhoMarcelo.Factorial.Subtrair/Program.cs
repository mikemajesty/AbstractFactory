using static System.Console;
using static System.Convert;


namespace TrabalhoMarcelo.Factorial.Subtrair
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Digite um número:");
            int numero = ToInt32(ReadLine());
            subtraiNumero(numero);
            ReadKey();
        }

        private static int subtraiNumero(int numero)
        {
            if (numero <= 0 )
                return 0;
            else
            {
                int total = numero - subtraiNumero(--numero);
                WriteLine(numero);
                return total;
            }
         
            
        }
    }
}
