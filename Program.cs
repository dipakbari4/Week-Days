using System;

namespace Week_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week days fun!");
            Console.Write("Enter number between (1-7): ");
            int weekDay = int.Parse(Console.ReadLine());
            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Hi, It's Sunday, have fun!");
                    break;
                case 2:
                    Console.WriteLine("Too much work today, yes, it's monday. Have a nice day. :-)");
                    break;
                case 3:
                    Console.WriteLine("It's your brother's birthday. Wish him a great birthday! ");
                    break;
                case 4:
                    Console.WriteLine("It's time to have a drink today. Coffee man!");
                    break;
                case 5:
                    Console.WriteLine("Project deadline came. publish the latest package.");
                    break;
                case 6:
                    Console.WriteLine("It's weekend today. Download some web-series to enjoy it.");
                    break;
                case 7:
                    Console.WriteLine("Hey, it's Saturday, Keep calm and sleep as much as you can. :-)");
                    break;
                default:
                    Console.WriteLine("You gave wrong input");
                    break;
            }

            Console.ReadKey();
        }
    }
}
