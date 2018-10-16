using System.Data.SqlClient;
using System.Threading.Tasks;
using Wagram.CommonLibraries.Interfaces.Sql;
using Wagram.CommonLibraries.Sql.SqlServer.Infrastructure.Configuration;

namespace Wagram.CommonLibraries.Sql.SqlServer.Infrastructure.Commands
{
    public abstract class CommandBase<TArgs> : ICommand<TArgs>
        where TArgs : IArgs
    {
        private readonly IConnectionFactory<SqlConnection> _connectionFactory;

        public CommandBase(IConnectionFactory<SqlConnection> connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task ExecuteAsync(TArgs args)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                await ExecuteAsync(args, connection);
            }
        }

        protected abstract Task ExecuteAsync(TArgs args, SqlConnection connection);
    }
}