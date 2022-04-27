using System;

namespace Universe
{
    public class TeacherManager
    {
        public Teacher Create(string firstName, string secondName, int age) => new Teacher(firstName, secondName, age);

        public Teacher Create(string firstName, string secondName, int age, Student[] students) => new Teacher(firstName, secondName, age, students);

        public Teacher[] Create(int count, int minAge, int maxAge)
        {
            Teacher[] teachers = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < teachers.Length; i++)
            {
                teachers[i] = new Teacher($"TeacherFirstName{i}", $"TeacherSecondName{i}", rnd.Next(minAge, maxAge));
            }

            return teachers;
        }

        public Teacher[] Create(int count, int minAge, int maxAge, Student[] students)
        {
            Teacher[] teachers = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                teachers[i] = new Teacher($"TeacherFirstName{i}", $"TeacherSecondName{i}", rnd.Next(minAge, maxAge), students);
            }

            return teachers;
        }

        public void Print(Teacher teacher)
        {
            Console.WriteLine($"Teacher: {teacher.ToString()}");
        }

        public void Print(params Teacher[] teachers)
        {
            foreach (Teacher teacher in teachers)
            {
                Print(teacher);
            }
        }
    }
}