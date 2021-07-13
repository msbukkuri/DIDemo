using System;
using DemoLibrary;

namespace DIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Maanas",
                LastName = "Bukkuri",
                EmailAddress = "msbukkuri@gmail.com",
                PhoneNumber = "555-1234"
            };

            Chore chore = new Chore
            {
                ChoreName = "Take out the trash",
                Owner = owner
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
