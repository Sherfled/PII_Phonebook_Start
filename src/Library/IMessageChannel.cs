namespace Library
{
    public interface IMessageChannel
    {
        void SendWPP(Message message, string names, string text);
        void SendEmail(Message message, string[] names, string text);
    }
}