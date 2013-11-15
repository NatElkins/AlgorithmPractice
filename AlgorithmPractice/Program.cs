using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BubbleSort Test

            int[] testNumbers = AlgorithmImplementations.NewTestSet();

            Console.WriteLine("Before BubbleSort:");
            for (int i = 0; i < testNumbers.Length; i++)
                Console.Write(testNumbers[i] + ",");

            Console.WriteLine();

            testNumbers = AlgorithmImplementations.BubbleSort(testNumbers);

            Console.WriteLine("After BubbleSort:");
            for (int i = 0; i < testNumbers.Length; i++)
                Console.Write(testNumbers[i] + ",");

            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region MergeSort Test

            testNumbers = AlgorithmImplementations.NewTestSet();

            Console.WriteLine("Before MergeSort:");
            for (int i = 0; i < testNumbers.Length; i++)
                Console.Write(testNumbers[i] + ",");

            Console.WriteLine();

            testNumbers = AlgorithmImplementations.MergeSort(testNumbers);

            Console.WriteLine("After MergeSort:");
            for (int i = 0; i < testNumbers.Length; i++)
                Console.Write(testNumbers[i] + ",");

            #endregion

            Console.ReadLine();
        }
    }
}
