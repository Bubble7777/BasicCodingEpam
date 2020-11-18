// Copyright (c) EPAM

namespace BasicCoding
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BasicCodingForEpam
    /// </summary>
    public class BasicCoding
    {
        /// <summary>
        /// Insert bits from second number in first number in some interval.
        /// </summary>
        /// <param name="firstNumber">first variable.</param>
        /// <param name="secondNumber">second variable.</param>
        /// <param name="i">last bit</param>
        /// <param name="j">first bit</param>
        /// <returns>modified number.</returns>
        public static int InsertNumber(int firstNumber, int secondNumber, int i, int j)
        {
            const int MaxOverflow = 31;
            const int MinOverflow = 0;

            if (i > j)
            {
                throw new ArgumentException("variable i > j");
            }

            if (i > MaxOverflow || j > MaxOverflow && i < MinOverflow || j < MinOverflow)
            {
                throw new ArgumentException("overflow");
            }

            int mask = (1 << (j - i + 1)) - 1;
            int interval = secondNumber & mask;
            interval = interval << i;
            firstNumber = firstNumber & ~(mask << i);

            return firstNumber | interval;
        }

        /// <summary>
        /// Implement a recursive algorithm for finding the maximum element in an unsorted integer array.
        /// </summary>
        /// <param name="array">array to search</param>
        /// <param name="maxNumber">maximum element to search</param>
        /// <returns>maximum element</returns>
        public static int FindMaxNumber(int[] array, int maxNumber = 0)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array is empty");
            }

            if (array.Length > maxNumber)
            {
                int next = FindMaxNumber(array, maxNumber + 1);
                if (array[maxNumber] > next)
                {
                    return array[maxNumber];
                }
                else
                {
                    return next;
                }
            }
            else
            {
                return array[0];
            }
        }

        /// <summary>
        /// algorithm for searching in a real array for the index of an element for which the sum of elements
        /// on the left and the sum of elements on the right are equal.
        /// </summary>
        /// <param name="array">real array</param>
        /// <returns>-1 or index</returns>
        public static int FindIndex(double[] array)
        {
            double leftSum = 0.0;
            double rightSum = 0.0;
            int indexMiddle = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (j < i)
                    {
                        leftSum += array[j];
                    }
                    else if (j > i)
                    {
                        rightSum += array[j];
                    }
                }

                if (leftSum == rightSum)
                {
                    indexMiddle = i;
                    break;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (indexMiddle == 0)
            {
                indexMiddle = -1;
            }
            else
            {
                Console.WriteLine($"\nИндекс с равными суммами слева и справа: { indexMiddle}");
            }

            Console.ReadKey();
            return 0;
        }

        /// <summary>
        /// the algorithm is a concatenation of two strings containing only the characters of the Latin alphabet, excluding repeating characters.
        /// </summary>
        /// <param name="firstWord">first word</param>
        /// <param name="secondWord">second word</param>
        /// <returns>concatenation of words</returns>
        public static string ConcateLatinAlphabet(string firstWord, string secondWord)
        {
            string newString = string.Empty;

            string concateWords = firstWord + secondWord;

            for (int i = 0; i < concateWords.Length; i++)
            {
                if (((concateWords[i] >= 'a') && (concateWords[i] <= 'z')) || ((concateWords[i] >= 'A') && (concateWords[i] <= 'Z')))
                {
                    if (!newString.Contains(concateWords[i]))
                    {
                        newString += concateWords[i];
                    }
                }
            }

            Console.WriteLine(newString);
            return newString;
        }

        /// <summary>
        /// the FindNextBiggerNumber method, which takes a positive integer and returns the nearest largest integer consisting of the digits of the original number, and  (or -1),
        /// </summary>
        /// <param name="number">positive integer</param>
        /// <returns>returns the nearest largest integer</returns>
        public static int FindNextBiggerNumber(int number)
        {
            if (number <= 0)
            {
                throw new Exception("the number must be greater than 0");
            }

            int[] numberArray = new int[number.ToString().Length];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(number.ToString()[i].ToString());
            }

            if (HasNoBiggerNumber(numberArray))
            {
                return -1;
            }

            for (int i = numberArray.Length - 1; i >= 0; i--)
            {
                if (numberArray[i] > numberArray[i - 1])
                {
                    Swap(ref numberArray[i], ref numberArray[i - 1]);
                    break;
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (int i in numberArray)
            {
                stringBuilder.Append(i);
            }

            return int.Parse(stringBuilder.ToString());
        }

        /// <summary>
        /// Implement the FilterDigit method that takes an array of integers
        /// and filters it so that only numbers containing the given digit are output
        /// </summary>
        /// <param name="array">array of unfiltered data</param>
        /// <param name="digit">the number by which to filter</param>
        /// <returns>filtered array</returns>
        public static List<int> FilterDigit(int[] array, int digit)
        {
            List<int> arrayDigit = new List<int>();
            string stringDigit = Convert.ToString(digit);
            string stringArray = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                stringArray = Convert.ToString(array[i]);
                if (stringArray.IndexOf(stringDigit, StringComparison.Ordinal) != -1)
                {
                    arrayDigit.Add(array[i]);
                }
            }

            return arrayDigit;
        }

        /// <summary>
        /// Method For Swap
        /// </summary>
        /// <param name="leftNumber">first variable for swap</param>
        /// <param name="rightNumber">second variable for swap</param>
        private static void Swap(ref int leftNumber, ref int rightNumber)
        {
            int temp = leftNumber;
            leftNumber = rightNumber;
            rightNumber = temp;
        }

        /// <summary>
        ///  method for checking No Bigger Number
        /// </summary>
        /// <param name="array"> Array</param>
        /// <returns>return bool</returns>
        private static bool HasNoBiggerNumber(int[] array)
        {
            int a = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    a++;
                }
            }

            if (a == array.Length - 1)
            {
                return true;
            }

            return false;
        }
    }
}
