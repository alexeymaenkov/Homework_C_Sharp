namespace Homework_C_Sharp.Task5_Polyclinic;

public class BootstrapPolyclinic
{
    public void Run()
    {
        const int reception_time = 10;
        const int minutes_in_hour = 60;

        Console.Write("Введите кол-во пациентов: ");
        int numberOfPatients = Convert.ToInt32(Console.ReadLine());
        
        int timeMinutes = numberOfPatients * reception_time;
        int waitingTimeHours = timeMinutes / minutes_in_hour;
        int waitingTimeMinutes = timeMinutes % minutes_in_hour;

        Console.WriteLine($"Вы должны отстоять в очереди {waitingTimeHours} часа(ов) и {waitingTimeMinutes} минут.");
    }
}
