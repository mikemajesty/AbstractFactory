using TrabalhoMarcelo.AbstractMethod.Contract;
using TrabalhoMarcelo.AbstractMethod.Impl;
using static System.Console;

namespace TrabalhoMarcelo.AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataBaseFactory factory = new SqlServerFactory();

            IConnection sqlCon = factory.createConnection();
            sqlCon.Open();

            ICommand sqlCommand = factory.createCommand();
            sqlCommand.Execute();

            IDataTable sqlTable = factory.createConverter();
            sqlTable.Convert();

            ReadKey();
        }
    }
}
