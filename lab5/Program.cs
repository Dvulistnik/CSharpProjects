using lab5;

IPerson s1 = new Student("Кто-то", 19);
ISpecialist itS = new ITStudent("Что-то", 22);

s1.WriteInfo();

itS.WriteInfo();
((Student) itS).WriteInfo();

itS.DoSomthing();
//((Student)itS).DoSomthing(); ошибка