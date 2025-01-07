using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace OnlineB2BStoreBackend.Domain.Db
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("BazarConnection");
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
