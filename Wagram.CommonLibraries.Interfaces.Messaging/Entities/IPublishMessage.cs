using System.Collections.Generic;

namespace Wagram.CommonLibraries.Interfaces.Messaging.Entities {
    public interface IPublishMessage<TBody> {
        string MessageId { get; }
        TBody Body { get; }
        IDictionary<string, string> Header { get; }
    }
}