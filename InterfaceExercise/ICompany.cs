using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
/*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

{
    interface ICompany
    {
        public void CompanyName();
        public void CompanySlogan();
    }
}
