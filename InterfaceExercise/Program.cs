using System;

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
            var suv = new SUV() { removableSeating = true, wheelChairAccessible = true, Description = "We care about the big families!", IgnitionType = "Key Fob", Model = "Escalade", MPG = 16, Name = "Cadillac", SeatingCapacity = 8 };
            var car = new Car() { offRoadCapability = true, trunkSizeFeet = 4, SeatingCapacity = 2, Name = "Ford", MPG = 22, Model = "Escort RS Cosworth", IgnitionType = "Key", Description = "Enjoy this off road rally car!" };
            var truck = new Truck() { bedSizeFeet = 7, Description = "Off Road Heavy Duty Truck that gets the job done!", extendedCab = true, SeatingCapacity = 6, IgnitionType = "Key Fob", Model = "Silverado", MPG = 18, Name = "Chevy" };
            
            //Creatively display and organize their values
            Console.WriteLine($"This beautiful {suv.Name} {suv.Model} has enough seats to sit up to {suv.SeatingCapacity} people! {suv.Description} \nMPG: {suv.MPG} \nIgnition Type: {suv.IgnitionType} \nRemovable Seating: {suv.removableSeating} \nWheel Chair Accesible: {suv.wheelChairAccessible}");
            Console.WriteLine("---");
            Console.WriteLine($"This quick {car.Name} {car.Model} has {car.SeatingCapacity} and can rip through the mud/dirt! {car.Description} \nMPG: {car.MPG} \nIgnition Type: {car.IgnitionType} \nRally Ready: {car.offRoadCapability} \nTrunk Size: {car.trunkSizeFeet} x 2 feet");
            Console.WriteLine("---");
            Console.WriteLine($"This {truck.Name} {truck.Model} is a work horse and can sit up to {truck.SeatingCapacity} people! {truck.Description} \nMPG: {truck.MPG} \nIgnition Type: {truck.IgnitionType} \nExtended Cab: {truck.extendedCab} \nBed Size: {truck.bedSizeFeet} x 4 feet");
        }
    }
}
