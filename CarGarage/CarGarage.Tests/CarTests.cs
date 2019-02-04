using System;
using Xunit;

namespace CarGarage.Tests
{
       public class CarTests
        {
            [Fact]
            public void shouldAccelerate()
            {
                // Tests Accelerate() method in Car increases Speed
                // Arrange
                var CyberCar = new CyberCar();

                // Act
                CyberCar.Accelerate();

                // Assert
                Assert.Equal(10, CyberCar.Speed);

            }

            [Fact]
            public void shouldConsumeFuel()
            {
                // Tests Accelerate() method reduces Fuel amount
                // Arrange
                var CyberCar = new CyberCar();

                // Act
                CyberCar.Accelerate();

                // Assert
                Assert.Equal(90, CyberCar.GasLevel);
            }

            [Fact]
            public void shouldRefuel()
            {
                // Tests AddFuel() method increases Fuel amount
                // Arrange
                var CyberCar = new CyberCar(50);

                // Act
                CyberCar.AddFuel();

                // Assert
                Assert.Equal(100, CyberCar.GasLevel);
            }

            [Fact]
            public void shouldSlowDown()
            {
                // Tests Brake() method in Car reduces Speed amount
                // Arrange
                var CyberCar = new CyberCar();

                // Act
                CyberCar.Accelerate();
                CyberCar.Brake();

                // Assert
                Assert.Equal(0, CyberCar.Speed);
            }

            [Fact]
            public void shouldStart()
            {
                // Tests ToggleEngine() method starts car when its off
                // Arrange
                var CyberCar = new CyberCar();

                // Act
                CyberCar.ToggleEngine();

                // Assert
                Assert.True(CyberCar.CarStarted);
            }

            [Fact]
            public void shouldTurnOff()
            {
                // Tests ToggleEngine() method turns car off when its on
                // Arrange
                var CyberCar = new CyberCar();

                // Act
                CyberCar.ToggleEngine();
                CyberCar.ToggleEngine();

                // Assert
                Assert.False(CyberCar.CarStarted);
                
            }
        }
    }

