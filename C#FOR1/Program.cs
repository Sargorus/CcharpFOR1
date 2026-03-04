namespace C_FOR1
{
    public class Logic
    {
        public static string CompareTrainInStation(int ArrivalHour, int ArrivalMinute, int DepartureHour, int DepartureMinute, int PassengerHour, int PassengerMinute)
        {
            int TimeArrive = ArrivalHour * 60 + ArrivalMinute;
            int TimeDeparture = DepartureHour * 60 + DepartureMinute;
            int TimePassenger = PassengerHour * 60 + PassengerMinute;

            if (TimeArrive >= TimeDeparture) return "Время прибытия позже времени отбытия или равно ему!";
            if (TimePassenger < TimeDeparture && TimePassenger > TimeArrive)
            {
                return "Поезд находится на станции";
            }
            else
            {
                return "Поезд не находится на станции";
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную сумму вклада:");
            var InitialDeposit = double.Parse(Console.ReadLine());

            Console.Write("Введите число В. где число В это порог для ежемесячного увеличения вклада");
            var LimitInterestAccruals = double.Parse(Console.ReadLine());

            Console.Write("Введите число C, где С это через сколько месяцев размер вклада превысит C руб.");
            var LimitDeposit = double.Parse(Console.ReadLine());

            // var monthIncrease = Logic.CompareTrainInStation(ArrivalHour, ArrivalMinute, DepartureHour, DepartureMinute, PassengerHour, PassengerMinute);
            // var monthsExeceed = Logic.

            // Console.WriteLine(resultMSG);
            // 
        }
    }
}
