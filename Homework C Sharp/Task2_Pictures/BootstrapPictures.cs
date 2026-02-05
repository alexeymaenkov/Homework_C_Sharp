namespace Homework_C_Sharp.Task2_Pictures;

public class BootstrapPictures
{
    public void Run()
    {
        const int PICS_IN_LINE = 3;

        int picsCount = 52;

        int linesCount = picsCount / PICS_IN_LINE;
        int picsRemainder = picsCount % PICS_IN_LINE;
        
        Console.WriteLine($"Полностью заполненных рядов можно вывести: {linesCount}.");
        Console.WriteLine($"Картинок сверх меры: {picsRemainder}.");
    }
}