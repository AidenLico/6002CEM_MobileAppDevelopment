using System;

namespace LabExercises
{
    public static class Week2Exercise3
    {
        /*
     * Create a function that determines whether elements in an array can be re-arranged to form a consecutive list of numbers where each number appears exactly once.

       Examples

       ConsecutiveNumbers([5, 1, 4, 3, 2]) ➞ true
       // Can be re-arranged to form [1, 2, 3, 4, 5]

       ConsecutiveNumbers([5, 1, 4, 3, 2, 8]) ➞ false

       ConsecutiveNumbers([5, 6, 7, 8, 9, 9]) ➞ false
       // 9 appears twice
       Notes

       N/A
     */
    
        public static bool ConsecutiveNumbers(int[] arr)
        {
            var uniq = new HashSet<int>(arr);
            if (uniq.Count != arr.Length) {
                return false;
            }

            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++) {
                if (arr[i] - arr[i - 1] != 1) {
                    return false;
                }
            }
            
            return true;
        }
    }
}