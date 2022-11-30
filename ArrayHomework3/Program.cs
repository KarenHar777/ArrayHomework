using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array3 = new int[] { 5, 0, 6, 48, 31, 57, 12, 3 };

            //231
            Console.WriteLine("231 - zuyg arjeq unecox tarreri qarakusineri gumary");
            int sum = 0;
            for (int i = 2; i < array3.Length; i++)
            {
                if (array3[i] % 2 == 0)
                {
                    sum += array3[i] * array3[i];
                }
            }
            Console.WriteLine("Zuyg arjeq unecox tarreriqarakusineri gumary: " + sum);

            //232
            Console.WriteLine("\n 232 - zuyg arjeq unecox tarreri qanaky");
            int count = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Zuyg arjeq unecox tarreri qanaky: " + count);

            //233
            Console.WriteLine("\nZuyg arjeq unecox tarreri artadryaly u gumary");
            int artadryaly = 1;
            int gumary = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] % 2 == 0)
                {
                    artadryaly *= array3[i];
                    gumary += array3[i];
                }
            }
            Console.WriteLine($"Zuyg arjeq unecox tarreri artadryaly {artadryaly}  gumary {gumary}");

            //234
            Console.WriteLine("\nKent arjeq unecox tarreri mijin tvabanakany");
            int kentSum = 0;
            int kentCount = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] % 2 != 0)
                {
                    kentSum += array3[i];
                    kentCount++;
                }
            }
            double kentMidMat = (double)kentSum / kentCount;
            Console.WriteLine("Kent arjeq unecox tarreri mijin tvabanakany: " + kentMidMat);

            //235
            Console.WriteLine("\nKent arjeq unecox tarreri mijin qarakusayin");
            int kentQarSum = 0;
            int kentCount1 = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] % 2 != 0)
                {
                    kentQarSum += array3[i] * array3[i];
                    kentCount1++;
                }
            }
            double midQar = Math.Sqrt(kentQarSum / kentCount1);
            Console.WriteLine("Kent arjeq unecox tarreri mijin qarakusayin: " + midQar);

            //236
            Console.WriteLine("\nKent arjeq unecox tarreri qanaky u artadryaly");
            int kentArtadryal = 1;
            int kentCount2 = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] != 0)
                {
                    kentArtadryal *= array3[i];
                    kentCount2++;
                }
            }
            Console.WriteLine($" Kent arjeq unecox tarreri qanaky {kentCount2} artadryaly {kentArtadryal}");
            //237
            Console.WriteLine("\n0 arjeq unecox tarreri qanaky");
            int zeroCount = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] == 0)
                {
                    zeroCount++;
                }
            }
            Console.WriteLine("0 arjeq unecox tarreri qanaky: " + zeroCount);

            //238
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
