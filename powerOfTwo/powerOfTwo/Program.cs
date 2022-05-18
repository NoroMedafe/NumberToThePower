using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            int minLimitRandomNumber = 2;
            int maxLimitRandomNumber = 150;
            int number = randomNumber.Next(minLimitRandomNumber, maxLimitRandomNumber);
            int currentDegree = 1;
            double secondDegree = 0.5;
            double numberToThePower = 2;

            for (int i = 0; number > numberToThePower; currentDegree++)
            {
                numberToThePower = numberToThePower / secondDegree;
            }

            Console.WriteLine(number);
            Console.WriteLine(currentDegree);
            Console.WriteLine(numberToThePower);

            Console.ReadKey();
        }
    }
}
