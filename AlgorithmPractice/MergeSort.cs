using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal static class MergeSort
    {
        public static int[] Sort(int[] numbers)
        {
            if (numbers.Length > 1)
            {
                int elementsInFirstArray = numbers.Length / 2;
                int elementsInSecondArray = numbers.Length - elementsInFirstArray;

                int[] arr1 = new int[elementsInFirstArray];
                int[] arr2 = new int[elementsInSecondArray];

                for (int i = 0; i < elementsInFirstArray; i++)
                {
                    arr1[i] = numbers[i];
                }

                for (int i = elementsInFirstArray; i < numbers.Length; i++)
                {
                    arr2[i - elementsInFirstArray] = numbers[i];
                }

                arr1 = MergeSort.Sort(arr1);
                arr2 = MergeSort.Sort(arr2);

                int j = 0; // Index of arr1
                int k = 0; // Index of arr2
                int l = 0; // Index of output array

                while (arr1.Length != j && arr2.Length != k)
                {
                    if (arr1[j] < arr2[k])
                    {
                        numbers[l] = arr1[j];
                        l++;
                        j++;
                    }
                    else
                    {
                        numbers[l] = arr2[k];
                        l++;
                        k++;
                    }
                }

                while (j != arr1.Length)
                {
                    numbers[l] = arr1[j];
                    l++;
                    j++;
                }

                while (k != arr2.Length)
                {
                    numbers[l] = arr2[k];
                    l++;
                    k++;
                }
            }

            return numbers;
        }
    }
}
