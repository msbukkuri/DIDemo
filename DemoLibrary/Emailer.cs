using System;

namespace DemoLibrary
{
    public class Emailer
    {
        public void SendEmail(IPerson owner, string message)
        {
            Console.WriteLine($"Simulating sending an email to { owner.EmailAddress }");
        }
    }
}