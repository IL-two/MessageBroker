using System;

namespace MessageBrokerSolution
{
    public interface ISubscriber
    {
        string Name { get; set; }

        Action<MessageEvent> MessageRecieve { get; set; }
    }
}
