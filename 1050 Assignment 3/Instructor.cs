namespace _1050_Assignment_3
{
    class Instructor
    {
        private string Name = "";
        private string CourseName = "";
        public Instructor(string teachername, string courseName)
        {
            Name = teachername;
            CourseName = courseName;
        }
        public void SetStudentGrade(Student Student, int grade)
        {
            Student.SetGrade(grade);
        }
        public void printNameandCourseName()
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(CourseName);
        }
    }
}
