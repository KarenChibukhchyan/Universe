namespace Universe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            Student student1 = studentManager.Create("Alex", "Bernoulli", 18);
            Student student2 = studentManager.Create("Tom", "Jerry", 32);
            Teacher teacher1 = teacherManager.Create("Aristarx", "Plutonovich", 66, new [] {student1, student2});
            Teacher teacher2 = teacherManager.Create("Felix", "Edmundovich", 50);
            Student student3 = studentManager.Create("Santa", "Barbara", 20, new []{teacher1, teacher2});
            studentManager.Print(student1, student2, student3);
            teacherManager.Print(teacher1, teacher2);
        }
    }
}