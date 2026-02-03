namespace Homework_C_Sharp.Task4_Crystal_Store;

public class BootstrapCrystalStore
{
    public void Run()
    {
        const int costOneCrystal = 5;
        
        Console.Write("Введите начальное количество золота: ");
        int userGold = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Стоимость одного кристалла: {costOneCrystal}.\nСколько кристаллов вы хотите купить? ");
        int userCrystal = Convert.ToInt32(Console.ReadLine());

        userGold -= userCrystal * costOneCrystal;

        Console.WriteLine($"Вы купили {userCrystal} кристаллов. У вас осталось {userGold} золота.");
    }
}