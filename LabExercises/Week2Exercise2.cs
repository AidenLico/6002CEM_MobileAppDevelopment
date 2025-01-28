using System;

namespace LabExercises
{
    public static class Week2Exercise2
    {
        /*
        Write a function that calculates overtime and pay associated with overtime.

        Working 9 to 5: regular hours
        After 5pm is overtime
        Your function gets an array with 4 values:

        Start of working day, in decimal format, (24-hour day notation)
        End of working day. (Same format)
        Hourly rate
        Overtime multiplier
        Your function should spit out:

        $ + earned that day (rounded to the nearest hundreth)

        Examples
        OverTime([9, 17, 30, 1.5]) ➞ "$240.00"

        OverTime([16, 18, 30, 1.8]) ➞ "$84.00"

        OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50"

        2nd example explained:

        From 16 to 17 is regular, so 1 * 30 = 30
        From 17 to 18 is overtime, so 1 * 30 * 1.8 = 54
        30 + 54 = $84.00
        */
        public static string OverTime(double[] arr)
        {
            double totalHour = arr[1] - arr[0];
            double regHours, overHours;
            if (arr[0] >= 9 && arr[1] <= 17)
            {
                regHours = totalHour;
                overHours = 0;
            }
            else if (arr[0] < 9 && arr[1] > 17)
            {
                regHours = 8;
                overHours = (9 - arr[0]) + (arr[1] - 17);
            }
            else if (arr[0] < 9)
            {
                regHours = arr[1] - 9;
                overHours = 9 - arr[0];
            }
            else if (arr[1] > 17)
            {
                regHours = 17 - arr[0];
                overHours = arr[1] - 17;
            }
            else
            {
                return "Error";
            }

            double totalPay = (regHours * arr[2]) + (overHours * arr[2] * arr[3]);
            string returnPay = totalPay.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            return returnPay;
        }
    }
}    