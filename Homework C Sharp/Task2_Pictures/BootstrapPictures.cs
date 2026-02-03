namespace Homework_C_Sharp.Task2_Pictures;

public class BootstrapPictures
{
    public void Run()
    {
        //На экране, в специальной зоне, выводятся картинки, по 3 в ряд (условно, ничего рисовать не надо).
        //Всего у пользователя в альбоме 52 картинки. Код должен вывести,
        //сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.

        //В качестве решения ожидаются объявленные переменные с необходимыми значениями и,
        //основываясь на значениях переменных, вывод необходимых данных. По задаче требуется выполнить простые математические действия.

        //Для обозначения количества картинок в одном ряду используйте константу.

        const int picsInLine = 3;

        int userPics = 52;

        int numberOfWholeLines = userPics / picsInLine;
        int theRemainderOfPics = userPics % picsInLine;

        Console.WriteLine($"Полностью заполненных рядов можно вывести: {numberOfWholeLines}.");
        Console.WriteLine($"Картинок сверх меры: {theRemainderOfPics}.");
    }
}