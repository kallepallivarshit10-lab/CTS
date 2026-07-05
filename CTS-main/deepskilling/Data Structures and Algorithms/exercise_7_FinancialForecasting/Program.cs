using System;

class Program
{
    static void Main()
    {
        double currentValue = 1000;

        double growthRate = 0.10;

        int years = 3;

        double futureValue =
            Forecast.CalculateFutureValue(
                currentValue,
                growthRate,
                years);

        Console.WriteLine("Current Value : " + currentValue);

        Console.WriteLine("Growth Rate : " + (growthRate * 100) + "%");

        Console.WriteLine("Years : " + years);

        Console.WriteLine("Future Value : " + futureValue);
    }
}
