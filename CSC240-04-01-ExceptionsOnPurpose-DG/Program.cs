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

        try
        {
            // Input
            Write("Enter an Integer >> ");
            answer = Convert.ToInt32(ReadLine());

            // Process
            result = answer / zero;
        }
        catch (FormatException e)
        {
            WriteLine("You did not enter an integer.");
        }
        catch (DivideByZeroException e)
        {
            WriteLine("This is not your fault.");
            WriteLine("You entered the integer correctly.");
            WriteLine("The program divides by zero.");
        }
        
        // Output
        WriteLine("The answer is " + answer);
        ReadLine();
    }
}