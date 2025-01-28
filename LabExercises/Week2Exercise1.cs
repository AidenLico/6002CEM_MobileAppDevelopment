using System.Linq;

namespace LabExercises
{
    public class Week2Exercise1
    {
        /*
        Create a function that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.

        Examples
        FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]) ➞ [7, 90, 2]
        FindLargest([[-34, -54, -74], [-32, -2, -65], [-54, 7, -43]]) ➞ [-34, -2, 7]
        FindLargest([[0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3]]) ➞ [0.7634, 9.32, 9]

        Notes
        Watch out for negative numbers.
         */
        public static double[] FindLargest(double[][] values)
        {
            //This is the method that you need to properly implement.
            double[] largestValues = values.Select(array => array.Max()).ToArray();
            return largestValues;
        }

    }
}