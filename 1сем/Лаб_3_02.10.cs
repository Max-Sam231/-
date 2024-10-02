using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дана последовательность из n  элементов

            // 1 задача определить макс подпоследовательность четных элементов
            int prev, cur, n, cnt = 1, mx = 1;
            n = Convert.ToInt32(Console.ReadLine());
            prev = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                cur = Convert.ToInt32(Console.ReadLine());
                if (prev % 2 == 0 && cur % 2 == 0)
                {
                    cnt += 1;
                    mx = cnt;
                }
                else
                {
                    cnt = 1;
                    prev = cur;
                }
            }
            Console.WriteLine($"Максимум {mx}");

            // 2 задача максимальную длину из одинаковых элементов
            int prev2, cur2, n2, cnt2 = 1, mx2 = 1;
            n2 = Convert.ToInt32(Console.ReadLine());
            prev2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n2; i++)
            {
                cur2 = Convert.ToInt32(Console.ReadLine());
                if (prev2 == cur2)
                {
                    cnt2 += 1;
                    if (cnt2 > mx2)
                    {
                    mx2 = cnt2;
                    }
                }
                else
                {
                    cnt2 = 1;
                    prev2 = cur2;
                }
            }
            Console.WriteLine($"Максимум {mx2}");


            // 3 задача определить длину подпоследовательности из чётных элементов с наибольший суммой элементов и вывести длину подпоследовательности
            int prev3, cur3, n3, cnt3 = 1, mx3 = 1, mxSum = 0, Sum = 0, oneMx = 0;
            n3 = Convert.ToInt32(Console.ReadLine());
            prev3 = Convert.ToInt32(Console.ReadLine());
            Sum = prev3;
            for (int i = 1; i < n3; i++)
            {
                cur3 = Convert.ToInt32(Console.ReadLine());
                if (cur3 > oneMx && cur3 % 2 == 0) { oneMx = cur3; }
                if (prev3 % 2 == 0 && cur3 % 2 == 0)
                {
                    Sum += cur3;
                    cnt3 += 1;
                    mx3 = cnt3;
                    if (Sum > mxSum) { mxSum = Sum; }
                }
                else
                {
                    Sum = cur3;
                    cnt3 = 1;
                    prev3 = cur3;
                }
                if (mxSum < oneMx) { mxSum = oneMx; mx3 = 1; }
                if (mxSum == 0) { mx3 = 0; }
            }
            Console.WriteLine($"Сумма {mxSum} Длина {mx3}");
        }
    }
}

