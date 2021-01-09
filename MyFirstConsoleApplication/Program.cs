using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    class Program
    {
       
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown();
            GlazerApp.RunExample();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

        private static void GetUserNameAndLocation()
        {
            Person person = new Person();
            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();
            Console.WriteLine($"Hi, {person.name}! Where are you from?");
            person.location = Console.ReadLine();
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue.");
     
            Console.ReadKey();

        }

        private static void ChristmasCountdown()
        {
            DateTime thisDate = DateTime.Today;
            DateTime christmas = new DateTime(2021, 12, 25);
            Console.WriteLine($"Today's date is {thisDate.ToString("d")}");

            int toChristmas = (christmas - thisDate).Days;

            Console.WriteLine($"There are {toChristmas} days until Christmas!");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }
    }
}
