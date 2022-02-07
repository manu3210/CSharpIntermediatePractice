namespace EX4_DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }
        public override string Close()
        {
            return "Sql Connection was closed";
        }

        public override string OpenConnection()
        {
            Thread.Sleep(11000);
            return "Sql Connection was opened";
        }
    }
}
