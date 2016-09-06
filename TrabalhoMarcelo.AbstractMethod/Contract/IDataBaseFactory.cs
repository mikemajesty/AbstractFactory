namespace TrabalhoMarcelo.AbstractMethod.Contract
{
    public interface IDataBaseFactory
    {
        IConnection createConnection();

        ICommand createCommand();

        IDataTable createConverter();
    }
}
