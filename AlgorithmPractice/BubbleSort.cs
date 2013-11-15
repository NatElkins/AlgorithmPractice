using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal static class BubbleSort
    {
        public static int[] Sort(int[] numbers)
        {
            int n = numbers.Length;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        Utils.Swap(numbers, i - 1, i);
                        swapped = true;
                    }
                }

                n--;
            }

            return numbers;
        }
    }
}
