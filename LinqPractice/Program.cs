using System;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());

            bool Denis = num > 100 ? true : false;

            if (Denis)
                Console.WriteLine("This number is bigger than 100");
            else if(!Denis) Console.WriteLine("This number is less than 100");
        }
    }
}
