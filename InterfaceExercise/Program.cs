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

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            var car = new Car();
            car.Make = "Honda";
            car.Model = "Civic";
            car.HasTrunk = true;
            car.GasMileage = 25;
            car.HasTint = true;
            car.NumberOfWheels = 4;
            car.IsPublic = true;
            car.Name = "Honda";


            var truck = new Truck();
            truck.HasTint = true;
            truck.NumberOfWheels = 6;
            truck.Make = "Ford";
            truck.Model = "F-150";
            truck.HorsePower = 256;
            truck.HasBedCover = true;
            truck.IsPublic = true;
            truck.Name = "Ford";


            var suv = new SUV();
            suv.NumberOfWheels = 4;
            suv.NumberOfSeats = 6;
            suv.CanOffRoad = true;
            suv.HasTint = false;
            suv.Make = "Toyota";
            suv.Model = "4-Runner";
            suv.IsPublic = true;
            suv.Name = "Toyota";

            var CarList = new List<IVehicle>() { car, truck, suv};

            foreach(var vehicle in CarList)
            {
                Console.WriteLine($"This is a {vehicle.Make} {vehicle.Model} it has {vehicle.NumberOfWheels} wheels. Does it have a tint? {vehicle.HasTint}!\n");
            }


            

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
