using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a date: ");
            var date = Console.ReadLine();
            var parsedDate = DateTime.Parse(date);
            var now = DateTime.Now;

            var difference = now - parsedDate;
            Console.WriteLine("It has been: " + difference.Days + " days since " +parsedDate.ToShortDateString());

            Console.WriteLine("Give me a time: ");
            var time = Console.ReadLine();
            var parsedTime = TimeSpan.Parse(time);

            var timeDifference = now - parsedTime;
            Console.WriteLine(time + " was " + timeDifference.Hour + " hours and " + timeDifference.Minute + " minutes ago");
        }
    }
}
