namespace Universe
{
    public class Teacher : Person
    {
        Student[] _students;

        public Teacher(string firstName, string secondName, int age) : base(firstName, secondName, age)
        {
            _students = null;
        }

        public Teacher(string firstName, string secondName, int age, Student[] students) : base(firstName, secondName, age)
        {
            _students = students;
        }
    }}