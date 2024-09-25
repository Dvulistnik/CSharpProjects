using lab6;

Student student = new Student("Ko", 15);

try
{
    student = new Student("dsfsd19", 12);
} catch (ArgumentException ex) when (ex.Message.Contains("cannot contain numbers"))
{
    Console.WriteLine("Имя не должно содержать цифры");
} catch (ArgumentException ex) when (ex.Message.Contains("cannot contain special characters"))
{
    Console.WriteLine("Имя не должно содержать специальные символы");
} finally
{
    Console.WriteLine("Конец программы");
}