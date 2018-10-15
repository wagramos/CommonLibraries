using System.Collections.Generic;
using System.Threading.Tasks;
using Wagram.CommonLibraries.Interfaces.Messaging.Entities;

namespace Wagram.CommonLibraries.Interfaces.Messaging.Publishing
{
    public interface IPublisher
    {
        Task PublishAsync<T>(IPublishMessage<T> messageToPublish);
        Task PublishBatchAsync<T>(IEnumerable<T> messagesToPublish);
    }
}