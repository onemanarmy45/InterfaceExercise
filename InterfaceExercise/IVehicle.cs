using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int NumberOfSeats { get; set; }
		public int NumberOfWheels { get; set; }
		public int MPG { get; set; }
		public int Year { get; set; }
	}
}

