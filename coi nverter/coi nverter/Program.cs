using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        try
        {
            // Get user input for the number of liters
            Console.Write("Enter the number of liters: ");
            double liters = Convert.ToDouble(Console.ReadLine());

            // Get user input for the desired empirical unit
            Console.WriteLine("\nChoose an empirical unit for conversion:");
            Console.WriteLine("1. Fluid ounce (fl oz)");
            Console.WriteLine("2. Gill (gi)");
            Console.WriteLine("3. Pint (pt)");
            Console.WriteLine("4. Quart (qt)");
            Console.WriteLine("5. Gallon (gal)");
            Console.WriteLine("6. Tablespoon (tbsp)");
            Console.WriteLine("7. Teaspoon (tsp)");
            Console.WriteLine("8. Cup");
            Console.Write("Enter the number corresponding to your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Perform conversion based on user's choice
            double conversionFactor = 0.0;
            string unit = "";

            // Switch-like statement
            switch (choice)
            {
                case 1:
                    conversionFactor = 33.814;
                    unit = "fluid ounces";
                    break;
                case 2:
                    conversionFactor = 4.3994;
                    unit = "gills";
                    break;
                case 3:
                    conversionFactor = 2.11338;
                    unit = "pints";
                    break;
                case 4:
                    conversionFactor = 1.05669;
                    unit = "quarts";
                    break;
                case 5:
                    conversionFactor = 0.264172;
                    unit = "gallons";
                    break;
                case 6:
                    conversionFactor = 67.628;
                    unit = "tablespoons";
                    break;
                case 7:
                    conversionFactor = 202.884;
                    unit = "teaspoons";
                    break;
                case 8:
                    conversionFactor = 4.16667;
                    unit = "cups";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                    Console.ReadLine();
                    return;
                    Console.ReadLine();
            }

            // Perform the conversion
            double result = liters * conversionFactor;

            // Display the result
            Console.WriteLine($"\n{liters} liters is equal to {result:F2} {unit}.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.ReadLine();
        }
        Console.ReadLine();
    }
    
}


