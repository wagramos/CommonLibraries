using System.Data.SqlClient;
using System.Threading.Tasks;
using Wagram.CommonLibraries.Interfaces.Sql;
using Wagram.CommonLibraries.Sql.SqlServer.Infrastructure.Configuration;

namespace Wagram.CommonLibraries.Sql.SqlServer.Infrastructure.Queries
{
    public abstract class QueryBase<TArgs, TResult> : IQuery<TArgs, TResult>
        where TArgs : IArgs
    {
        private readonly IConnectionFactory<SqlConnection> _connectionFactory;

        public QueryBase(IConnectionFactory<SqlConnection> connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<TResult> GetAsync(TArgs args)
        {
            TResult result;
            using (var connection = _connectionFactory.CreateConnection())
            {
                result = await GetAsync(args, connection);
            }

            return result;
        }
        
        protected abstract Task<TResult> GetAsync(TArgs args, SqlConnection connection);
    }
}