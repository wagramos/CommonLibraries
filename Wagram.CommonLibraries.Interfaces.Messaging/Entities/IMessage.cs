using System.Collections.Generic;

namespace Wagram.CommonLibraries.Interfaces.Messaging.Entities
{
    public interface IMessage<TBody> : IPublishMessage<TBody>
    {
        bool IsDeadLetter { get; }
        void DeadLetter(string reason, string Description);
    }
}