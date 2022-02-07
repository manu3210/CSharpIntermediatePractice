namespace EX4_DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }
        public override string Close()
        {
            return "Oracle Connection was closed";
        }

        public override string OpenConnection()
        {
            return "Oracle Connection was opened";
        }
    }
}
