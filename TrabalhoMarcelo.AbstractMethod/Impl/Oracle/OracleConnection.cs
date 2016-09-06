using System;

namespace TrabalhoMarcelo.AbstractMethod.Impl
{
    public class OracleConnection : IConnection
    {
        public void Open()
        {
            Console.WriteLine("Oracle: " + nameof(Open));
        }
    }
}
