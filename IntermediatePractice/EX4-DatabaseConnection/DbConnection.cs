namespace EX4_DatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }
        public DateTime Start { get; set; }
        public DbConnection(string connectionString)
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                ConnectionString = connectionString;
            }
            else
                throw new ArgumentException("Invalid Connection String");
        }

        public string Open()
        {
            Start = DateTime.Now;
            var result = OpenConnection();
            TimeOut = DateTime.Now - Start;

            if (TimeOut > TimeSpan.FromSeconds(10))
                throw new Exception("Time Exceeded");
            else
                return result;
            
        }
        public abstract string OpenConnection();
        public abstract string Close();
    }
}
