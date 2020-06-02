using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CirRotation
    {
        int sum = 12345;
            //Console.WriteLine("Sum of the digits " + sum   + ":"  + getSum(sum));
            //Console.WriteLine("Revers of the digits " + sum + ":" + getReverse(sum));
            //Console.ReadKey();

        static int getSum(int value)
        {
            if (value == 0)
                return value;

            int result = 0;
            while (value != 0)
            {
                result = result + (value % 10);
                value = (value / 10);
            }
            return result;
        }

        static int getReverse(int value)
        {
        
            int result = 0;
            while (value > 0)
            {
                result = result*10 + value % 10;
                value = (value / 10);
            }
            return result;
        }
       }
    }

