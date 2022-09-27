using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class Customer : Person
    {
        public List<Sale> PurshesList { get; set; }
        public Customer()
        {
            PurshesList = new List<Sale>();
        }

        public Customer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            PurshesList = new List<Sale>();
        }

        public override string ToString()
        {
            return $"FirstName : {FirstName} LastName : {LastName}  Age : {Age.ToString()}.";
        }
    }
}
