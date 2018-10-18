using System.Data.SqlClient;
using Wagram.CommonLibraries.Interfaces.Sql;
using Wagram.CommonLibraries.Sql.SqlServer.Infrastructure.Configuration;

namespace Wagram.CommonLibraries.Sql.SqlServer.Infrastructure.Factories
{
    public class SqlConnectionFactory : IConnectionFactory<SqlConnection>
    {
        private readonly ISqlConfiguration _sqlConfiguration;

        public SqlConnectionFactory(ISqlConfiguration sqlConnection)
        {
            _sqlConfiguration = sqlConnection;
        }
        public SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(_sqlConfiguration.ConnectionString);

            connection.Open();

            return connection;
        }
    }
}