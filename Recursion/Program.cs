using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5! means 5 x 4 x 3 x 2 x 1


            // ask the user to enter n (an integer)
            Console.WriteLine("Welcome to Factorial Factory");
            Console.Write("Please enter a number: ");
            int n = 0;
            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Please enter a number: ");
            }


        }
    }
}
