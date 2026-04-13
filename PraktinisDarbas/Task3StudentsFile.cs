using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class Task3StudentsFile
{
    public static void Run()
    {
        List<Student> students = new List<Student>();
        string fileName = "students.txt";

        Console.WriteLine("Įveskite mokinių vardus ir jų balus.");
        Console.WriteLine("Norėdami baigti, palikite vardą tuščią.");

        while (true)
        {
            Console.Write("Vardas: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                break;
            }

            Console.Write("Balas: ");
            string? scoreInput = Console.ReadLine();

            if (int.TryParse(scoreInput, out int score))
            {
                students.Add(new Student(name, score));
            }
            else
            {
                Console.WriteLine("Neteisingas balas. Įrašas nepridėtas.");
            }
        }

        List<string> linesToWrite = new List<string>();

        foreach (Student student in students)
        {
            linesToWrite.Add($"{student.Name},{student.Score}");
        }

        File.WriteAllLines(fileName, linesToWrite);
        Console.WriteLine($"\nDuomenys išsaugoti faile: {fileName}");

        List<Student> loadedStudents = new List<Student>();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            if (parts.Length == 2 && int.TryParse(parts[1], out int score))
            {
                loadedStudents.Add(new Student(parts[0], score));
            }
        }

        List<Student> sortedStudents = loadedStudents
            .OrderByDescending(s => s.Score)
            .ToList();

        Console.WriteLine("\nMokiniai surūšiuoti pagal balą mažėjančia tvarka:");
        foreach (Student student in sortedStudents)
        {
            Console.WriteLine($"{student.Name} - {student.Score}");
        }
    }
}
