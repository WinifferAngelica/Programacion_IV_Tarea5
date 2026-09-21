using Microsoft.Data.SqlClient;

namespace WebApi.Data;

public class DapperDB
{
    private readonly IConfiguration _configuration;

    public DapperDB(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public SqlConnection CreateConnection()
    {
        return new SqlConnection(
            _configuration.GetConnectionString("DefaultConnection")
        );
    }
}
