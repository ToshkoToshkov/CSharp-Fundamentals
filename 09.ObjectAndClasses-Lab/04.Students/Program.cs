
List<Student> students = new List<Student>(); 

string input = Console.ReadLine();

while (input != "end")
{
    string[] currInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string firstName = currInput[0];
    string lastName = currInput[1];
    int age = int.Parse(currInput[2]);
    string hometown = currInput[3];

    Student student = new Student()
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        Hometown = hometown
    };

    students.Add(student);
    input = Console.ReadLine();
}

string filteredCity = Console.ReadLine();

foreach (var student in students)
{
    if (student.Hometown == filteredCity)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}
