namespace Homework_C_Sharp.Task5_Polyclinic;

public class BootstrapPolyclinic
{
    public void Run()
    {
        const int receptionTime = 10;
        const int minutesInHour = 60;

        Console.Write("Введите кол-во пациентов: ");
        int numberOfPatients = Convert.ToInt32(Console.ReadLine());
        
        int waitingTime = numberOfPatients * receptionTime;
        int waitingTimeHours = waitingTime / minutesInHour;
        int waitingTimeMinutes = waitingTime % minutesInHour;

        Console.WriteLine($"Вы должны отстоять в очереди {waitingTimeHours} часа(ов) и {waitingTimeMinutes} минут.");
    }
}