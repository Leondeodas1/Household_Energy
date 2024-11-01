using System;

public class Testing
{
    public static void Main(string[] args)
    {
        // FamilyData (I put random numbers but as long as it works)
        List<double> singleFamilyData = new List<double> { 24, 36, 48, 66, 92 };
        List<double> multiFamilyData = new List<double> { 40, 69, 87, 105, 138 };

        // Choose either single or multifamily household
        Console.WriteLine("Enter household type (1 for Single Family, 2 for Multi Family):");
        int householdChoice = Convert.ToInt32(Console.ReadLine());

        if (householdChoice == 1)
        {
            AnalyzeAndPrintData(singleFamilyData, "Single Family");
        }
        else if (householdChoice == 2)
        {
            AnalyzeAndPrintData(multiFamilyData, "Multi Family");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        }
    }

    public static void AnalyzeAndPrintData(List<double> data, string householdType)
    {
        // Math happens here
        double totalUsage = 0;
        foreach (double value in data)
        {
            totalUsage += value;
        }

        double averageUsage = totalUsage / data.Count;


        string trend = "Stable";
        if (data.Count > 1 && data[data.Count - 1] > data[data.Count - 2])
        {
            trend = "Increasing";
        }
        else if (data.Count > 1 && data[data.Count - 1] < data[data.Count - 2])
        {
            trend = "Decreasing";
        }

        // RESULTS WOOOOOOOOOO
        Console.WriteLine("Energy data for " + householdType + ":");
        Console.WriteLine("Total Energy Usage: " + totalUsage);
        Console.WriteLine("Average Energy Usage: " + averageUsage);
        Console.WriteLine("Trend: " + trend);
    }
}

