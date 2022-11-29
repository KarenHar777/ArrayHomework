using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // drakan tveri mijin tvabanakan
            Console.WriteLine("211 - Drakan tveri mijin tramabanakan");
            int[] num = new int[] { -7, 5, 16, -3, 2 };

            int numAccount = 0; // drakan tarreri gumar
            int numBccount = 0; // drakan tarreri qanak
            double sumQar = 0; // arjeqneri qarakusineri gumar

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                {
                    numAccount += num[i];
                    numBccount++;
                    sumQar += num[i] * num[i];
                }

            }
            Console.WriteLine("drakan tarreri gumar: " + numAccount);
            Console.WriteLine("drakan tarreri qanak: " + numBccount);
            Console.WriteLine("mijin tvabanakan: " + (double)numAccount / numBccount); // mijin tvabanakan

            //212 
            Console.WriteLine("\n212 - Drakan tareri mijin qarakusajiny");
            double numMidQar = (double)sumQar / numBccount;
            Console.WriteLine("drakan tarreri mijin qarakusajin: " + Math.Sqrt(numMidQar));// drakan tarreri mijin qarakusajin


            Console.WriteLine();
            //213
            Console.WriteLine("\n213 - bacasakan tarreri mijin qarakusajin");

            int[] myArray = new int[] { 48, -12, 74, -23, 56, -41 };

            int sumBarray = 0; //bacasakan tveri gumar
            int countBarray = 0; //bacasakan tveri qanak
            double sumQarray = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < 0)
                {
                    sumBarray += myArray[i];
                    countBarray++;
                    sumQarray += myArray[i] * myArray[i];
                }
            }
            Console.WriteLine("Bacasakan tarreri gumary: " + sumBarray);
            Console.WriteLine("Bacasakan tarreri qanaky: " + countBarray);
            Console.WriteLine(sumQarray);
            Console.WriteLine("Bacasakan tarreri mijin qarakusayiny: " + Math.Sqrt(sumQarray / countBarray));

            //214
            Console.WriteLine("\n214 - Bacasakan tarreri mijin tvabanakan");
            double sumMathMid = (double)sumBarray / countBarray;
            Console.WriteLine("bacasakan tarreri mijin tvabanakan: " + sumMathMid);
            Console.ReadLine();
        }
    }
}
