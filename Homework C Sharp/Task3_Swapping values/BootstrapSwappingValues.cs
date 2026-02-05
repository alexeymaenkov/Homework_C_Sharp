namespace Homework_C_Sharp.Task3_Swapping_values;

public class BootstrapSwappingValues
{
    public void Run()
    {
        string name = "Maenkov";
        string surname = "Alex";

        Console.WriteLine($"Ваше имя: {name}.\nВаша фамилия: {surname}.");

        string tempStorage = name;
        
        name = surname;
        surname = tempStorage;
        
        Console.WriteLine($"\nВаше имя: {name}.\nВаша фамилия: {surname}.");
    }
}