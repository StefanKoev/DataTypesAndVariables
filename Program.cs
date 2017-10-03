using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digitsSum = 0;
            int currentNum = 0;
            bool isSpecial = false;
            for (int i = 1; i <= number; i++)
            {
                currentNum = i;

                while (i > 0)
                {
                    digitsSum += i % 10;
                    i = i / 10;
                }

                isSpecial = (digitsSum == 5) || (digitsSum == 7) || (digitsSum == 11);
                Console.WriteLine($"{currentNum} -> {isSpecial}");
                digitsSum = 0;
                i = currentNum;
            }
        }
    }
}

