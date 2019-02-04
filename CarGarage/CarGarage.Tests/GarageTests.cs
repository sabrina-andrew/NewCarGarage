using System;
using Xunit;

namespace CarGarage.Tests
{
   public class GarageTests
    {
        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            // Arrange
            var xxx = new Garage();

            // Act
            xxx.AddNewCar();

            // Assert
            Assert.NotEmpty(xxx.ListOfCars);
        }

        [Fact]
        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method
            // Arrange
            var xxx = new Garage();

            // Act
            xxx.AddNewCar();
            xxx.RemoveCar(0);

            // Assert
            Assert.Empty(xxx.ListOfCars);
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            // Tests FuelAllCars() method
            // Arrange
            var xxx = new Garage();

            // Act
            xxx.ListOfCars.Add(new CyberCar(50));
            xxx.ListOfCars.Add(new CyberCar(50));
            xxx.FuelAllCars();

            // Assert

            int putGasInCars = xxx.ListOfCars[0].GasLevel + xxx.ListOfCars[1].GasLevel;
            Assert.Equal(200, putGasInCars);
        }

       [Fact]
        public void shouldTestDriveOneCar()
        {
            // Use the Program class to let you select a single car
            // Program class should then let you choose what you want to do with that car
            // You do not need to test user input in the Program class

            var xxx = new Garage();

            xxx.TestDrive();

            //Assert.Equal(100, xxx.TestDrive());
        }

        [Fact]
        public void StatsDontExceedMax()
        {
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats

            var xxx = new Garage();

            xxx.ListOfCars.Add(new CyberCar());
            xxx.ListOfCars[0].AddFuel();

            Assert.Equal(100, xxx.ListOfCars[0].GasLevel);
            

        }
    }
}
