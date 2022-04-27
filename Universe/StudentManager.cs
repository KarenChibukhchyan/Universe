using System;

namespace Universe
{
    public class StudentManager
    {
        public Student Create(string firstName, string secondName, int age) => new Student(firstName, secondName, age);

        public Student Create(string firstName, string secondName, int age, Teacher[] teachers) => new Student(firstName, secondName, age, teachers);

        public Student[] Create(int count, int minAge, int maxAge)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"StudentFirstName{i}", $"StudentSeconName{i}", rnd.Next(minAge, maxAge));
            }

            return students;
        }

        public Student[] Create(int count, int minAge, int maxAge, Teacher[] teachers)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"StudentFirstName{i}", $"StudentSecondName{i}", rnd.Next(minAge, maxAge), teachers);
            }

            return students;
        }

        public void Print(Student student)
        {
            Console.WriteLine($"Student: {student.ToString()}");
        }

        public void Print(params Student[] students)
        {
            foreach (Student student in students)
            {
                Print(student);
            }
        }
    }
}