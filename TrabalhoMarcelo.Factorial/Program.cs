using static System.Console;

namespace TrabalhoMarcelo.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var other = "";
            do
            {
                WriteLine("Digite um número:");
                other = showFatorial();

            } while (other.ToUpper().Equals("S"));
           
        }

        private static string showFatorial()
        {
            string other;
            int result = 0;
            var input =  int.TryParse(ReadLine(), out result);

            if (verifyIfIsPositive(result))
            {
                var fatorial = result;
                for (int i = result - 1; i > 1; i--)
                {
                    fatorial *= i;
                }
                WriteLine(fatorial);
                
            }
            else
            {
                addSpace();
                WriteLine("Valor não é válido");
                addSpace();
            }

            WriteLine("Deseja continuar? [S/N]");
            other = ReadLine();
            return other;

        }

        private static void addSpace()
        {
            WriteLine("");
        }

        private static bool verifyIfIsPositive(int input)
        {
            return input > 0;
        }
    }
}
