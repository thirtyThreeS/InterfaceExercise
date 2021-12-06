using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle
    {
        public bool removableSeating { get; set; }
        public bool wheelChairAccessible { get; set; }
        public int SeatingCapacity { get; set; }
        public string Model { get; set; }
        public int MPG { get; set; }
        public string IgnitionType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
