using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal static class QuickSort
    {
        public static int[] Sort(int[] numbers)
        {
            return Sort(numbers, 0, numbers.Length-1);
        }

        public static int[] Sort(int[] numbers, int startIndex, int endIndex)
        {
            int left = startIndex;
            int right = endIndex;
            int pivot = numbers[(startIndex + endIndex) / 2];

            while (left <= right)
            {
                while (numbers[left].CompareTo(pivot) < 0)
                {
                    left++;
                }

                while (numbers[right].CompareTo(pivot) > 0)
                {
                    right--;
                }

                if (left <= right)
                {
                    Utils.Swap(numbers, left, right);
                    left++;
                    right--;
                }
            }

            if (startIndex < right)
                Sort(numbers, startIndex, right);

            if (left < endIndex)
                Sort(numbers, left, endIndex);

            return numbers;
        }


    }
}
