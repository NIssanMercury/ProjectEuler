using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 600851475143;
            HashSet<int> collection = new HashSet<int>();
            bool finding = true;
            long x = 2;

            while (finding)
            {
                if (num % x == 0)
                {
                    collection.Add(Convert.ToInt32(x));
                    num /= x;
                }
                x+= 1;
                if (x > num)
                {
                    finding = false;
                }
            }
            foreach (var item in collection)
            {
                Console.Write(item.ToString() + ", ");
            }
            Console.WriteLine("Largest prime factor is: " + collection.Max());

            Console.ReadKey();
        }
    }
}
