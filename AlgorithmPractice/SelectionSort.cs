using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal static class SelectionSort
    {
        public static int[] Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min])
                        min = j;
                }

                Utils.Swap(numbers, i, min);
            }

            return numbers;
        }
    }
}
