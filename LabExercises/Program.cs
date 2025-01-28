using System;
using LabExercises;
public class Program
{
    public static void Main(string[] args)
    {
        // Exercise 1
        double[] ex11 = Week2Exercise1.FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]);
        double[] ex12 = Week2Exercise1.FindLargest([[-34, -54, -74], [-32, -2, -65], [-54, 7, -43]]);
        double[] ex13 = Week2Exercise1.FindLargest([[0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3]]);

        Console.WriteLine("test1: " + ex11[0] + " " + ex11[1] + " " + ex11[2]);
        Console.WriteLine("test2: " + ex12[0] + " " + ex12[1] + " " + ex12[2]);
        Console.WriteLine("test3: " + ex13[0] + " " + ex13[1] + " " + ex13[2]);
        
        // Exercise 2
        string ex21 = Week2Exercise2.OverTime([9, 17, 30, 1.5]); // ➞ "$240.00"
        string ex22 = Week2Exercise2.OverTime([16, 18, 30, 1.8]); // ➞ "$84.00"
        string ex23 = Week2Exercise2.OverTime([13.25, 15, 30, 1.5]); // ➞ "$52.50"

        Console.WriteLine($"Test 1: {ex21}");
        Console.WriteLine($"Test 2: {ex22}");
        Console.WriteLine($"Test 3: {ex23}");
        // Fix 1
        string ex2T1 = Week2Exercise2.OverTimeTest([10.5, 17, 32.25, 1.5], ["10.5, 17, 32.25, 1.5", "6.5", "6.5 and 0", "209.625", "209.63"]);
        Console.WriteLine($"Test Fix 1: {ex2T1}");
        // Fix 2
        string ex2T2 = Week2Exercise2.OverTimeTest([18, 20, 32.5, 2], ["18, 20, 32.5, 2", "2", "0 and 2", "130", "130.00"]);
        Console.WriteLine($"Test Fix 2: {ex2T2}");
        
        // Exercise 3
        Console.WriteLine("use this method to test your function");
        Console.WriteLine(Week2Exercise3.ConsecutiveNumbers([5, 1, 4, 3, 2]));
        Console.WriteLine(Week2Exercise3.ConsecutiveNumbers([5, 1, 4, 3, 2, 8]));
        Console.WriteLine(Week2Exercise3.ConsecutiveNumbers([5, 6, 7, 8, 9, 9]));
        
        // Exercise 4
        Console.WriteLine(Week2Exercise4.SmallestTransform(153));
        Console.WriteLine(Week2Exercise4.SmallestTransform(33338));
        Console.WriteLine(Week2Exercise4.SmallestTransform(7777));
    }
}
