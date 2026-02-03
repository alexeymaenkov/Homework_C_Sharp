namespace Homework_C_Sharp.Task5_Polyclinic;

public class BootstrapPolyclinic
{
    public void Run()
    {
        //Легенда:
        
        //Вы заходите в поликлинику и видите огромную очередь из пациентов, вам нужно рассчитать время ожидания в очереди.
        
        //Формально:
        
        //Пользователь вводит кол-во людей в очереди.
        //Фиксированное время приема одного человека всегда равно 10 минутам.
        //Пример ввода: Введите кол-во пациентов: 14
        //Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут."

        //Примечание:
        
        //- при расчетах надо использовать только переменные. Если число не присваивается переменной,
        //то в большинстве случаев это число магическое (исключение 0 и 1, но не во всех ситуациях).
        
        //- повторные расчеты так же стоит выносить в переменные

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