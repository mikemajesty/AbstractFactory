using System;

namespace TrabalhoMarcelo.AbstractMethod.Impl
{
    public class SqlServerConnection : IConnection
    {
        public void Open()
        {
            Console.WriteLine("SQL Server: " + nameof(Open));
        }
    }
}
