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

            // var monthsExeceed = Logic.

            Console.WriteLine(monthIncrease);
            // 
        }
    }
}
