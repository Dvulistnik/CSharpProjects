using lab1;

Student[] students = { new Student("Костя"), new Student("Дима", 19) };

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i + " год");
    foreach (Student student in students)
    {
        student.WriteInfo();
        student.BecomeOlder();
    }
    Console.WriteLine();
}

