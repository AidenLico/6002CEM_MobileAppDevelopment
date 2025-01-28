using System;
using System.Linq;

namespace LabExercises
{
    /*
     * Create a function that returns the smallest number of changes it takes to transform one number into one with identical digits.
     * A step is incrementing or decrementing a digit by one.

       Examples

       SmallestTransform(399) ➞ 6
       // 399 transformed to 999 in 6 steps.

       SmallestTransform(1234) ➞ 4
       // 1234 can be transformed to either 2222 or 3333 using 4 steps.

       SmallestTransform(153) ➞ 4

       SmallestTransform(33338) ➞ 5

       SmallestTransform(7777) ➞ 0

       Notes
       If a number already has identical digits, return 0.
     */
    public class Week2Exercise4
    {
        public static int SmallestTransform(int num)
        {
            int[] numbers = num.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            int smallestSteps = 9 * numbers.Length;
            foreach (int number in numbers)
            {
                int currentSteps = 0;
                foreach (int numberCheck in numbers)
                {
                    currentSteps += Math.Abs(number - numberCheck);
                }

                if (currentSteps < smallestSteps)
                {
                    smallestSteps = currentSteps;
                }
            }
            return smallestSteps;
        }
    }
}