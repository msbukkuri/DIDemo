using System;
using DemoLibrary;

namespace DIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var owner = Factory.CreatePerson();
            owner.FirstName = "Maanas";
            owner.LastName = "Bukkuri";
            owner.EmailAddress = "msbukkuri@gmail.com";
            owner.PhoneNumber = "555-1234";

            var chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash"; 
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
