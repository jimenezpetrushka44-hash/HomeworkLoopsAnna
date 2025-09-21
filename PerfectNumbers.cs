using System;
using static System.Console;

// This program follows SOLID principles by separating each responsibility into its own method.
// The logic for checking perfect numbers, printing results, and explaining why a number is perfect
// is clearly divided, making the code easy to read, maintain, and extend.

// Creating the class:
public class PerfectNumber
{

    // Creating the main method to load all the program:
    public static void Main()
    {
        WriteLine("This will display the perfect numbers between 1 and 10,000");
        PrintNumbers(10000);
     
    }

    // Creating method to know if the number is perfect:
    public static bool IsPerfect(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        { // Finding trough all numbers that are less than the number in this case 10,000
            if (number % i == 0) // Here it checks if "i" can divide number evenly
            {
                sum += i; // here it adds it to the sum
            }
        }
        // Returns true if the sum of divisors equals the og number
        return sum == number;
        }
     
    // Method for printing the numbers:
    public static void PrintNumbers(int number)
    {
        // Loop trough nums from 1 to the number:
        for (int i = 1; i <= number; i++)
        {
            // If the number is perfect then it prints it
            if (IsPerfect(i))
            {
                WriteLine(i);
                WhyPerfect(i);// Calling the new method here so it can explain why those nums are perfect

            }
        
        }
    }

    // What I would be adding is that the program will show why these nums are perfect
    // So here it is the method for it:
    public static void WhyPerfect(int number)
    {
        // Creating an array to store the divisors of the numbers
        int[] divisors = new int[100]; 
        int count = 0; // this keeps the track of how many divisor are found
        int sum = 0; // Stores the sum of all divisors 


        // Looping trough all the numbers less than number

        for (int i = 1; i < number; i++)
        {
            // this checks if i divides number evenly
            if (number % i == 0)
            {
                // if it does it store it in the array
                divisors[count] = i;
                // Increases the counter for divisors found
                count++;
                // Add the divisor to the running sum
                sum += i;
            }
        }

        Write($"{number} is perfect because: ");

        // This for loop prints each divisor with a + sign 
        for (int i = 0; i < count; i++)
        {
            Write(divisors[i]);
            // This one adds the + sign between nums but not after the last one that would be weird
            if (i < count - 1)
            {
                Write(" + ");
            }
        }
        // Printing the final result
        WriteLine($" = {sum}");

    }

}

