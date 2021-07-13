using System;

namespace DemoLibrary
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating a text message to { person.FirstName } by saying { message }");
        }
    }
}
