using static Лаб15.AlarmForMediator;

namespace Лаб15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmMediator alarmMediator = new(new CoffeePot(), new Sprinkler());
            CalendarMediator calendarMediator = new(new CoffeePot(), new Sprinkler());

            Alarm alarm = new(alarmMediator);
            Calendar calendar = new(calendarMediator);

            calendar.OnEvent();
            alarm.OnEvent();

            Console.ReadLine();
        }
    }
}
