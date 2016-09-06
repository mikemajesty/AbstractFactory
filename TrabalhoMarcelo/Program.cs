using System;

namespace TrabalhoMarcelo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] names = { 2, 3, 8, 1, 9,6 };

            Console.WriteLine("Antes");

            Array.ForEach(names, c =>
            {
                Console.WriteLine(c);
            });

            for (int i = 0; i < names.Length; i++)
            {
                var x = names[i];
                var j = i;
                while (j > 0 && names[j - 1].CompareTo(x) > 0)
                {
                    names[j] = names[j - 1];
                    j = j - 1;
                }
                names[j] = x;
            }

            Console.WriteLine("Depois");
            Array.ForEach(names, c => 
            {
                Console.WriteLine(c);
            });

            Console.ReadKey();
        }
    }
}
