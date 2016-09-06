using System;

namespace TrabalhoMarcelo.AbstractMethod.Impl
{
    public class OracleDataTable : IDataTable
    {
        public void Convert()
        {
            Console.WriteLine("Oracle: " + nameof(Convert));
        }
    }
}
