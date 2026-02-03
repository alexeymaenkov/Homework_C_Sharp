namespace Homework_C_Sharp.Task3_Swapping_values;

public class BootstrapSwappingValues
{
    public void Run()
    {
        //Даны две переменные. Поменять местами значения двух переменных.
        //Вывести на экран значения переменных до перестановки и после.

        //Два примера:
        
        //1. Есть две переменные имя и фамилия, они сразу инициализированные, но данные не верные, перепутанные.
        //Эти данные надо поменять местами через код.
        
        //2. Есть две чашки, в одном кофе, во втором чай. Вам надо поменять местами содержимое чашек

        string name = "Maenkov";
        string surname = "Alex";

        Console.WriteLine($"Ваше имя: {name}.\nВаша фамилия: {surname}.");

        string temporaryStorage = name;
        
        name = surname;
        surname = temporaryStorage;
        
        Console.WriteLine($"\nВаше имя: {name}.\nВаша фамилия: {surname}.");
    }
}