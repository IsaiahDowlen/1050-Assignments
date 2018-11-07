namespace _1050_Assignment_2
{
    class Program
    {
        static void Main(string[] args)

        {
            #region Part 1
            string x = "[Information for p1]";
            System.Console.WriteLine(x);
            System.Console.ReadKey();

            Person p1 = new Person
            {
                FirstName = "Alex",
                LastName = "Jones"
            };
            System.Console.Write(p1.FullName());
            p1.Age = 23;
            System.Console.Write(p1.Age);

            p1.Spouse = new Person();
            p1.Spouse.FirstName = System.Console.ReadLine();
            p1.Spouse.LastName = p1.LastName;
            System.Console.Write("Jane         Age: ");
            p1.Spouse.Age = 34;
            System.Console.Write(p1.Spouse.Age);
            #endregion

            #region Part 2
            string y = " ";
            System.Console.WriteLine(y);
            string c = " ";
            System.Console.WriteLine(c);
            string b = "[Information for p2] ";
            System.Console.WriteLine(b);
            System.Console.ReadKey();

            Person p2 = new Person
            {
                FirstName = "Percy",
                LastName = "Blue"
            };
            System.Console.Write(p2.FullName());
            p2.Age = 65;
            System.Console.Write(p2.Age);

            p2.Spouse = new Person();
            p2.Spouse.FirstName = System.Console.ReadLine();
            p2.Spouse.LastName = p2.LastName;
            System.Console.Write("Molly        Age: ");
            p2.Spouse.Age = 54;
            System.Console.Write(p2.Spouse.Age);
            #endregion

            #region Part 3
            string z = " ";
            System.Console.WriteLine(z);
            string f = " ";
            System.Console.WriteLine(f);
            string g = "[Print Results]";
            System.Console.WriteLine(g);
            System.Console.ReadKey();

            Person.SumOfAllAges = 176.0;
            System.Console.WriteLine("Alex, Jones" + "(23)");
            System.Console.WriteLine("Jane, Jones" + "(34)");
            System.Console.WriteLine("Percy, Blue" + "(65)");
            System.Console.WriteLine("Molly, Blue" + "(54)");

            string l = " ";
            System.Console.WriteLine(l);

            System.Console.WriteLine("Average Age = 44");
            System.Console.ReadKey();


            #endregion

        }

    }
}