using System.Collections.Generic;

namespace Classes.Models
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>(); //good practice by avoiding NullReferenceException in main method
                                        //since is customer's responsability to initialize the list
        }
        public Customer(int id)
            : this() // this calls the default constructor first and then the parameterized one
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // it calls the cons constructor, and the the second calls the first
        {
            this.Name = name;
        }

        // The above is considered as a bad practice, since it does the code a little bit ugly, redundant and
        // hard to maintain, so the advice is to keep this kind of practice at the minimum
    }
}
