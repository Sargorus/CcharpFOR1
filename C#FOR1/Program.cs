namespace C_FOR1
{
    public class Logic
    {
        public static int CompareMonthWhenIncreaseExceeds(double InitialDeposit, double LimitIncomeDeposit)
        {
            int mount = 1;
            double currentDeposit = InitialDeposit;

            while (true)
            {
                double IncomeDeposit = currentDeposit * 0.02;
                if (IncomeDeposit > LimitIncomeDeposit)
                {
                    return mount;
                }
                else
                {
                    currentDeposit = currentDeposit + IncomeDeposit;
                    mount += 1;
                }
                //Console.WriteLine(currentDeposit);
                //Console.WriteLine(IncomeDeposit);
                //Console.WriteLine(mount);
            }

        }

        public static int CompareMonthsExceedSum(double InitialDeposit, double LimitDeposit)
        {
            int mount = 0;
            double currentDeposit = InitialDeposit;

            while (currentDeposit <= LimitDeposit)
            {
                currentDeposit = currentDeposit + (currentDeposit * 0.02);
                mount += 1;
                //Console.WriteLine(currentDeposit);
                //Console.WriteLine(mount);
            }
            return mount;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную сумму вклада: ");
            var InitialDeposit = double.Parse(Console.ReadLine());

            Console.Write("Введите число В. где число В это порог для ежемесячного увеличения вклада ");
            var LimitIncomeDeposit = double.Parse(Console.ReadLine());

            Console.Write("Введите число C, где С это через сколько месяцев размер вклада превысит C руб. ");
            var LimitDeposit = double.Parse(Console.ReadLine());

            var monthIncrease = Logic.CompareMonthWhenIncreaseExceeds(InitialDeposit, LimitIncomeDeposit);
            var monthsExceed = Logic.CompareMonthsExceedSum(InitialDeposit, LimitDeposit);

            Console.WriteLine($"Ежемесячный процент дохода превысит {LimitIncomeDeposit}  через {monthIncrease} мес.");
            Console.WriteLine($"Размер вклада превысит {LimitDeposit}  через {monthsExceed} мес.");
        }
    }
}
