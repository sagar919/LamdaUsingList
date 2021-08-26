using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace LambdaUsingList
{
    
    public class Operation
    {
        List<Person> listPersonsInCIty = new List<Person>() {new Person("12345", "aaa", "Mumbai", 20), 
                                                             new Person("12346", "bbb", "Delhi", 21),      
                                                             new Person("12347", "ccc", "Pune", 22), 
                                                             new Person("12348", "ddd", "Pune", 17)};
        public bool Findall()
        {
            //listPersonsInCIty.Add(new Person("12345", "aaa", "Mumbai", 20));
            //listPersonsInCIty.Add(new Person("12346", "bbb", "Delhi", 21));
            //listPersonsInCIty.Add(new Person("12347", "ccc", "Pune", 22));
            //listPersonsInCIty.Add(new Person("12348", "ddd", "Pune", 17));

            foreach (Person person in listPersonsInCIty.FindAll(e => (e.age >= 20)).Take(2).ToList())
            {
                Console.WriteLine("Person : " + person.name + "age: " + person.age);
            }
            return true;
        }

        public bool TeenagerOrNot()
        {
            Console.WriteLine("Check if we have teenagers or not");

          
            if (listPersonsInCIty.Any(e => (e.age >= 13 && e.age >= 19)))
            {
                Console.WriteLine("Yes, we have some teenager");
            }
            else
            {
                Console.WriteLine("Sorry no teenagers");
            }
            
            foreach (Person person in listPersonsInCIty.FindAll(e => (e.age >= 13 && e.age <= 19)))
            {
                Console.WriteLine("Person : " + person.name + " age: " + person.age);
            }

            return true;

        }

        public double Average()
        {
            double average = listPersonsInCIty.Average(e => e.age);
            Console.WriteLine("average is \t" + average);

            return average;
        }

        public bool GetName()
        {
            Console.WriteLine("Displaying the persons until we find a person with name starts with other than 'S'");
            foreach (Person person in listPersonsInCIty.TakeWhile(e => e.name.StartsWith("a")))
            {
               Console.WriteLine("Name : " + person.name + " \t\tAge: " + person.age);
            }
            return true;
        }
    }
}
