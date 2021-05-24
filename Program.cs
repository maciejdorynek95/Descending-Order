using System;
using System.Linq;

namespace Kata
{
    public class Kata
    {
       
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));

        }
        public static void Main()
        {
            Console.WriteLine(DescendingOrder(6634246));
        }
    }
}





