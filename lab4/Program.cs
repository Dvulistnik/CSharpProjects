using lab4;

Person s1 = new Student("Кто-то", 19);
ITStudent itS = new ITStudent("Что-то", 22);

s1.WriteInfo();

itS.WriteInfo();
((Student) itS).WriteInfo();

Console.WriteLine();
Console.WriteLine(s1);