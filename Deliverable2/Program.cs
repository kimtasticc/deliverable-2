// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main(string[] args)
    {
        double BUFFET_PRICE = 9.99;
        double GINGER_ALE_PRICE = 2.50;
        double LEMONADE_PRICE = 1.99;

        int tableSize;
        int guestNumber = 1;
        string guestNumberOrder;
        int totalOrderedGingerAle = 0;
        int totalOrderedLemonade = 0;
        double totalLemonade;
        double totalGingerAle;
        double totalBuffet;
        double totalPrice;
        bool KimBuffet = true;

        Console.WriteLine("Welcome to Kim's Breakfast Buffet!");

        Console.WriteLine("How many are dining with us today?");
        tableSize = int.Parse(Console.ReadLine());
        if (tableSize > 6)
        {
            Console.WriteLine("I'm sorry, we aren't accepting parties larger than 6 at this time.");
            KimBuffet = false;
        }
        else
        {
            Console.WriteLine("Awesome! We have a table available for " + tableSize + " right this way. Please take a seat.");
            Console.WriteLine("Let me get you started with some drinks. Today we have Ginger Ale for $2.50 or Lemonade for $1.99.");

            
            while (guestNumber <= tableSize)
            {
                Console.WriteLine("Guest " + guestNumber + ", which drink would you like?");
                guestNumber++;
                guestNumberOrder = Console.ReadLine();

                if (guestNumberOrder == "Lemonade" || guestNumberOrder == "lemonade")
                {
                    Console.WriteLine("One lemonade, got it!");
                    totalOrderedLemonade++;
                }
                else if (guestNumberOrder == "Ginger Ale" || guestNumberOrder == "ginger ale")
                {
                    Console.WriteLine("One ginger ale, got it!");
                    totalOrderedGingerAle++;
                }
                else
                {
                    Console.WriteLine("Bummer, that drink isn't being offered today. Moving on.");
                }
            }

            Console.WriteLine("Alright! That's " + totalOrderedGingerAle + " ginger ales and " + totalOrderedLemonade + " lemonades. I will be back in just a minute with those. In the meantime, our buffet is located right over there.");

            totalGingerAle = totalOrderedGingerAle * GINGER_ALE_PRICE;
            totalLemonade = totalOrderedLemonade * LEMONADE_PRICE;
            totalBuffet = tableSize * BUFFET_PRICE;
            totalPrice = totalGingerAle + totalLemonade + totalBuffet;
            decimal bill = decimal.Round((decimal)totalPrice, 2, MidpointRounding.AwayFromZero);
            
            Console.WriteLine("Here are your drinks and your bill. There's no rush on this. Your total today will be: $" + bill);
        }
    }
}