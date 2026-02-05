namespace Homework_C_Sharp.Task2_Pictures;

public class BootstrapPictures
{
    public void Run()
    {
        const int pics_in_line = 3;

        int picsCount = 52;

        int linesCount = picsCount / pics_in_line;
        int picsRemainder = picsCount % pics_in_line;
        
        Console.WriteLine($"Полностью заполненных рядов можно вывести: {linesCount}.");
        Console.WriteLine($"Картинок сверх меры: {picsRemainder}.");
    }
}