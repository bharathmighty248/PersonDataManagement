using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDataManagement
{
    class PersonDataMain
    {
        public void AddPersonData(List<Person> list)
        {
            Console.WriteLine("Give the Person Data");

            Person person = new Person();
            Console.Write("Enter SSN: ");
            person.SSN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            person.Name = Console.ReadLine();
            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();
            Console.Write("Enter Age: ");
            person.Age = Convert.ToInt32(Console.ReadLine());
            list.Add(person);
            Console.WriteLine("Person Data Added..");
        }

        public void RetrieveTop2BelowAge60(List<Person> list)
        {
            if (list.Count> 0)
            {
                var data = list.Where(x => x.Age < 60).Take(2);
                foreach(var personData in data)
                {
                    Console.WriteLine("SSN : " + personData.SSN);
                    Console.WriteLine("Name : " + personData.Name);
                    Console.WriteLine("Address : " + personData.Address);
                    Console.WriteLine("Age : " + personData.Age);
                }
            }
            else
            {
                Console.WriteLine("PersonData is Empty..");
            }
        }

        public void RetrieveAllDataBetweenAge13To18(List<Person> list)
        {
            if (list.Count > 0)
            {
                var data = list.Where(x => x.Age >= 13 && x.Age <= 18);
                foreach (var personData in data)
                {
                    Console.WriteLine("SSN : " + personData.SSN);
                    Console.WriteLine("Name : " + personData.Name);
                    Console.WriteLine("Address : " + personData.Address);
                    Console.WriteLine("Age : " + personData.Age);
                }
            }
            else
            {
                Console.WriteLine("PersonData is Empty..");
            }
        }

        public void DisplayData(List<Person> list)
        {
            if (list.Count > 0)
            {
                foreach(Person personData in list)
                {
                    Console.WriteLine("SSN : " + personData.SSN);
                    Console.WriteLine("Name : " + personData.Name);
                    Console.WriteLine("Address : " + personData.Address);
                    Console.WriteLine("Age : " + personData.Age);

                }
            }
            else
            {
                Console.WriteLine("Person Data is Empty..");
            }
        }
    }
}
