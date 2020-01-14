using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ryan";
            string location = "Rexburg, Idaho";

            System.Console.WriteLine($"My name is {name}");
            System.Console.WriteLine($"I am in {location}");
            System.DateTime today = System.DateTime.Now;
            System.Console.WriteLine($"Today is: {today.ToString("MM/dd/yyyy")}");
            System.DateTime christmas = new System.DateTime(2020, 12, 25);
            System.Console.WriteLine($"There are {((System.TimeSpan)(christmas - today)).Days} days until Christmas! Wohoo!");

            // 2.1 From the Yellow Book (With appropriate changes made)
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Enter Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square meters");

            // End of Example from Book


            System.Console.ReadLine();
        }
    }
}