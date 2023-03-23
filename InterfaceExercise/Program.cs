using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var vehicles = new List<IVehicle>();

            var accord = new Car()
            {
                NumberOfSeats = 5,
                NumberOfWheels = 4,
                MPG = 27,
                Year = 1998,
                Logo = "H",
                Name = "HONDA",
                HasTrunk = true,
                AWD = false
            };

            var truck = new Truck()
            {
                NumberOfSeats = 6,
                NumberOfWheels = 4,
                MPG = 18,
                Year = 2017,
                Logo = "F",
                Name = "FORD",
                BedSize = 5.5,
                FXF = true
            };

            var jeep = new SUV()
            {
                NumberOfSeats = 5,
                NumberOfWheels = 4,
                MPG = 27,
                Year = 2014,
                Logo = "S",
                Name = "SUBARU",
                CargoSize = 371.0,
                HasSunroof = true
            };

            vehicles.Add(accord);
            vehicles.Add(truck);
            vehicles.Add(jeep);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Number of Seats: {veh.NumberOfSeats}, Number of Tires: {veh.NumberOfWheels}");
                Console.WriteLine($"Miles Per Gallon: {veh.MPG}, Year: {veh.Year}");
                Console.WriteLine("");
            }
        }
    }
}
