namespace Homework_C_Sharp.Task4_Crystal_Store;

public class BootstrapCrystalStore
{
    public void Run()
    {
        const int cost_one_crystal = 5;
        
        Console.Write("Введите начальное количество золота: ");
        int userGold = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Стоимость одного кристалла: {cost_one_crystal}.\nСколько кристаллов вы хотите купить? ");
        int crystals = Convert.ToInt32(Console.ReadLine());

        userGold -= crystals * cost_one_crystal;

        Console.WriteLine($"Вы купили {crystals} кристаллов. У вас осталось {userGold} золота.");
    }
}