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

            var carOne = new Car();

            carOne.Make = "Ford";

            carOne.Model = "Mustang";

            carOne.Year = 2016;

            carOne.isDriveable = true;

            carOne.MakeEngineNoise("vroom vroom");

            carOne.MakeHonkNoise("beep beep");

            CarLotOne.ParkingLot.Add(carOne);



            var carTwo = new Car()
            {
                Make = "Toyota",
                Model = "Tundra",
                Year = 2001,
                isDriveable = false
            };

            carTwo.MakeEngineNoise("Roar");
            carTwo.MakeHonkNoise("a Loud horn");
            CarLotOne.ParkingLot.Add(carTwo);


            var carThree = new Car("Ferrari", "Spider", 2025, true);

            carThree.MakeEngineNoise("purr");
            carThree.MakeHonkNoise("beep");
            CarLotOne.ParkingLot.Add(carThree);


            CarLotOne.CheckCars();
                


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
