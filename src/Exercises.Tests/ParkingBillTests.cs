using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class ParkingBillTests
    {
        [TestMethod]
        public void ParkingBill_Basic_1()
        {
            var exercise = new ParkingBill.Solution();

            Assert.AreEqual(17, exercise.solution("10:00", "13:21"));
        }

        [TestMethod]
        public void ParkingBill_Basic_2()
        {
            var exercise = new ParkingBill.Solution();

            Assert.AreEqual(9, exercise.solution("09:42", "11:42"));
        }

        [TestMethod]
        public void ParkingBill_Less_Than_One_Hour()
        {
            var exercise = new ParkingBill.Solution();

            Assert.AreEqual(5, exercise.solution("09:42", "9:45"));
        }

        [TestMethod]
        public void ParkingBill_One_Hour()
        {
            var exercise = new ParkingBill.Solution();

            Assert.AreEqual(5, exercise.solution("09:00", "10:00"));
        }

        [TestMethod]
        public void ParkingBill_Over_One_Hour()
        {
            var exercise = new ParkingBill.Solution();

            Assert.AreEqual(9, exercise.solution("05:30", "06:31"));
        }

        [TestMethod]
        public void ParkingBill_Two_Hours()
        {
            var exercise = new ParkingBill.Solution();

            Assert.AreEqual(9, exercise.solution("06:25", "08:25"));
        }

        [TestMethod]
        public void ParkingBill_Over_Two_Hour()
        {
            var exercise = new ParkingBill.Solution();

            Assert.AreEqual(13, exercise.solution("06:25", "08:31"));
        }
    }
}
