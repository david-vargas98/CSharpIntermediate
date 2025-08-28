using Classes.Models;

namespace Classes
{
    internal class Program
    {
        static void PersonClassExercise()
        {
            Person p = Person.Parse("Edgar");
            p.Intoduce("David");
        }
        static void CustomerClassExercise()
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Edgar";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
        static void Main(string[] args)
        {
            //PersonClassExercise();
            CustomerClassExercise();
        }
    }
}
