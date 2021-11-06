using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            var CarLot = new CarLotl();
            CarLot.ParkingLot = new List<Car>();

            // Standard member initialization

            var volvo = new Car();
            volvo.Year = 2018;
            volvo.Make = "Volvo";
            volvo.Model = "2018i";
            volvo.EngineNoise = "Voom";
            volvo.HonkNoise = "Beep beep";
            volvo.IsDriveable = true;

            CarLot.ParkingLot.Add(volvo);

            //Object initializer syntax

            var kia = new Car() { Year = 2018, Make = "Kia", Model = "Kia", EngineNoise = "Veemveem", HonkNoise = "Help", IsDriveable = true };

            CarLot.ParkingLot.Add(kia);

            kia.MakeEngineNoise();
            kia.MakeHonkNoise();

            //Constructor initialization

            var someOtherCar = new Car(4000, "Mars Inc.", "Alpha ++", "Space Noise", "Does a space ship Honk?");

            CarLot.ParkingLot.Add(someOtherCar);

            someOtherCar.MakeEngineNoise();
            someOtherCar.MakeHonkNoise();



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var vehicle in CarLot.ParkingLot)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                vehicle.MakeEngineNoise();
                vehicle.MakeHonkNoise();
                Console.WriteLine();
            }
        }
    }
}

 