using System;

namespace TrabalhoMarcelo.AbstractMethod.Impl
{
    public class OracleCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Oracle: " + nameof(Execute));
        }
    }
}
