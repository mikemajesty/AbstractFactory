using System;
using TrabalhoMarcelo.AbstractMethod.Contract;

namespace TrabalhoMarcelo.AbstractMethod.Impl
{
    public class SqlServerFactory : IDataBaseFactory
    {
        public ICommand createCommand()
        {
            return new SqlServerCommand();
        }

        public IConnection createConnection()
        {
            return new SqlServerConnection();
        }

        public IDataTable createConverter()
        {
            return new SqlServerDataTable();
        }
    }
}
