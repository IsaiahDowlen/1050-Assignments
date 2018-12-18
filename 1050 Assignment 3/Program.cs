namespace _1050_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");

            Instructor Mike = new Instructor("Mike", "Math");
 
            Student Jane = new Student("Jane", 0, John);
           
            Student Joe = new Student("Joe", 0, John);
       
            Student Melissa = new Student("Melissa", 0, Mike);

            Student Matt = new Student("Matt", 0, Mike);

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            Jane.printNameGradeandTeacher();
            John.printNameandCourseName();
            System.Console.WriteLine("");
            Joe.printNameGradeandTeacher();
            John.printNameandCourseName();
            System.Console.WriteLine("");

            Matt.printNameGradeandTeacher();
            Mike.printNameandCourseName();
            System.Console.WriteLine("");
            Melissa.printNameGradeandTeacher();
            Mike.printNameandCourseName();
            System.Console.ReadKey();
        }
    }
}
