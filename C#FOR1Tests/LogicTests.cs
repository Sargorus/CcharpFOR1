using Microsoft.VisualStudio.TestTools.UnitTesting;
using C_FOR1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FOR1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void MonthWhenIncreaseExceedsDeposit100LimitIncome2()
        {
            var InitialDeposit = 100;
            var LimitIncomeDeposit = 2;

            var monthIncrease = Logic.CompareMonthWhenIncreaseExceeds(InitialDeposit, LimitIncomeDeposit);

            Assert.AreEqual(2, monthIncrease);
        }

        [TestMethod()]
        public void MonthWhenIncreaseExceedsDeposit123LimitIncomeDeposit123()
        {
            var InitialDeposit = 123;
            var LimitIncomeDeposit = 123;

            var monthIncrease = Logic.CompareMonthWhenIncreaseExceeds(InitialDeposit, LimitIncomeDeposit);

            Assert.AreEqual(199, monthIncrease);

        }


        [TestMethod()]
        public void MonthsExceedSumWhenDepisit123Limit332p5 ()
        {

            var InitialDeposit = 123;
            var LimitDeposit = 332.5;

            var monthsExceed = Logic.CompareMonthsExceedSum(InitialDeposit, LimitDeposit);

            Assert.AreEqual(51, monthsExceed);

            Assert.Fail();
        }

        [TestMethod()]
        public void MonthsExceedSumWhenDepisit10400Limit2025000p()
        {

            var InitialDeposit = 10400;
            var LimitDeposit = 205000;

            var monthsExceed = Logic.CompareMonthsExceedSum(InitialDeposit, LimitDeposit);

            Assert.AreEqual(151, monthsExceed);
        }
    }
}