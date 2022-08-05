using System;
namespace LowestTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = lowestTriangle(100000, 1);
            Console.WriteLine(x);
        }
        public static decimal lowestTriangle(int trianglebase, int area)
        {
            var height = (int) Math.Ceiling((decimal) 2 * area / trianglebase);
            return height;
        }
    }
}
