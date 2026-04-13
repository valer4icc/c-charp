using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1 - Temperatūrų anomalija");
            Console.WriteLine("2 - 1000 skaičių grupavimas procentais");
            Console.WriteLine("0 - Baigti");
            Console.Write("Pasirinkite užduotį: ");

            string? choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Task1Temperature.Run();
                    break;

                case "2":
                    Task2Groups.Run();
                    break;

                case "0":
                    Console.WriteLine("Programa baigta.");
                    return;

                default:
                    Console.WriteLine("Neteisingas pasirinkimas.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
