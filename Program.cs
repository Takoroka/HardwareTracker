using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HardwareTracker
{
    internal class Program
    {
        // thing that controls everything
        class Hardware
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public DateTime DateAdded { get; set; }

            public override string ToString()
            {
                // make sure not spelled wrong if theres an error check here
                return $"Name: {Name}, Category: {Category}, Added On: {DateAdded:MM-dd-yyyy}";
            }
        }

        // should find hardware stuff
        static List<Hardware> hardwareList = new List<Hardware>();

        // Some reason doesn't like that args is being used... its 12am. I'm not going to look deep into it
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                // Main Page,
                Console.Clear();
                Console.WriteLine("Test");
                Console.WriteLine("1. Add Hardware");
                Console.WriteLine("2. View Hardware");
                Console.WriteLine("3. Exit");
                Console.Write("This should display at the top");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddHardware();
                        break;
                    case "2":
                        ViewHardware();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("fuck you");
                        break;
                    default:
                        Console.WriteLine("Invalid.");
                        Console.ReadKey();
                        break;
                }
            }

        }
        // Creates Hardware
        static void AddHardware()
        {
            Console.Clear();
            Console.WriteLine("Create Hardware");

            Console.Write("Enter hardware name: ");
            string name = Console.ReadLine();

            Console.Write("Enter category: ");
            string category = Console.ReadLine();

            Hardware newHardware = new Hardware
            {
                Name = name,
                Category = category,
                DateAdded = DateTime.Now
            };

            hardwareList.Add(newHardware);
            Console.WriteLine("Hardware added successfully! Press any to return to menu");
            Console.ReadKey();
        }

        // view the stuff 
        static void ViewHardware()
        {
            Console.Clear();
            Console.WriteLine(" View the stuff");

            if (hardwareList.Count == 0)
            {
                Console.WriteLine("null");
            }
            else
            {
                foreach (var hardware in hardwareList)
                {
                    Console.WriteLine(hardware);
                }
            }
            // returns to menu
            Console.WriteLine("\nInput to return to menu.");
            Console.ReadKey();
        }
    }
}
// code was simple but i dont feel like testing it so i will upload to github and look back at it later.