using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "I am using visual studio";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
