using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle
    {
        public bool extendedCab { get; set; }
        public int bedSizeFeet { get; set; }
        public int SeatingCapacity { get; set; }
        public string Model { get; set; }
        public int MPG { get; set; }
        public string IgnitionType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
