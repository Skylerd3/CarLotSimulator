using System;
namespace CarLotSimulator
{
	public class Car
	{
		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool isDriveable { get; set; }
	 
		public void MakeEngineNoise(string engineNoise)
		{
			EngineNoise = engineNoise;
			Console.WriteLine($"The {Year} {Make} {Model} has a engine that sounds like {EngineNoise}.");

		}

		public void MakeHonkNoise(string honkNoise)
		{
			HonkNoise = honkNoise;
			Console.WriteLine($"The {Year} {Make} {Model} has a honk noise that sounds like {HonkNoise}.");
		}

		public Car()
		{

		}
		public Car(string make, string model, int year, bool IsDriveable)
		{
			Make = make;
			Model = model;
			Year = year;
			IsDriveable = isDriveable;


		}

		

		

    }


}

