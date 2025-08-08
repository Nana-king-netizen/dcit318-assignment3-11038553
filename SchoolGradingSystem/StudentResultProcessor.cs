using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolGradingSystem
{
    internal class StudentResultProcessor
    {
        public List<Student> ReadStudentsFromFile(string inputFilePath)
        {
            var students = new List<Student>();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');

                    if (parts.Length != 3)
                        throw new MissingFieldException($"Missing fields in line: {line}");

                    int id;
                    if (!int.TryParse(parts[0].Trim(), out id))
                        throw new FormatException($"Invalid ID format in line: {line}");

                    string fullName = parts[1].Trim();
                    int score;
                    if (!int.TryParse(parts[2].Trim(), out score))
                        throw new InvalidScoreFormatException($"Invalid score format in line: {line}");

                    students.Add(new Student
                    {
                        Id = id,
                        FullName = fullName,
                        Score = score
                    });
                }
            }
            return students;
        }

        public void WriteReportToFile(List<Student> students, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.FullName} (ID: {student.Id}): Score = {student.Score}, Grade = {student.GetGrade()}");
                }
            }
        }
    }
}
