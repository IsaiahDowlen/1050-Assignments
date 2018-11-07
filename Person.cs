namespace _1050_Assignment_2
{
    class Person
    {
       public int Age;
       public string FirstName;
       public string LastName;
       public Person Spouse;

       public static double SumOfAllAges;
       public string FullName()
       {
       return this.FirstName + " " + this.LastName + "   Age: ";
       }

       public void printNameandage()
       {
       System.Console.WriteLine(this.FullName());
       System.Console.WriteLine(this.Age);
       }





    }
}
