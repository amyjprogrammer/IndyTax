using System;

namespace IndyTax
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInfo();
            GetPrice();
           
        }

        static void AppInfo()
        {
            //app vars
            string version = "1.0.0";
            string creatorName = "Amy Jones";
            string stateName = "Indiana";

            Console.WriteLine("Version: {0}. This app was created by {1} to figure out the price with tax for {2}", version, creatorName, stateName);
        }

        static void GetPrice()
        {
            //get price from user
            Console.WriteLine("Please enter the price for the item before tax: ");

            string priceString = Console.ReadLine();
        
            float checkNum;

            
            if (!float.TryParse(priceString, out checkNum))
            {
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("Please enter a number");
                 Console.ResetColor();
            }

            else
            {
                float priceInfo = float.Parse(priceString);
                Console.WriteLine("You entered ${0:0.00} as the price.", priceInfo);

                var fullPrice = priceInfo * 1.07;
                Console.WriteLine("The price with taxes in Indiana is ${0:0.00}.", fullPrice);
            }

        }

    }
}
