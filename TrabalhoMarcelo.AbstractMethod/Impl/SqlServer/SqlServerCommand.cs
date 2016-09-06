using System;

namespace TrabalhoMarcelo.AbstractMethod.Impl
{
    public class SqlServerCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("SQL Server: " + nameof(Execute));

        }
    }
}
