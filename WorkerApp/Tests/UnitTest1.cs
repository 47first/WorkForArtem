namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsSalaryPerHourMoreThanZero()
        {
            float hours = 8;
            float salary = 5;

            // Зарплата за 8 часов больше нуля
            Assert.IsTrue(hours * salary > 0);
        }

        [TestMethod]
        public void IsOverwork()
        {
            float hours = 9;

            // Будет ли переработка, если проработано 9 часов
            Assert.IsTrue(hours > 8);
        }
    }
}