using System.Threading.Tasks;

namespace Wagram.CommonLibraries.Interfaces.Sql
{
    public interface IQuery<TArgs, TResult>
        where TArgs : IArgs
    {
         Task<TResult> GetAsync(TArgs args);
    }
}