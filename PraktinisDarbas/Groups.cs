using System;

public static class Task2Groups
{
    public static void Run()
    {
        Random random = new Random();
        int[] numbers = new int[1000];
        int[] groups = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
            int groupIndex = (numbers[i] - 1) / 10;
            groups[groupIndex]++;
        }

        Console.WriteLine("Grupių procentai:");

        for (int i = 0; i < groups.Length; i++)
        {
            int start = i * 10 + 1;
            int end = i * 10 + 10;
            double percent = groups[i] * 100.0 / numbers.Length;

            Console.WriteLine($"{start}-{end} -> {percent:F1}%");
        }
    }
}
