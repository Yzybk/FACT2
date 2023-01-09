using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACT2
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                int givenNumber, factorial = 1;

                Console.WriteLine("For Loop - Find the factorial of a given number :");
                Console.WriteLine("///////////////////////////////////////////////////////");
                givenNumber = Convert.ToInt32(Console.ReadLine());

                if (givenNumber < 0)
                {
                    Console.WriteLine("Negative values can not calculated for factorial");
                }

                else

                {

                    for (int i = 2; i <= givenNumber; i++)
                    {
                        factorial *= i;
                    }

                    Console.WriteLine("Factorial : {0}", factorial);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
