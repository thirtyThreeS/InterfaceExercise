using System;
using System.Collections.Generic;
using System.Text;

/*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
