namespace Homework_C_Sharp.Task2_Pictures;

public class BootstrapPictures
{
    public void Run()
    {
        const int picsInLine = 3;

        int userPics = 52;

        int numberOfWholeLines = userPics / picsInLine;
        int theRemainderOfPics = userPics % picsInLine;

        Console.WriteLine($"Полностью заполненных рядов можно вывести: {numberOfWholeLines}.");
        Console.WriteLine($"Картинок сверх меры: {theRemainderOfPics}.");
    }
}