namespace _1050_Assignment_3
{
    class Student
    {
        private string Name = "";
        private int Grade = 0;
        private Instructor Teacher;
        public Student(string studentname, int grade, Instructor teachername)
        {
            Name = studentname;
            Grade = 0;
            Teacher = teachername;
        }
        public void SetGrade(int grade)
        {
            Grade = grade;
        }
        public void printNameGradeandTeacher()
        {
            System.Console.WriteLine("Name: " + Name);
            System.Console.WriteLine("Grade: " + Grade);
            System.Console.WriteLine("Instructor: ");
        }
    }
}
