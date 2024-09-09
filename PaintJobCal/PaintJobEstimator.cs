// See https://aka.ms/new-console-template for more information

using System;

class PaintJobEstimator
{
    static void Main()
    {
        // Constants
        const double SQUARE_FEET_PER_GALLON = 15;
        const double HOURS_LABOR_PER_GALLON = 8;
        const double LABOR_COST_PER_HOUR = 20.00;

        // User input
        Console.Write("Enter the square feet of wall space to be painted: ");
        double squareFeet = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the price of the paint per gallon: ");
        double pricePerGallon = Convert.ToDouble(Console.ReadLine());

        // Calculations
        double gallonsRequired = Math.Ceiling(squareFeet / SQUARE_FEET_PER_GALLON); // Round up to the next whole gallon
        double hoursLaborRequired = gallonsRequired * HOURS_LABOR_PER_GALLON;
        double costOfPaint = gallonsRequired * pricePerGallon;
        double laborCharges = hoursLaborRequired * LABOR_COST_PER_HOUR;
        double totalCost = costOfPaint + laborCharges;

        // Output
        Console.WriteLine("\nPaint Job Estimate:");
        Console.WriteLine($"Gallons of paint required: {gallonsRequired}");
        Console.WriteLine($"Hours of labor required: {hoursLaborRequired}");
        Console.WriteLine($"Cost of the paint: ${costOfPaint:F2}");
        Console.WriteLine($"Labor charges: ${laborCharges:F2}");
        Console.WriteLine($"Total cost of this paint job: ${totalCost:F2}");
    }
}
