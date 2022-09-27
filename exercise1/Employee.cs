using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class Employee : Person
    {
        public int Salary { get; set; }
        public List<Sale> SalesList { get; set; }

    public Employee()
        {
            SalesList = new List<Sale>();
        }

        public Employee(string firstName, string lastName, int age, int salary) : base(firstName, lastName, age)
        {
            Salary = salary;
            SalesList = new List<Sale>();
        }

        public override string ToString()
        {
            return $"FirstName : {FirstName} LastName : {LastName}  Age : {Age.ToString()} Salary : {Salary.ToString()}.";
        }

    }
}
