namespace Universe
{
    public class Person
    {
        string _firstName;
        string _secondName;
        int _age;

        public Person(string firstName, string secondName, int age)
        {
            _firstName = firstName;
            _secondName = secondName;
            _age = age;
        }

        public override string ToString()
        {
            return $"Name: {_firstName} {_secondName}, Age: {_age}";
        }
    }
}