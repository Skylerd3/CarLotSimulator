using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
	public class CarLot
	{
		public List<Car> ParkingLot { get; set; } = new List<Car>();
		
		public void CheckCars()
		{
			foreach (var Vehicle in ParkingLot)
			{
				Console.WriteLine($"{Vehicle.Make} {Vehicle.Model} {Vehicle.Year}");
			}
		}
	}
}

