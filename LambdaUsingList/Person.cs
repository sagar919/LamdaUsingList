using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaUsingList
{
    public class Person
    {
        public string ssn;
        public string name;
        public string address;
        public int age;


        public Person(string SSN, string Name, string Address, int Age)
        {
            ssn = SSN;
            name = Name;
            address = Address;
            age = Age;
        }
    }
}
