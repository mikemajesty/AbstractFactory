using TrabalhoMarcelo.AbstractMethod.Contract;

namespace TrabalhoMarcelo.AbstractMethod.Impl
{
    public class OracleFactory : IDataBaseFactory
    {
        public ICommand createCommand()
        {
            return new OracleCommand();
        }

        public IConnection createConnection()
        {
            return new OracleConnection();
        }

        public IDataTable createConverter()
        {
            return new OracleDataTable();
        }
    }
}
