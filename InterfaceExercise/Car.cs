using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle
    {
        public int trunkSizeFeet { get; set; }
        public bool offRoadCapability { get; set; }
        public int SeatingCapacity { get; set; }
        public string Model { get; set; }
        public int MPG { get; set; }
        public string IgnitionType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
