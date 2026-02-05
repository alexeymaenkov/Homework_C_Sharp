using System.Xml;

namespace Homework_C_Sharp.Task1_Working_with_strings;

public class BootstrapWorkingWithString
{
    public void Run()
    {
        Console.Write("Введите ваше Имя: ");
        string name = Console.ReadLine();
        
        Console.Write("Введите ваш возраст: ");
        string age = Console.ReadLine();
        
        Console.Write("Введите ваше знак зодиака: ");
        string zodiac = Console.ReadLine();
        
        Console.Write("Введите место вашей работы: ");
        string work = Console.ReadLine();

        Console.WriteLine($"Вас зовут: {name}, ваш возраст: {age}, ваш знак зодиака: {zodiac}, место вашей работы: {work}.");
    }
}