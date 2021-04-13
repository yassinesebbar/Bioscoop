using Bioscoop.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBioscoop
{
    [TestClass]
    public class TestHall
    {
        [TestMethod]
        public void AutomateCountSeats()
        {
            Hall hall = new Hall();
            hall.Rows = 5;
            hall.SeatsPerRow = 10;

            hall.CalculateSeats();

            int seats = hall.Rows * hall.SeatsPerRow;

            Assert.AreEqual(seats, hall.NumSeats);
        }
    }
}
