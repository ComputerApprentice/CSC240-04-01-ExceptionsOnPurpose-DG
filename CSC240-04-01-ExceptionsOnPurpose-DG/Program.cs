using System;
using System.Linq.Expressions;
using static System.Console;

/* Author:       Dixon Geiser
 * Date:         7/20/2024
 * Program:      You Do It Book Exercise (one document, multiple branches)
 */

class ExceptionsOnPurpose
{
    static void Main(string[] args)
    {
        // Storage
        int answer = 0;
        int result;
        int zero = 0;

        // Input
        Write("Enter an Integer >> ");
        answer = Convert.ToInt32(ReadLine());

        // Process
        result = answer / zero;

        // Output
        WriteLine("The answer is " + answer);
        ReadLine();
    }
}