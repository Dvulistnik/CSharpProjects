using lab1;
using System.Data.SqlTypes;

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

Student s1 =  students[0];

s1.favoriteSubject = new Subject("Книга какая-то");
s1.favoriteGame = new Game("WorldBox");

//s1.favoriteSubject.title = "Не придумал"; Ошбика, так как сеттор задан как приватный
Console.WriteLine(s1.favoriteSubject.title);

Subject subject;
Game game;
s1.getFavoriteSubjectAndGame(out subject, out game);

Console.WriteLine("\n" + "С помощью модификатора out из одного метода были получены два значения");
Console.WriteLine(subject.title);
Console.WriteLine(game.title);