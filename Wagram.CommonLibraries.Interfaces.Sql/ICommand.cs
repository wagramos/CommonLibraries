using System.Threading.Tasks;

namespace Wagram.CommonLibraries.Interfaces.Sql
{
    public interface ICommand<TArg>
        where TArg : IArgs
    {
         Task ExecuteAsync(TArg arg);
    }

    public interface ICommand<TArg, TResult>

        where TArg : IArgs
    {
         Task<TResult> ExecuteAsync(TArg arg);
    }

}