using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Centomani_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;
            

            while (nums < 100)
            {
                
                nums++;
                
                if (nums % 3 == 0 && nums % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    
                }
                else if (nums % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    
                }
                else if (nums % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    
                }
                else
                {
                    Console.WriteLine(nums);
                }
                

            }

            Console.ReadKey();
        }
    }
}
