using Microsoft.Data.SqlClient;
using System.Data;

public class DapperDBContext
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public DapperDBContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    public IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);
}
