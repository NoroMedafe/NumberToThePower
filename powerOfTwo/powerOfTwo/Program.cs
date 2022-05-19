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
            int currentNumberDegree = 1;
            int secondDegree = 2;
            int numberToPower = 2;

            while (number > numberToPower)
            {
                numberToPower = numberToPower * secondDegree;
                currentNumberDegree++;
            }

            Console.WriteLine(number);
            Console.WriteLine(currentNumberDegree);
            Console.WriteLine(numberToPower);

            Console.ReadKey();
        }
    }
}
