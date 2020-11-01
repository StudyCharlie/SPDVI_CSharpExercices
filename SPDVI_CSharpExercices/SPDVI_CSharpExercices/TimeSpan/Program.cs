using System;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);

           var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;

            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;

            Console.WriteLine(duration);

            Console.WriteLine("Minutes: "+ timeSpan.Minutes);
            Console.WriteLine("Total minutes: "+ timeSpan.TotalMinutes);


            Console.WriteLine("Add: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Substract: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));
        }
    }
}
