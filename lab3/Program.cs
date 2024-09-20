using lab3;

Student.University = "СГУ";

StudentManagement.Students.Add(new("Kola"));
StudentManagement.Students.Add(new("Ira", 17));
StudentManagement.Students.Add(new()
{
    Name = "Vika",
    Age = 30,
});

foreach (Student s in StudentManagement.Students)
{
    s.WriteInfo();
    Console.WriteLine();
}

