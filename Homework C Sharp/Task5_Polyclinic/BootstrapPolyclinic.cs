namespace Homework_C_Sharp.Task5_Polyclinic;

public class BootstrapPolyclinic
{
    public void Run()
    {
        const int RECEPTION_TIME = 10;
        const int MINUTES_IN_HOURE = 60;

        Console.Write("Введите кол-во пациентов: ");
        int numberOfPatients = Convert.ToInt32(Console.ReadLine());
        
        int timeMinutes = numberOfPatients * RECEPTION_TIME;
        int waitingTimeHours = timeMinutes / MINUTES_IN_HOURE;
        int waitingTimeMinutes = timeMinutes % MINUTES_IN_HOURE;

        Console.WriteLine($"Вы должны отстоять в очереди {waitingTimeHours} часа(ов) и {waitingTimeMinutes} минут.");
    }
}
