using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_hw_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                12,18,13,23,32
            };

            var order = list.OrderByDescending(x => x).ToList();
            Console.Write("OrderByDescending :");
            foreach (var item in order)
            {
                Console.Write($" {item},");
            }

            Console.ReadLine();
        }
    }
}
