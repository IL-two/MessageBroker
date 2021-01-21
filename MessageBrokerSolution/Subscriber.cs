using System;
using System.Threading;

namespace MessageBrokerSolution
{
    public class Subscriber : ISubscriber
    {
        public string Name { get; set; }
        public Action<MessageEvent> MessageRecieve { get; set; }

        public string Message { get; set; }

        public Subscriber(string name)
        {
            this.Name = name;
            this.MessageRecieve = messageRecieve;
        }
        
        private void messageRecieve(MessageEvent obj)
        {
            this.Message = obj.Message.Body;

            //Console.WriteLine(Name);
            //Console.WriteLine("Start");
            //Console.WriteLine(Message);
            //Thread.Sleep(10000);
            //Console.WriteLine("End");
        }
    }
}
