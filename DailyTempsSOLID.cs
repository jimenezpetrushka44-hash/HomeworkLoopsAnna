
// This program follows SOLID principles by separating responsibilities into clear, single-purpose methods.
// Each method handles one task—such as input gathering, validation, classification, summing, or displaying results—
// making the code easier to read, test, and maintain. The logic is open to extension (e.g., adding new classifications)
// without modifying existing methods.

using System;
using static System.Console; // Console is a class and here I'm importing the methods of the Console class.

public class DailyTemps
{

    public static void Main()
    {
        float totaltemp = 0;
        int tempcount = 0;

        // Loop for the main program: 
        while (true)
        {
            string input = GatherInput();
            if (IsSentinel(input))
            {
                WriteLine("Exiting the program...Byeee :3");
                DisplayResults(tempcount, CalculateAverage(totaltemp, tempcount));
                break;
            }
            else
            {
                float temperature = ParseTemp(input);
                if (IsValidRange(temperature))
                {
                    WriteLine($"The temperature you entered is classified as: {ClassTemp(temperature)}");
                    SumTemps(ref totaltemp, temperature);
                    AddToCounter(ref tempcount, temperature);
                    WriteLine("-------Adding temperatures...-------");
                    CalculateAverage(totaltemp, tempcount);
                    continue;
                }
            }
        }
    }

    // Method to gather input:
   public  static string GatherInput()
    {
        Write("Please enter a temperature value between -20 and 130 or 'Q' to quit: ");
        return ReadLine();
    }

    // Method for validating sentinel value "Q":
   public static bool IsSentinel(string input)
    {
        return input.ToUpper() == "Q";
    }

    // Method for getting the temp:
    public static float ParseTemp(string input)
    {
        float temperature;
        return float.Parse(input);
    }


    //Method for validating the range:
    public static bool IsValidRange(float temperature)
    {
        if (temperature < -20 || temperature > 130)
        {
            WriteLine("Error: Please enter a valid temperature");
            return false;
        }
        return true;
    }

    // THIS IS MY NEW METHOD; I'm adding it to my code, it's not in the prompt.
    // My implementation for this dailytemp app is to classify the temperature imput in 3 categorie: cold, warm and hot:
    public static string ClassTemp(float temperature)
    {
        if (temperature < 60 && temperature >= -20)
        {
            return "Cold";
        }
        else if (temperature >= 60 && temperature <= 90)
        {
            return "Warm";
        }
        else if (temperature > 90 && temperature <= 130)
        {
            return "Hot";
        }
        return "none";
    }

    // Method for the sum:
    public static void SumTemps(ref float totaltemp, float temperature)
    {
        totaltemp += temperature;
    }

    // Method for adding to the counter:
    public static void AddToCounter(ref int tempcount, float temperature)
    {
        tempcount++;
    }

    // Method for the averrgae:
    public static float CalculateAverage(float totaltemp, int tempcount)
    {
        float av= totaltemp / tempcount;
        return av;
    }

    // Method for displaying the results:
    public static void DisplayResults( int tempcount, float av)
    {
        WriteLine($"The total of temperatures entered is: {tempcount}");
        WriteLine($"The average is: {av}");
    }



}
