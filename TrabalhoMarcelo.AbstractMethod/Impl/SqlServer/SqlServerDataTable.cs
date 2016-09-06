using System;

namespace TrabalhoMarcelo.AbstractMethod.Impl
{
    public class SqlServerDataTable : IDataTable
    {
        public void Convert()
        {
            Console.WriteLine("SQL Server: " + nameof(Convert));
        }
    }
}
