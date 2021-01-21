namespace MessageBrokerSolution
{
    public class MessageEvent
    {
        public IMessage Message { get; set; }

        public MessageEvent(IMessage message)
        {
            Message = message;
        }
    }
}
