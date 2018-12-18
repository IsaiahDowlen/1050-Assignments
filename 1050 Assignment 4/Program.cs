namespace _1050_Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageFromComputer("Please complete your order.");           
            System.Console.WriteLine("Press any key to continue...");
            string input = System.Console.ReadLine();
            int childtickets;
            int adulttickets;
            int seniortickets;
            double totalticketcost = 0;
            double totalconcessioncost = 0;
            MessageFromComputer("How many child tickets?");
            childtickets = int.Parse(System.Console.ReadLine());
            MessageFromComputer("How many Adult Tickets?");
            adulttickets = int.Parse(System.Console.ReadLine());
            MessageFromComputer("How many Senior Tickets?");
            seniortickets = int.Parse(System.Console.ReadLine());
            MessageFromComputer("Would you like the Matinee or the Evening movie? (Matinee/Evening)");
            string movieTime = System.Console.ReadLine();

            if (movieTime == "Matinee")
            {
                System.Console.WriteLine("You have selected Matinee.");
                double childPrice = 3.99;
                double adultPrice = 5.99;
                double seniorPrice = 4.50;
                totalticketcost += childtickets * childPrice;
                totalticketcost += adulttickets * adultPrice;
                totalticketcost += seniortickets * seniorPrice;
            }
            else if (movieTime == "Evening")
            {
                MessageFromComputer("You have selected Evening.");
                double childPrice = 6.99;
                double adultPrice = 10.99;
                double seniorPrice = 8.50;
                totalticketcost += childtickets * childPrice;
                totalticketcost += adulttickets * adultPrice;
                totalticketcost += seniortickets * seniorPrice;
            }
            else
            {
                MessageFromComputer("Evening showing.");
            }
            int totalTicketCount = childtickets + adulttickets + seniortickets;
            double smallsodacost = 3.50;
            double largesodacost = 5.99;
            double hotdogcost = 3.99;
            double popcorncost = 4.50;
            double candycost = 1.99;
            int smallsodaCount = 0;
            int largesodaCount = 0;
            int hotdogCount = 0;
            int popcornCount = 0;
            int candyCount = 0;

            System.Console.WriteLine("");
            MessageFromComputer("Number of Small Sodas?");
            smallsodaCount = int.Parse(System.Console.ReadLine());
            MessageFromComputer("Number of Large Sodas?");
            largesodaCount = int.Parse(System.Console.ReadLine());
            MessageFromComputer("Number of Hotdogs?");
            hotdogCount = int.Parse(System.Console.ReadLine());
            MessageFromComputer("Number of Popcorn?");
            popcornCount = int.Parse(System.Console.ReadLine());
            MessageFromComputer("Number of Candy?");
            candyCount = int.Parse(System.Console.ReadLine());

            totalconcessioncost += smallsodaCount * smallsodacost;
            totalconcessioncost += largesodaCount * largesodacost;
            totalconcessioncost += hotdogCount * hotdogcost;
            totalconcessioncost += popcornCount * popcorncost;
            totalconcessioncost += candyCount * candycost;

            double firstDiscount = 0;
            double secondDiscount = 0;
            double thirdDiscount = 0;

            if (popcornCount >= 1 && largesodaCount >= 1 && totalTicketCount >= 1)
            {
                if (popcornCount <= largesodaCount && popcornCount <= totalTicketCount)
                {
                    firstDiscount = 2 * popcornCount;
                }
                else if (largesodaCount <= popcornCount && largesodaCount <= totalTicketCount)
                {
                    firstDiscount = 2 * largesodaCount;
                }
                else
                {
                    firstDiscount = 2 * totalTicketCount;
                }
            }
            if (totalTicketCount >= 3)
            {
                if (movieTime == "2")
                {
                    if (popcornCount >= 1)
                    {
                        secondDiscount = 4.50;
                    }
                }
            }
            if (candyCount >= 4)
            {
                thirdDiscount = (candyCount / 4) * 1.99;
            }
            double discountAmount = firstDiscount + secondDiscount + thirdDiscount;
            double totalcost = (totalticketcost + totalconcessioncost) - discountAmount;

            System.Console.WriteLine("");
            MessageFromComputer("Your total cost is: $" + totalcost);
            System.Console.WriteLine("");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
        private static void MessageFromComputer(string text)
        {
            System.Console.WriteLine();
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            System.Console.WriteLine(" " + text);
            System.Console.WriteLine();
            System.Console.Write(" ");
            System.Console.ResetColor();
        }
    }
}
