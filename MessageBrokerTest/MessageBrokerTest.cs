using MessageBrokerSolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MessageBrokerTest
{
    [TestClass]
    public class MessageBrokerTest
    {
        [TestMethod]
        public void TestPost_For_3_subscribers()
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

            Assert.AreEqual(message.Body, subscriber1.Message);
        }

        [TestMethod]
        public void Test_Subscribe_Unsubscribe()
        {
            Broker broker = new Broker();

            Subscriber subscriber1 = new Subscriber("subscriber1");
            Subscriber subscriber2 = new Subscriber("subscriber2");
            Subscriber subscriber3 = new Subscriber("subscriber3");

            Message message = new Message("Hallo!");

            broker.Subscribe(subscriber1);
            broker.Subscribe(subscriber2);
            broker.Subscribe(subscriber3);

            broker.Unsubscribe(subscriber1);
            broker.Unsubscribe(subscriber3);

            broker.Post(message);

            Assert.AreEqual(null, subscriber1.Message);
        }
    }
}
