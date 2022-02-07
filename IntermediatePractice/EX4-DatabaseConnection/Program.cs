using EX4_DatabaseConnection;

DbConnection sql = new SqlConnection("DATASOURCE:MiPC\\miDB"); // or another option: var sql = new SqlConnection("DATASOURCE:MiPC\\miDB");
Console.WriteLine(sql.Open());
Console.WriteLine(sql.Close());
DbConnection oracle = new OracleConnection("DATASOURCE:MiPC\\miDB");// or another option: var oracle = new OracleConnection("DATASOURCE:MiPC\\miDB");
Console.WriteLine(oracle.Open());
Console.WriteLine(oracle.Close());