using System.Data;

namespace Wagram.CommonLibraries.Interfaces.Sql
{
    public interface IConnectionFactory<T>
        where T : IDbConnection
    {
         T CreateConnection();
    }
}