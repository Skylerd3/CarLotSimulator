using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var CarLotOne = new CarLot();
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var CarOne = new Car();

            CarOne.Make = "Ford";

            CarOne.Model = "Mustang";

            CarOne.Year = 2016;

            CarOne.isDriveable = true;

            CarOne.MakeEngineNoise("vroom vroom");

            CarOne.MakeHonkNoise("beep beep");

            CarLotOne.ParkingLot.Add(CarOne);



            var CarTwo = new Car()
            {
                Make = "Toyota",
                Model = "Tundra",
                Year = 2001,
                isDriveable = false
            };

            CarTwo.MakeEngineNoise("Roar");
            CarTwo.MakeHonkNoise("a Loud horn");
            CarLotOne.ParkingLot.Add(CarTwo);


            var CarThree = new Car("Ferrari", "Spider", 2025, true);

            CarThree.MakeEngineNoise("purr");
            CarThree.MakeHonkNoise("beep");
            CarLotOne.ParkingLot.Add(CarThree);


            CarLotOne.CheckCars();
                


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
