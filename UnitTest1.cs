using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrivingTests
{
    public class Driving
    {
        public bool CanDrive(int age)
        {
            const int drivingAge = 16;
            return age >= drivingAge;
        }
    }

    [TestClass]
    public class DrivingTests
    {
        private Driving _driving;

        [TestInitialize]
        public void Setup()
        {
            // Initialize the class before each test
            _driving = new Driving();
        }

        [TestMethod]
        [Description("Test when age is exactly the driving age (16)")]
        public void CanDrive_ExactlyDrivingAge_ReturnsTrue()
        {
            // Arrange
            int age = 16;

            // Act
            bool result = _driving.CanDrive(age);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Description("Test when age is above driving age")]
        public void CanDrive_AboveDrivingAge_ReturnsTrue()
        {
            // Arrange
            int[] ages = { 17, 18, 21 };

            // Act & Assert
            foreach (int age in ages)
            {
                bool result = _driving.CanDrive(age);
                Assert.IsTrue(result);
            }
        }

        [TestMethod]
        [Description("Test when age is below driving age")]
        public void CanDrive_BelowDrivingAge_ReturnsFalse()
        {
            // Arrange
            int[] ages = { 15, 14, 0 };

            // Act & Assert
            foreach (int age in ages)
            {
                bool result = _driving.CanDrive(age);
                Assert.IsFalse(result);
            }
        }

        [TestMethod]
        [Description("Test with negative age values")]
        public void CanDrive_NegativeAge_ReturnsFalse()
        {
            // Arrange
            int[] ages = { -1, -100 };

            // Act & Assert
            foreach (int age in ages)
            {
                bool result = _driving.CanDrive(age);
                Assert.IsFalse(result);
            }
        }

        [TestMethod]
        [Description("Test with very large age values")]
        public void CanDrive_LargeAge_ReturnsTrue()
        {
            // Arrange
            int[] ages = { 100, 1000 };

            // Act & Assert
            foreach (int age in ages)
            {
                bool result = _driving.CanDrive(age);
                Assert.IsTrue(result);
            }
        }
    }
}