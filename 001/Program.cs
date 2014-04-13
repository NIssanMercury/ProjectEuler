using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    class Program
    {
        //natural numbers:
        


        public static void Main(string[] args)
        {
           //Solution 1
            int total = 0;

            for (int i = 3; i < 1000; i+=3)
                total += i;
            for (int i = 5; i < 1000; i += 5)
                total += i;
            //remove overlapping of 15
            for (int i = 15; i < 1000; i += 15)
                total -= i;

            Console.WriteLine("Method 1: total is: " + total);
            Console.ReadKey();

            //Solution 2 - LINQ operators
            //Enumerable provides a collection similiar to how a foreach loop would be implemeted to create an array
            total = Enumerable.Range(0, 1000).Where(x => x%3 == 0 || x%5 == 0).Sum();

            Console.WriteLine("Method 2 using Linq enumerables: total is: " + total);
            Console.ReadKey();

            //Soluton 3 without modulus



        }
    }
}
