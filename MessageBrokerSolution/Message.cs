namespace MessageBrokerSolution
{
    public class Message : IMessage
    {
        public string Body { get; set; }

        public Message (string message)
        {
            Body = message;
        }
    }
}
