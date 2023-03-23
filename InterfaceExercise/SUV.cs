using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
    {
		public SUV()
		{
		}

        public int NumberOfSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public int MPG { get; set; }
        public int Year { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }

        public double CargoSize { get; set; }
        public bool HasSunroof { get; set; }
    }
}

