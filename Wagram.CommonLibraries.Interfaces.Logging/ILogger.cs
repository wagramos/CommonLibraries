using System;
using System.Threading.Tasks;

namespace Wagram.CommonLibraries.Interfaces.Logging
{
    public interface ILogger
    {
         Task LogInfoAsync(string contextName, string message, string correlationId); 
         Task LogWarningAsync(string contextName, string message, string correlationId);
         Task LogErrorAsync(string contextName, string message, string correlationId, Exception ex); 
    }
}