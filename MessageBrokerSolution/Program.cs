using System;

namespace MessageBrokerSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Broker broker = new Broker();

            Subscriber subscriber1 = new Subscriber("subscriber1");
            Subscriber subscriber2 = new Subscriber("subscriber2");
            Subscriber subscriber3 = new Subscriber("subscriber3");

            Message message = new Message("Hallo!");

            broker.Subscribe(subscriber1);
            broker.Subscribe(subscriber2);
            broker.Subscribe(subscriber3);

            broker.Post(message);

            Console.ReadLine();
        }
    }
}
