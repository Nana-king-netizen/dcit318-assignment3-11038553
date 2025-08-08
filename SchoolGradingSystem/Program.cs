using SchoolGradingSystem;
using System;
using System.Collections.Generic;
using System.IO;
using MissingFieldException = System.MissingFieldException;

class Program
{
    static void Main()
    {
        var processor = new StudentResultProcessor();
        try
        {
            string inputPath = "students.txt";
            string outputPath = "report.txt";

            List<Student> students = processor.ReadStudentsFromFile(inputPath);
            processor.WriteReportToFile(students, outputPath);

            Console.WriteLine("Report generated successfully!");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error: Input file not found. " + ex.Message);
        }
        catch (InvalidScoreFormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (MissingFieldException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
