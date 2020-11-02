using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFileDataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Carlos\Desktop\Clase\Interficies\SPDVI_CSharpExercices\SPDVI_CSharpExercices\TextFileDataAccess\Text.txt";

            //List<String> lines = File.ReadAllLines(filePath).ToList();

            //foreach(String line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //lines.Add("Sue,Storm,www.stormy.com");

            //File.WriteAllLines(filePath, lines);

            List<Person> people = new List<Person>();

            List<String> lines = File.ReadAllLines(filePath).ToList();

            foreach(var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.firstName = entries[0];
                newPerson.lastName = entries[1];
                newPerson.url = entries[2];

                people.Add(newPerson);
            }

            foreach(var person in people)
            {
                // equals to ---> person.firstName + " " + person.lastName + " " + person.url.
                Console.WriteLine($"{ person.firstName } { person.lastName } { person.url }");
            }

            people.Add(new Person { firstName = "Greg", lastName = "Jones", url = "www.GregJones.com" });

            List<String> output = new List<string>();

            foreach(var person in people)
            {
                output.Add($"{ person.firstName },{ person.lastName },{ person.url }");
            }

            Console.WriteLine("Writing to text file !");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries written");
            Console.ReadLine();
        }
    }
}
