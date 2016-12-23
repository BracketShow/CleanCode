using System;

namespace BracketShow.CleanCode
{
    public class IntroduceNullObject
    {
        public void Display(Customer customer)
        {
            if (customer == null)
            {
                Console.WriteLine("no name");
            }
            else
            {
                Console.WriteLine(customer.Name);
            }
        }
    }

    public class Customer
    {
        private readonly string _name;

        public Customer(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }

    public class NullCustomer : Customer
    {
        public NullCustomer() : base("non name")
        {
        }
    }
}