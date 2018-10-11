namespace _1050_Assignment_1
{
    class Program
    {
        private static int inchesInFeet;

        static void Main(string[] args)
        {
            #region Part1
            System.Console.Write("First Name : ");
            string firstName = System.Console.ReadLine();

            System.Console.Write("Middle Initial : ");
            string middleInitial = System.Console.ReadLine();

            System.Console.Write("Last Name : ");
            string lastName = System.Console.ReadLine();

            System.Console.Write("Full Name : ");
            string fullName = System.Console.ReadLine();
            #endregion

            #region Part2
            const double multiplier = 2.54;

            System.Console.Write("Height In Feet : ");
            int heightInFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Height In Inches : ");
            double heightInInches = double.Parse(System.Console.ReadLine());

            int inches = inchesInFeet * heightInFeet;

            double centimeters = inches * multiplier;

            System.Console.WriteLine(centimeters);

            System.Console.Write("Total Height In Centimeters : ");
            System.Console.ReadLine();
            #endregion


            #region Part3

            System.Console.Write("How old are you? : ");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you American Citizen : ");
            bool isCitizen = bool.Parse(System.Console.ReadLine());

            System.Console.Write("Can you vote? : ");
            bool canVote = age > 17 && isCitizen;
            System.Console.ReadLine();
        
            #endregion
        }
    }
}
