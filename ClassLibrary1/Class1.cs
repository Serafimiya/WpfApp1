using System;
using System.Globalization;
using System.Threading;

namespace Lib_5
{
    public class Class1
    {
        pablic Class1 (string numbers, int totalSum, int count)
        generatenumbers (int k)
        {
            Random random = new Random();
            totalSum = 0;
            count = 0;
            numbers = "";
            count = 0;

            while (totalSum <= k)
            {
                int x = random.Next(-7, 4);
                numbers += x.ToString() + "";
                totalSum += x;
                count++;
            }
            return (numbers, totalSum, count);
        }
    }
}
