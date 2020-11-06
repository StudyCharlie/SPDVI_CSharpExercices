using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StringReplacementChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\CharliEnglish\Desktop\Segundo DAM\1ª Evaluacion\Desarrollo de interfaces\SPDVI_CSharpExercices\SPDVI_CSharpExercices\SPDVI_CSharpExercices\StringReplacementChallenge\StringReplChallenge_primary.txt";

            List<string> primaryLines = File.ReadAllLines(filePath).ToList();
            Console.Write("Please give me the text to replace: ");
            string toReplace = Console.ReadLine();

            Console.Write("Give me the replacement text: ");

            string replacementText = Console.ReadLine();

            for (int i = 0; i < primaryLines.Count; i++)
            {
                primaryLines[i] = primaryLines[i].Replace(toReplace, replacementText);
            }

            File.WriteAllLines(filePath, primaryLines);

            Console.WriteLine("The text file has been updated !");

            Console.ReadLine();
        }
    }
}
