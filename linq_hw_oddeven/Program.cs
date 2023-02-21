using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_hw_oddeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                8,7,9,3,11,6,2,18
            };
            var odd = list.Where(x => x % 2 == 0);
            var even = list.Where(x =>x % 2 == 1);

            Console.Write("odd number :");
            foreach (var x in odd)
            {
                Console.Write($" {x},");
            }
            Console.Write("\neven number :");
            foreach(var x in even)
            {
                Console.Write($" {x},");
            }
            Console.ReadLine();
        }
    }
}
