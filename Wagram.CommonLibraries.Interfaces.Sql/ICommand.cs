using System.Threading.Tasks;

namespace Wagram.CommonLibraries.Interfaces.Sql
{
    public interface ICommand<TArgs>
        where TArgs : IArgs
    {
         Task ExecuteAsync(TArgs args);
    }

    public interface ICommand<TArgs, TResult>
        where TArgs : IArgs
    {
         Task<TResult> ExecuteAsync(TArgs args);
    }

}