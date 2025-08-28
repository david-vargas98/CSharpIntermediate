namespace Classes.Models
{
    public class Person
    {
        public string Name;

        public void Intoduce(string to)
        {
            Console.WriteLine("Hi {0} I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;

            return person;
        }
    }
}
