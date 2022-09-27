using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace exercise1
{
    internal class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        private static int InstanceCount { get; set; }

        // constructor       

        public Person()
        {
            WriteLine("ParameterLess Person has created!");
            increaseInstanceCount();
            WriteLine("Instance created = " + instanceCount());
        }
        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            WriteLine("Person with two parameters has created!");
            increaseInstanceCount();
            WriteLine("Instance created = " + instanceCount());
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            WriteLine("Person with three parameters has created!");
            increaseInstanceCount();
            WriteLine("Instance created = " + instanceCount());
        }
        //Exercise 1.2
        //methods

        public void introduce()
        {
            WriteLine($"Hello my name is {FirstName} {LastName} : {Age} years old.");
        }

        public override string ToString()
        {
            return $"FirstName : {FirstName} LastName : {LastName}  Age : {Age.ToString()}.";
        }

        //Exercise 1.5
        private static void increaseInstanceCount()
        {
            InstanceCount++;
        }

        private static string instanceCount()
        {
            return InstanceCount.ToString();
        }

    }

}

    
