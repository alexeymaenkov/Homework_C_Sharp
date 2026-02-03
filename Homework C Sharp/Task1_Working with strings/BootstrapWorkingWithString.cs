using System.Xml;

namespace Homework_C_Sharp.Task1_Working_with_strings;

public class BootstrapWorkingWithString
{
    public void Run()
    {
        //Вы задаете вопросы пользователю, по типу "как вас зовут", "какой ваш знак зодиака" и т.д.,
        //и пользователь отвечает на вопросы. После чего, по данным, которые он ввел, формируете небольшой текст о пользователе.

        //Пример текста о пользователе
        //"Вас зовут Алексей, вам 21, вы водолей и работаете на заводе."
        
        string name;
        string age;
        string zodiac;
        string work;

        Console.Write("Введите ваше Имя: ");
        name = Console.ReadLine();
        Console.Write("Введите ваш возраст: ");
        age = Console.ReadLine();
        Console.Write("Введите ваше знак зодиака: ");
        zodiac = Console.ReadLine();
        Console.Write("Введите место вашей работы: ");
        work = Console.ReadLine();

        Console.WriteLine($"Вас зовут: {name}, ваш возраст: {age}, ваш знак зодиака: {zodiac}, место вашей работы: {work}.");
    }
}