namespace EX4_DatabaseConnection
{
    public class DbCommand
    {
        public DbConnection Connection { get; set; }
        public string Command { get; set; }

        public DbCommand(DbConnection connection, string command)
        {
            if (connection != null && !string.IsNullOrWhiteSpace(command))
            {
                Connection = connection;
                Command = command;
            }
            else
                throw new Exception("Invalid connection or command");
        }

        public string Execute()
        {
            Console.WriteLine(Connection.Open());
            Console.WriteLine("Running command");
            Console.WriteLine(Connection.Close());

            return "Success";
        }
    }
}
