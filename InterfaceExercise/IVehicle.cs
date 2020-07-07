using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
/* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */

{
    interface IVehicle
    {
        public void Wheels();
        public void Doors();
        public void Trunk();
        public void Color();
    }
}
