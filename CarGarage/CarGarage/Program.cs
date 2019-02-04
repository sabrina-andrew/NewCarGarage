using System;

namespace CarGarage
{
    class Program
    {
        static void Main(string[] args)
        {
        }
            static void MainMenu()

            {
                ParkingGarage myParkingGarage = new ParkingGarage();
                bool run = true;

                do
                {
                    Console.Clear();

                    Console.WriteLine("Main Menu:");
                    Console.WriteLine("Press 1 to add a car");

                    if (myParkingGarage.ListOfCars.Count > 0)
                    {
                        Console.WriteLine("Press 2 to display cars' information");
                        Console.WriteLine("Press 3 to display cars' stats");
                        Console.WriteLine("Press 4 to do something with a vehicle");
                        Console.WriteLine("Press 5 to remove a car");
                    }
                    Console.WriteLine("Press 0 to Quit");

                    ConsoleKeyInfo keyPressed = Console.ReadKey();

                    string menuChoice;

                    if (char.IsDigit(keyPressed.KeyChar))
                    {
                        menuChoice = keyPressed.KeyChar.ToString();
                    }
                    else
                    {
                        menuChoice = "default";
                    }

                    if (!menuChoice.Equals("1") && !menuChoice.Equals("0") && myParkingGarage.ListOfCars.Count == 0)
                    {
                        menuChoice = "-1";
                    }
                    switch (menuChoice)
                    {
                        case "0":
                            Console.WriteLine("\nSee you later alligator");
                            run = false;
                            break;
                        case "1":
                            Console.WriteLine("\nAdd Car: ");
                            myParkingGarage.AddNewCar();
                            break;
                        case "2":
                            myParkingGarage.DisplayCarInfo();
                            break;
                        case "3":
                            myParkingGarage.DisplayCarStats();
                            break;
                        case "4":
                            myParkingGarage.InteractionMenu();
                            break;
                        case "5":
                            myParkingGarage.RemoveCar();
                            break;
                        default:
                            Console.WriteLine("Please follow the instructions");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                    }

                } while (run);

            }
        }
    }

