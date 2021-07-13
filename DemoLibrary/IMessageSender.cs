namespace DemoLibrary
{
    public interface IMessageSender
    {
        void SendMessage(IPerson owner, string message);
    }
}