using System.Collections.Generic;
using System.Threading;

namespace MessageBrokerSolution
{
    public class Broker
    {
        private List<ISubscriber> subscribers;

        public Broker()
        {
            subscribers = new List<ISubscriber>();
        }
        public void Post(IMessage message)
        {
            foreach (var item in subscribers)
            {
                if(item.MessageRecieve != null)
                {
                    ThreadStart threadStart = () => { item.MessageRecieve(new MessageEvent(message)); };
                    Thread thread = new Thread(threadStart);
                    thread.Start();
                }
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            this.subscribers.Remove(subscriber);
        }
    }
}
