using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public int NumberOfSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public int MPG { get; set; }
        public int Year { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }

        public bool HasTrunk { get; set; }
        public bool AWD { get; set; }
        
    }
}

