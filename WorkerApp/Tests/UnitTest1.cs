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

            // �������� �� 8 ����� ������ ����
            Assert.IsTrue(hours * salary > 0);
        }

        [TestMethod]
        public void IsOverwork()
        {
            float hours = 9;

            // ����� �� �����������, ���� ����������� 9 �����
            Assert.IsTrue(hours > 8);
        }
    }
}