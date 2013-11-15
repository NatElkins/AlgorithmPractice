using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal static class Utils
    {
        static Random _random = new Random();

        public static int[] GenerateIntegerArray(int arrayLength)
        {
            int[] array = new int[arrayLength];

            for (int i = 0; i < array.Length; i++)
                array[i] = i + 1;

            return array;
        }

        public static int[] FisherYatesShuffle(int[] unsortedArray)
        {
            int[] copyOfArray = unsortedArray;

            for (int i = unsortedArray.Length; i > 1; i--)
            {
                Random random = _random;
                int j = random.Next(i);
                Utils.Swap(copyOfArray, j, i-1);
            }

            return copyOfArray;
        }

        public static void Swap(int[] array, int position1, int position2)
        {
            if (position1 < 0 || position1 > array.Length - 1)
                throw new IndexOutOfRangeException("Cannot swap positions: position1 out of range");

            if (position2 < 0 || position2 > array.Length - 1)
                throw new IndexOutOfRangeException("Cannot swap positions: position2 out of range");

            int temp = array[position1];
            array[position1] = array[position2];
            array[position2] = temp;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }

            Console.WriteLine();
        }
    }
}
