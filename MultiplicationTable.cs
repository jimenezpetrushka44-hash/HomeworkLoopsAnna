using System;
using static System.Console;

// This program follows SOLID principles by organizing each task into its own method.
// The menu logic, input validation, multiplication display, and sentinel handling are all separated,
// making the code easy to read, maintain, and extend.

// Creating the class: 
public class MultiplicationAnna
{

    // What I would like to add is a menu that prompts you for an option and it will perform an action:
    // For example; if you write 1: it will display the whole table
    // if you type 2; it will display the multiplication of 1 single value in specific
    // if you press "q" it will end the program
    public static void Main(string [] args)
    {
        string options;
        int multnum;
        while (true)
        {
            WriteLine($"Welcome to my multiplication program :) \n Please enter the option you want: \n - Type 1 for displaying the multiplication table of 10 values ( 1 to 10)." +
                $" \n - Type 2 for displaying the multiplication of a single value. \n - Type 'Q' for exiting the program:  ");
             options = ReadLine();

            if (IsSentinel(options))
            {
                WriteLine("Exiting the program...Bye :3");
                break;
            }
            NumOption(options);
            switch(options)
            {
                case "1":
                    PrintTable(10);
                    break;
                case "2":
                    WriteLine("Please enter the number you want for the multiplication: ");
                    multnum = int.Parse(ReadLine());
                    WriteLine($"Multiplication of {multnum}: ");
                    SingleMulti(multnum);
                    break;
                default:
                    WriteLine("Invalid option, read again");
                    break;
            } 


            
        }
    }

    // Method to verify if my option is sentinel or not:
    public static bool IsSentinel(string options)
    {
        if(options.ToUpper() == "Q")
        {
            return true;
        }
        return false;
    }

    // Method to convert the string into int for validating the options:
    public static void NumOption(string options)
    {
        int choice = int.Parse(options);
    }

    // Method for displaying the multiplication values of a single num choosen by the user:

    public static void SingleMulti(int multnum)
    {
        for (int i =1; i <= 10; i++)
        {
            WriteLine($"{multnum} x {i} = {multnum * i}");
        }
    }

    // Method for printing the whole table:
    public static void PrintTable(int size)
    {
        for (int row = 1; row <= size; row++)
        {
            for (int col = 1; col <= size; col++)
            {
                Write($"{row * col,4}"); // Align numbers with padding
            }
            WriteLine();
        }
    }
}