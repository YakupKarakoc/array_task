using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Ardışık Pozitif Alt Dizilerin Toplamı **********");
            int[] array = { 2, -4, -99, 9, 6, 7, -3 };

            int maxTotal = 0;
            int tempTotal = 0;
            bool hasPositive = false;
            int maxNegative = -9999;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    tempTotal += array[i];
                    hasPositive = true;
                }
                else
                {
                    if (tempTotal > maxTotal)
                    {
                        maxTotal = tempTotal;
                    }
                    tempTotal = 0;

                    if (array[i] > maxNegative)
                    {
                        maxNegative = array[i];
                    }
                }
            }

            if (tempTotal > maxTotal)
            {
                maxTotal = tempTotal;
            }

            if (hasPositive)
            {
                Console.WriteLine("En büyük ardışık pozitif alt dizi toplamı = " + maxTotal);
            }
            else
            {
                Console.WriteLine("En büyük negatif sayı = " + maxNegative);
            }
        }
    }
}