using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class Sale
    {

        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public DateTime TransactionDate { get; set; }
        public Sale(){ TransactionDate = DateTime.Now; }

        public Sale(Employee e, Customer c, string prodcut, double price) 
        { Employee = e; Customer = c; Product = prodcut; Price = price; TransactionDate = DateTime.Now; addSale(); }

        public void addSale()
        {
            Employee.SalesList.Add(this);
            Customer.PurshesList.Add(this);
        }

        public override string ToString()
        {
            return $"Employee: {Employee.FirstName} {Employee.LastName} || Customer: {Customer.FirstName} {Customer.LastName} || Product: {Product} || Price: {Price.ToString()} || TransactionDate: {TransactionDate}.";
        }
    }
}
