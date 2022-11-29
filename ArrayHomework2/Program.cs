using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array2 = new int[] { -96, 84, -31, 67, -31, 84, -96 };
            //251
            Console.WriteLine("251 - miachap zangvaci mecaguyn tarry");
            int max = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] > max)
                {
                    max = array2[i];
                }
            }
            Console.WriteLine("Mecaguyn tarry: " + max);

            //252
            Console.WriteLine("\n252 - miachap zangvaci poqraguyn tarry");
            int min = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] < min)
                {
                    min = array2[i];
                }
            }
            Console.WriteLine("Poqraguyn tarry: " + min);

            //253
            Console.WriteLine("\n253 - mecaguyn ev poqraguyn tarreri gumary");
            int gumary = min + max;
            Console.WriteLine("mecaguyn ev poqraguyn tarreri gumary: " + gumary);

            //254
            Console.WriteLine("\n254 - mecaguyn ev poqraguyn tarreri artadryaly");
            int artadryal = min * max;
            Console.WriteLine("mecaguyn ev poqraguyn tarreri artadryaly: " + artadryal);

            //255
            Console.WriteLine("\n255 - mecaguyn tarri ev ir hamari gumary");
            int maxArrayIndex = 0;
            int maxArray = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] > maxArray)
                {
                    maxArray = array2[i];
                    maxArrayIndex = i;
                }
            }
            Console.WriteLine($"Max Array :{maxArray} \tMax Array Index :{maxArrayIndex} \t Gumary: {maxArray + maxArrayIndex}");

            //256
            Console.WriteLine("\n256 - poqraguyn tarri ev ir hamari gumary");
            int minArray = 0;
            int minArrayIndex = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] < minArray)
                {
                    minArray = array2[i];
                    minArrayIndex = i;
                }
            }
            Console.WriteLine($"Min Array :{minArray} \tMin Array Index :{minArrayIndex} \t Gumary: {minArray + minArrayIndex}");

            //257
            Console.WriteLine("\n257 - arajin mecaguyn tarri hamary");
            int firstMax = 0;
            int firstMaxIndex = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] > firstMax)
                {
                    firstMax = array2[i];
                    firstMaxIndex = i;
                }
            }
            Console.WriteLine($"First max :{firstMax} \tFirst Max Index{firstMaxIndex}");

            //258 kam karanq >= dnel max popoxakanic u kpoxarinvi nor iren = arjeqov
            Console.WriteLine("\n258 - verjin mecaguyn tarri hamary");
            int lastMax = 0;
            int lastMaxIndex = 0;
            for (int i = array2.Length - 1; i >= 0; i--)
            {
                if (array2[i] > lastMax)
                {
                    lastMax = array2[i];
                    lastMaxIndex = i;
                }
            }
            Console.WriteLine($"Last Max :{lastMax} \tLast Max Index :{lastMaxIndex}");
            //259
            Console.WriteLine("\n259 - arajin poqraguyn tarri hamary");
            int firstmin = 0;
            int firstMinIndex = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] < firstmin)
                {
                    firstmin = array2[i];
                    firstMinIndex = i;
                }
            }
            Console.WriteLine($"First Min :{firstmin} \tFirst Min Index :{firstMinIndex}");

            //260
            Console.WriteLine("\n260 - verjin poqraguyn tarri hamary");
            int lastmin = 0;
            int lastMinIndex = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] <= lastmin)
                {
                    lastmin = array2[i];
                    lastMinIndex = i;
                }
            }
            Console.WriteLine($"Last Min :{lastmin} \tLast Min Index :{lastMinIndex}");
            Console.ReadLine();
        }
    }
}
