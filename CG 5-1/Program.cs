using System;

namespace CG_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare string variable
            string firstName;
            string middleInit;
            string lastName;
            
            //Request user input of name
            Console.WriteLine("Hey You!");

            Console.Write("Tell me your first name: ");

            firstName = Console.ReadLine();

            Console.Write("Tell me your middle initial: ");

            middleInit = Console.ReadLine();

            Console.Write("Tell me your last name: ");

            lastName = Console.ReadLine();

            Console.WriteLine($"Your full name is {firstName} {middleInit} {lastName}");

            Console.ReadLine();
        }
    }
}
