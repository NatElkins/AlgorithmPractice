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
            bool enteredInt = false;
            int intsToSort = 0; // Default value

            while (!enteredInt)
            {
                Console.WriteLine("Please enter the number of integers you want the algorithms to sort:");
                string input = Console.ReadLine();

                if (Int32.TryParse(input, out intsToSort))
                    enteredInt = true;
                else
                    Console.WriteLine("You did not enter an acceptable integer value.");

                Console.WriteLine();
            }

            int[] sortedArray = Utils.GenerateIntegerArray(intsToSort);
            int[] shuffledArray;
            int[] outputArray;

            #region BubbleSort Test

            Console.WriteLine("Before BubbleSort:");
            shuffledArray = Utils.FisherYatesShuffle(sortedArray);
            Utils.PrintArray(shuffledArray);
            outputArray = BubbleSort.Sort(shuffledArray);
            Console.WriteLine("After BubbleSort:");
            Utils.PrintArray(outputArray);

            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region MergeSort Test

            Console.WriteLine("Before MergeSort:");
            shuffledArray = Utils.FisherYatesShuffle(sortedArray);
            Utils.PrintArray(shuffledArray);
            outputArray = MergeSort.Sort(shuffledArray);
            Console.WriteLine("After MergeSort:");
            Utils.PrintArray(outputArray);

            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region QuickSort Test

            Console.WriteLine("Before QuickSort:");
            shuffledArray = Utils.FisherYatesShuffle(sortedArray);
            Utils.PrintArray(shuffledArray);
            outputArray = QuickSort.Sort(shuffledArray);
            Console.WriteLine("After QuickSort:");
            Utils.PrintArray(outputArray);

            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region SelectionSort Test

            Console.WriteLine("Before SelectionSort:");
            shuffledArray = Utils.FisherYatesShuffle(sortedArray);
            Utils.PrintArray(shuffledArray);
            outputArray = SelectionSort.Sort(shuffledArray);
            Console.WriteLine("After SelectionSort:");
            Utils.PrintArray(outputArray);

            #endregion

            Console.ReadLine();
        }
    }
}
