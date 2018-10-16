using System.Data.SqlClient;
using System.Threading.Tasks;
using Wagram.CommonLibraries.Interfaces.Sql;
using Wagram.CommonLibraries.Sql.SqlServer.Infrastructure.Configuration;

namespace Wagram.CommonLibraries.Sql.SqlServer.Infrastructure.Commands
{
    public abstract class CommandBase<TArgs, TResult> : ICommand<TArgs, TResult>
        where TArgs : IArgs
    {
        private readonly IConnectionFactory<SqlConnection> _connectionFactory;
        public CommandBase(IConnectionFactory<SqlConnection> connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<TResult> ExecuteAsync(TArgs args)
        {
            TResult result;
            using (var connection = _connectionFactory.CreateConnection())
            {
                result = await ExecuteAsync(args, connection);
            }

            return result;
        }

        protected abstract Task<TResult> ExecuteAsync(TArgs args, SqlConnection connection);
    }
}