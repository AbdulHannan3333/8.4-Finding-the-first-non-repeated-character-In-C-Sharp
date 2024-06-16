using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4_Finding_the_first_non_repeated_character
{
    internal class Program
    {
            static char FindFirstNonRepeated(string str) 
            {
                Dictionary<char, int> charCount = new Dictionary<char, int>();
                foreach (char c in str)
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
                foreach (char c in str) 
                {
                    if (charCount[c] == 1) 
                    {
                        return c;
                    }
                }
                return '\0';
            }
        static void Main(string[] args)
        {
            string input = "hello";
            char result = FindFirstNonRepeated (input);
            if (result != '\0')
            {
                Console.WriteLine($"First Non Repeated character: {result}");
            }
            else 
            {
                Console.WriteLine("No Non Repeated Character Found!");
            }
        }
    }
}
