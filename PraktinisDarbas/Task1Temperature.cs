using System;

public static class Task1Temperature
{
    public static void Run()
    {
        Random random = new Random();
        double[] temperatures = new double[30];

        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = -10 + random.NextDouble() * 45;
        }

        Console.WriteLine("Pradinis temperatūrų masyvas:");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.WriteLine($"{i + 1} diena: {temperatures[i]:F1} °C");
        }

        double sum = 0;
        for (int i = 0; i < temperatures.Length; i++)
        {
            sum += temperatures[i];
        }

        double average = sum / temperatures.Length;
        Console.WriteLine($"\nVidutinė temperatūra: {average:F1} °C");

        Console.WriteLine("\nAnomalios dienos:");
        bool found = false;

        for (int i = 0; i < temperatures.Length; i++)
        {
            if (Math.Abs(temperatures[i] - average) >= 8)
            {
                Console.WriteLine($"{i + 1} diena: {temperatures[i]:F1} °C");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Anomalijų nerasta.");
        }
    }
}
