using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
    {
		public Truck()
		{
		}

        public int NumberOfSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public int MPG { get; set; }
        public int Year { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }

        public double BedSize { get; set; }
        public bool FXF { get; set; }
    }
}

