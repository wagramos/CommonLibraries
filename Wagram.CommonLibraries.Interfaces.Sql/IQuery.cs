namespace Wagram.CommonLibraries.Interfaces.Sql
{
    public interface IQuery<TArgs, TResult>
        where TArgs : IArgs
    {
         TResult Get(TArgs args);
    }
}