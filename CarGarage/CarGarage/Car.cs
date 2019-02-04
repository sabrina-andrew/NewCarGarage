using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{

    public class CyberCar
    {
        public int Speed { get; private set; }
        public int GasLevel { get; private set; }
        public bool CarStarted { get; private set; }
        public string CarName { get; private set; }
        public string Color { get; private set; }
        public string Model { get; private set; }
        public int Year { get; set; }
        public string Make { get; set; }

        public CyberCar()
        {
            //Set Stats
            Speed = 0;
            GasLevel = 100;
            CarStarted = false;

        }
        public void AddCar()
        {
            int proceedOkay;
            for (int questionNum = 0; questionNum < 4; questionNum += proceedOkay)
            {
                proceedOkay = 0;
                string errorCheck;
                int number;
                switch (questionNum)
                {
                    case 0:
                        Console.WriteLine("\nWhat is the model of your vehicle?");
                        errorCheck = Console.ReadLine();
                        if (errorCheck.Length > 0)
                        {
                            Model = errorCheck;
                            proceedOkay = 1;
                        }
                        break;
                    case 1:
                        Console.WriteLine("What is the make of your vehicle?");
                        errorCheck = Console.ReadLine();
                        if (errorCheck.Length > 0)
                        {
                            Make = errorCheck;
                            proceedOkay = 1;
                        }
                        break;
                    case 2:
                        Console.WriteLine("What is the year of your vehicle?");
                        errorCheck = Console.ReadLine();
                        if (errorCheck.Length > 0 && int.TryParse(errorCheck, out number))
                        {
                            Year = Convert.ToInt32(errorCheck);
                            proceedOkay = 1;
                        }
                        break;
                    case 3:
                        Console.WriteLine("What color is your car?");
                        errorCheck = Console.ReadLine();
                        if (errorCheck.Length > 0)
                        {
                            Color = errorCheck;
                            proceedOkay = 1;
                        }
                        break;
                }
                errorCheck = "hello";
                if (errorCheck.Length > 0)
                {

                }
            }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine("\nYear: " + Year);
            Console.WriteLine("\nMake: " + Make);
            Console.WriteLine("\nModel: " + Model);
            Console.WriteLine("\nColor: " + Color);

        }

        public void DisplayCarStats()
        {
            Console.WriteLine("\nCar Started: " + CarStarted);
            Console.WriteLine("\nGas Level: " + GasLevel);
            Console.WriteLine("\nSpeed: " + Speed);
        }

        public void Drive()
        {
            Console.WriteLine("You drove your car.");
        }

        public CyberCar(int startGasLevel)
        {
            Speed = 0;
            GasLevel = startGasLevel;
            CarStarted = false;
        }

        public void Accelerate()
        {
            Speed += 10;
            GasLevel -= 10;
        }

        public void TestDrive()
        {
            CarStarted = true;
            Accelerate();
            Console.WriteLine("You test drove a new car");
            if (GasLevel <= 100)
            {
                Console.WriteLine("You need to get gas");
            }

        }

        public void AddFuel()
        {
            Console.WriteLine("You put gas in your car");
            GasLevel = 100;
        }

      
        public void Brake()
        {
            Speed -= 10;

            if (Speed < 0)
            {
                Speed = 0;
            }
        }

        public void ToggleEngine()
        {
            CarStarted = !CarStarted;
        }
    }
}

