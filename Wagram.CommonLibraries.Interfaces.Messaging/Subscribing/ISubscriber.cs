using System;
using System.Threading.Tasks;
using Wagram.CommonLibraries.Interfaces.Messaging.Entities;

namespace Wagram.CommonLibraries.Interfaces.Messaging.Subscribing
{
    public interface ISubscriber
    {
         Task Subscribe<TMessageType>(string subscriptionName, Func<Task<IMessage<TMessageType>>> action);
    }
}