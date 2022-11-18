using _05.Students;

List<Student> students = new List<Student>();

string input = Console.ReadLine();

while (input != "end")
{
    string[] currInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string firstName = currInput[0];
    string lastName = currInput[1];
    int age = int.Parse(currInput[2]);
    string hometown = currInput[3];

    Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

    if (student == null)
    {
        students.Add(new Student()
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            Hometown = hometown
        });
    }
    else
    {
        student.FirstName = firstName;
        student.LastName = lastName;
        student.Age = age;
        student.Hometown = hometown;
    }

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