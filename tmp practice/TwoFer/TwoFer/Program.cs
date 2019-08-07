using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFer
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            Console.WriteLine(Name(userInput));
            Console.ReadLine();
        }
        public static string Name(string input = null)
        {
            string name = input;
            if (name.Length > 0)
            {
                string output = String.Format("One for {name}, one for me.", name);
                return output;
            }
            return "One for you, one for me.";
        }
    }
}
