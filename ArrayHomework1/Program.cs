using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 5, 9, -69, -89, 45, 0, 73 };

            //215
            Console.WriteLine("215 - Zuyg index unecux tarreri guary");


            int sumPlus = 0;

            for (int i = 1; i < array1.Length; i++) // i = 1, vor 0-n zuyg chhashvi
            {
                if (i % 2 == 0)
                {
                    sumPlus += array1[i]++;
                }
            }
            Console.WriteLine("Zuyg index unecux tarreri guary: " + sumPlus);

            //216
            Console.WriteLine("\n216 - Zuyg index unecux tarreri artadryaly");

            int sumPro = 1;
            for (int i = 1; i < array1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumPro *= array1[i];
                }
            }
            Console.WriteLine("Zuyg index unecux tarreri artadryaly: " + sumPro);

            //217
            Console.WriteLine("\n217 - Kent index unecox tarreri qarakusineri artadryal");
            long sumBaPro = 1;
            for (int i = 1; i < array1.Length; i++)
            {
                if (i % 2 > 0)
                {
                    sumBaPro *= array1[i] * array1[i];
                }
            }
            Console.WriteLine("Kent index unecox tarreri qarakusineri artadryaly: " + sumBaPro);

            //218
            Console.WriteLine("\n218 - Kent index unecox tarreri bacardzak arjeqneri gumar");
            int bacasakan = 0;
            int drakany = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (i % 2 > 0 && array1[i] > 0)
                {
                    drakany += array1[i];
                }
                if (i % 2 > 0 && array1[i] < 0)
                {
                    bacasakan += array1[i];
                }
            }
            int bacardzakArjeq = drakany - bacasakan;
            Console.WriteLine("Kent index unecox tarreri bacardzak arjeqneri gumar: " + bacardzakArjeq);

            //219
            Console.WriteLine("\n219 - K tvin bazmapatik index unecox tarreri gumary");

            int k = 2;
            int sumIndex = 0;
            for (int i = k; i < array1.Length; i++)
            {
                if (i % k == 0)
                {
                    sumIndex += array1[i];
                }
            }
            Console.WriteLine("K tvin bazmapatik index unecox tarreri gumary" + sumIndex);

            //220
            Console.WriteLine("\n220 - drakan ev bacasakan tarreri qanaky");
            int sumNumbers = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > 0 || array1[i] < 0)
                {
                    sumNumbers++;
                }
            }
            Console.WriteLine("Drakan ev bacasakan tarreri qanaky" + sumNumbers);
            Console.ReadKey();
        }
    }
}
