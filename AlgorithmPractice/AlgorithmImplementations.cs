using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    static public class AlgorithmImplementations
    {
        static public int[] NewTestSet()
        {
            int[] testNumbers = { 2, 1, 8, 1, 4, 0, 9, 5, 3 };

            return testNumbers;
        }

        static public int[] BubbleSort(int[] numbers)
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
                        int temp = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }

                n--;
            }

            return numbers;
        }

        static public int[] MergeSort(int[] numbers)
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

                arr1 = MergeSort(arr1);
                arr2 = MergeSort(arr2);

                int j = 0;
                int k = 0;
                int l = 0;

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
