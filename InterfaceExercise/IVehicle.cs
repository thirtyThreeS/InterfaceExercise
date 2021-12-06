using System;
using System.Collections.Generic;
using System.Text;

//In your IVehicle

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: All vehicles have a number of wheels... for now..
 */

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public int SeatingCapacity { get; set; }
        public string Model { get; set; }
        public int MPG { get; set; }
        public string IgnitionType { get; set; }


    }
}
