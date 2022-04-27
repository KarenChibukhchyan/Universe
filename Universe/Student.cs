namespace Universe
{
    public class Student : Person
    {
        Teacher[] _teachers;

        public Student(string firstName, string secondName, int age) : base(firstName, secondName, age)
        {
            _teachers = null;
        }

        public Student(string firstName, string secondName, int age, Teacher[] teachers) : base(firstName, secondName, age)
        {
            _teachers = teachers;
        }
    }
}