using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option ");

            string input = Console.ReadLine();
            Activity activity = null;

            switch (input)
            {
                case "1": activity = new BreathingActivity(); break;
                case "2": activity = new ReflectingActivity(); break;
                case "3": activity = new ListingActivity(); break;
                case "4": return;
                default:
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    continue;
            }
            activity.Run();
            Console.WriteLine("\nPress ENTER to return to menu....");
            Console.ReadLine();
        }

        
    }
}