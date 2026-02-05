namespace Homework_C_Sharp.Task4_Crystal_Store;

public class BootstrapCrystalStore
{
    public void Run()
    {
        const int CRYSTAL_COST = 5;
        
        Console.Write("Введите начальное количество золота: ");
        int userGold = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Стоимость одного кристалла: {CRYSTAL_COST}.\nСколько кристаллов вы хотите купить? ");
        int crystals = Convert.ToInt32(Console.ReadLine());

        userGold -= crystals * CRYSTAL_COST;

        Console.WriteLine($"Вы купили {crystals} кристаллов. У вас осталось {userGold} золота.");
    }
}