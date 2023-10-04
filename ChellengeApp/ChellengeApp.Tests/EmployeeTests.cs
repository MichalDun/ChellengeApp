namespace ChellengeApp.Tests
{
    public class EmployeeTest
    {

        [Test]
        public void TestOfMaxValue()
        {
            
            var employee = new Employee("Michał", "Dunajewski");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(3);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Max);
        }

        [Test]
        public void TestOfMinValue()
        {
            var employee = new Employee("Michał", "Dunajewski");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(3);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void TestOfAvarageValue()
        {
            var employee = new Employee("Michał", "Dunajewski");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(3);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(3.33, Math.Round(statistics.Average, 2));
        }
    }
}
