using exercise1;
using System.Runtime.InteropServices;
using static System.Console;

//Exercise 1.3
Person person1 = new Person();
person1.FirstName = "Fadi"; // call setter
person1.LastName = "Abji";
person1.Age = 36;



//Exercise 1.4
WriteLine(person1);

WriteLine("\n*****************************\n");
Person p2 = new Person("Sally", "Abji", 5);

WriteLine("\n*****************************\n");
Person p3 = new Person("Layaan", "Abji");



// Exercise 1.6 
// Customer and Employee Class inherit the Person Class
WriteLine("\n*****************************\n");
Customer c = new Customer("Justin", "Pibar", 36);
WriteLine(c);

WriteLine("\n*****************************\n");
Employee e = new Employee("Well", "Smith", 32, 40000);
WriteLine(e);



// Creating a method to Console out the person object
static void testPerson(Person p)
{
    WriteLine(p);
}
// Calling the testPerson method with both an Employee and Customer object
WriteLine("\n\nC" +
    "alling a testPerson method: ");
testPerson(e);
testPerson(c);

Sale s1 = new Sale(e, c, "Mixture", 100);
Sale s2 = new Sale(e, c, "Mobile", 200);
Sale s3 = new Sale(e, c, "Screen", 200);
Sale s4 = new Sale(e, c, "Vaccum Cleaner", 200);

int GetNumberOfSales(Employee e)
{
    return e.SalesList.Count;
}

double GetSalesTotal(Employee e)
{
    double total = 0;
    foreach (Sale s in e.SalesList)
    {
        total =+ s.Price; 
    }
    return total;
}

float GetAverageSale(Employee e)
{
    float average = (float)GetSalesTotal(e)/ (float)GetNumberOfSales(e);

    return average;
}

void GetStatisticsOfEmployee(Employee e)
{
    WriteLine($"\n\nFollowing is statistic for {e.FirstName} {e.LastName}:");
    WriteLine("\tNumber of Sales : " +  GetNumberOfSales(e).ToString());
    WriteLine("\tSales total : " +"$"+GetSalesTotal(e).ToString());
    WriteLine("\tAverage sales : " + "$"+
        GetAverageSale(e).ToString());
}

GetStatisticsOfEmployee(e);

void PrintSalesList(Employee e)
{
    WriteLine($"\n\nFollowing is list of sales for {e.FirstName} {e.LastName}:");
    foreach (Sale s in e.SalesList)
    {
        WriteLine(s.ToString());
    }
}

PrintSalesList(e);
