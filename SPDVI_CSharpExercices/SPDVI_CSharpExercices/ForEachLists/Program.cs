using System;
using System.Collections.Generic;

namespace ForEachLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<String>();
            names.Add("John");
            names.Add("Mary");
            names.Add("Sue");
            names.Add("Greg");
            names.Add("Yolanda");
            names.Add("Jose");
            names.Add("Bill");

            foreach(var name in names)
            {
                Console.WriteLine("Hello "+name);
            }

            List<PersonModel> people = new List<PersonModel>();

            PersonModel one = new PersonModel("Tim ","Corey");
            PersonModel two = new PersonModel("Bill ", "Mccoy");
            PersonModel three = new PersonModel("Mary ", "Jones");
            PersonModel four = new PersonModel("Sue ", "Smith");

            people.Add(one);
            people.Add(two);
            people.Add(three);
            people.Add(four);

            Console.WriteLine("");
            foreach (var person in people)
            {
                Console.WriteLine("Hello " + person.FirstName + "" + person.LastName);
            }
        }
    }
}
