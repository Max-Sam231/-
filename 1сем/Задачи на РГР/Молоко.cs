using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tect2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\рр\\Desktop\\Олимпиадки\\done Молоко\\input10.txt");
            int Fline = Convert.ToInt32(sr.ReadLine());
            double res =10000;
            int cnt = 0;
            for (int i = 0; i < Fline; i++)
            {
                string line = sr.ReadLine();
                string[] varArr = line.Split(' ');
                int x1 = int.Parse(varArr[0]);
                int y1 = int.Parse(varArr[1]);
                int z1 = int.Parse(varArr[2]);
                int x2 = int.Parse(varArr[3]);
                int y2 = int.Parse(varArr[4]);
                int z2 = int.Parse(varArr[5]);
                double c1 = double.Parse(varArr[6], CultureInfo.InvariantCulture);
                double c2 = double.Parse(varArr[7], CultureInfo.InvariantCulture);
                double s1 = 2 * (x1*y1+ y1 * z1+ x1 * z1);
                double s2 = 2 * (x2*y2+ y2 * z2+ x2 * z2);
                double v1 = x1*y1*z1;
                double v2 = x2*y2*z2;
                double price = (-c1 + (s1 * c2) / s2) / (-((v1 - s1) / 1000) + (s1 * ((v2 - s2) / 1000)) / s2);
                if (price < res)
                {
                    res = Math.Min(res, price);
                    cnt = i+1;
                }
        }
            Console.WriteLine($"{cnt} {Math.Round(res, 2)}");
    }
    }
}
