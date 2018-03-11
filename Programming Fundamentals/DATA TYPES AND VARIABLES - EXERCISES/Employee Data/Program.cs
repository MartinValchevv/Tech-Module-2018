using System;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Amanda";
            string lastName = "Jonson";
            int age = 27;
            string gender = "f";
            long personalID = 8306112507;
            long uniqueNumber = 27563571;

            Console.WriteLine($"First name: {name}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {uniqueNumber}");

        }
    }
}
