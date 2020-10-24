using System;
using System.Text.RegularExpressions;

namespace RegexT
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining a regular expression with a pattern
            string pattern = @"\d";
            Regex regex = new Regex(pattern);
          
            // Test string
            string text = "Hi there, my number is 12314";

            // Find hits
            MatchCollection matchCollection = regex.Matches(text); //this is matching the regex of the pattern (\d) to the paramter (text)
            MatchCollection hits = regex.Matches(text);

            // Anzahl der Treffer
            Console.WriteLine("{0} hits found:\n   {1}", matchCollection.Count, text);

            // amount of hits
            foreach (Match aHit in hits)
            {
                GroupCollection groups = aHit.Groups;
                Console.WriteLine("'{0}' found at {1}", groups["word"].Value, groups[0].Index);
            }
            Console.ReadLine();
        }
    }
}
