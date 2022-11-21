using _04.Students;
using System.Collections.Generic;
using System.Diagnostics;

int countOfStudents = int.Parse(Console.ReadLine());

List<Student> students = new List<Student>();

for (int i = 0; i < countOfStudents; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string firstName = input[0];
    string secondName = input[1];
    double grade = double.Parse(input[2]);

    Student student = new Student()
    {
        FirstName = firstName,
        SecondName = secondName,
        Grade = grade
    };

    students.Add(student);
}

List<Student> orderedStudents = new List<Student>();

orderedStudents = students.OrderByDescending(x => x.Grade).ToList();

foreach (Student student in orderedStudents)
{
    Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade}");
}