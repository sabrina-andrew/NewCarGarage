using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<CyberCar> ListOfCars { get; set; }

        public Garage()
        {
            ListOfCars = new List<CyberCar>();
        }

        public void AddNewCar()
        {
            CyberCar car = new CyberCar();

            car.AddCar();

            ListOfCars.Add(new CyberCar());

            // Console.WriteLine("\n" + CarName + " is parked in the garage.");
            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void RemoveCar(int whichCar)
        {
            Console.WriteLine("\nYou are going to remove your car from the garage");


            switch (whichCar)
            {
                case -2:
                    foreach (CyberCar car in ListOfCars)
                    {
                        Console.WriteLine("\n" + whichCar + " has left the garage.");
                        ListOfCars.Remove(ListOfCars[whichCar]);
                    }
                    ListOfCars.Clear();
                    break;
                case -1:
                    Console.WriteLine("\nCancelled");
                    break;
                default:
                    Console.WriteLine("\nPlease try again");
                    break;
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
        public void DisplayCarInfo()
        {
            Console.WriteLine("\nCar Information: ");

            int whichCar = CarSelectionMenu();
            switch (whichCar)
            {
                case -2:
                    foreach (CyberCar car in ListOfCars)
                    {
                        Console.WriteLine("\nInfo: ");
                        car.DisplayCarInfo();
                    }
                    break;
                case -1:
                    Console.WriteLine("\nCancelled");
                    break;
                default:
                    ListOfCars[whichCar].DisplayCarInfo();
                    break;
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void DisplayCarStats()
        {
            Console.WriteLine("\nCar Stats: ");
            int whichCar = CarSelectionMenu();
            switch (whichCar)
            {
                case -2:
                    foreach (CyberCar car in ListOfCars)
                    {
                        Console.WriteLine("\nStats: ");
                        car.DisplayCarStats();
                    }
                    break;
                case -1:
                    Console.WriteLine("\nCancelled");
                    break;
                default:
                    ListOfCars[whichCar].DisplayCarStats();
                    break;
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        public void InteractionMenu()
        {
            bool run = true;

            do
            {
                Console.Clear();

                Console.WriteLine("\nInteraction Menu");
                Console.WriteLine("Press 1 to drive your car");
                Console.WriteLine("Press 2 to put gas in your car");
                Console.WriteLine("Press 3 to test drive a car");
                Console.WriteLine("Press 0 to go back to the Main Menu");

                string interMenuChoice;

                ConsoleKeyInfo interKeyPressed = Console.ReadKey();

                if (char.IsDigit(interKeyPressed.KeyChar))
                {
                    interMenuChoice = interKeyPressed.KeyChar.ToString();
                }
                else
                {
                    interMenuChoice = "default";
                }
                switch (interMenuChoice)
                {
                    case "1":
                        DriveCar();
                        break;
                    case "2":
                        ListOfCars[CarSelectionMenu()].AddFuel();
                        break;
                    case "3":
                        TestDrive();
                        break;
                    case "0":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("\nPlease try to follow the instructions");
                        break;
                }
            } while (run);
        }

        public int CarSelectionMenu()
        {
            bool redo;
            int carSelectedNum;
            string carSelection;
            do
            {
                redo = false;

                for (int i = 0; i < ListOfCars.Count; i++)
                {
                    int carNum = i + 1;
                    Console.WriteLine("Press " + carNum + " for " + ListOfCars[i].CarName);
                }

                Console.WriteLine("Press A for all");
                Console.WriteLine("Press 0 to cancel\n");
                Console.WriteLine("Which car would you like to select?");
                ConsoleKeyInfo keyPressed = Console.ReadKey();

                carSelection = "-1";

                if (char.IsDigit(keyPressed.KeyChar))
                {
                    carSelection = keyPressed.KeyChar.ToString();
                    if (Convert.ToInt32(carSelection) > ListOfCars.Count)
                    {
                        redo = true;

                        Console.WriteLine("\nPlease follow the instructions.");
                    }
                }
                else
                {
                    if (!keyPressed.Key.Equals(ConsoleKey.A))
                    {
                        redo = true;
                        Console.WriteLine("Please follow the instructions");
                    }
                }

            } while (redo);
            carSelectedNum = Convert.ToInt32(carSelection) - 1;

            return carSelectedNum;
        }

        public void DriveCar()
        {
            Console.WriteLine("\nDrive Menu: ");

            int whichCar = CarSelectionMenu();
            switch (whichCar)
            {
                case -2:
                    foreach (CyberCar car in ListOfCars)
                    {
                        car.Drive();
                    }
                    break;
                case -1:
                    Console.WriteLine("\nCancelled");
                    break;
                default:
                    ListOfCars[whichCar].Drive();
                    break;
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public void GasCars()
        {
            Console.WriteLine("\nGas Menu");
            int whichCar = CarSelectionMenu();

            switch (whichCar)
            {
                case -2:
                    foreach (CyberCar car in ListOfCars)
                    {
                        car.AddFuel();
                    }
                    break;
                case -1:
                    Console.WriteLine("\nCancelled");
                    break;
                default:
                    ListOfCars[whichCar].AddFuel();
                    break;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public void TestDrive()
        {
            Console.WriteLine("\nTest Drive Menu");
            int whichCar = CarSelectionMenu();

            switch (whichCar)
            {
                case -2:
                    foreach (CyberCar car in ListOfCars)
                    {
                        car.TestDrive();
                    }
                    break;
                case -1:
                    Console.WriteLine("\nCancelled");
                    break;
                default:
                    ListOfCars[whichCar].TestDrive();
                    break;
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }


        public void FuelAllCars()
        {
            Console.WriteLine();
            foreach (CyberCar thisCar in ListOfCars)
            {
                thisCar.AddFuel();
            }
        }


    }
}
