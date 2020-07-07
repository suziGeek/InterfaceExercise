using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {

        public bool HasTrunk { get; set; } = false;
        public int DoorsQnty { get; set; } = 4;

        public void Color()
        {
            Console.WriteLine("Yellow");
        }

        public void CompanyName()
        {
            Console.WriteLine("Car Comapny Name");
        }

        public void CompanySlogan()
        {
            Console.WriteLine("Car Comapny Slogan");
        }

        public void Doors()
        {
            Console.WriteLine("2");
        }

        public void Trunk()
        {
            Console.WriteLine("I haveno trunk") ;
        }

        public void Wheels()
        {
            Console.WriteLine("4");
        }
    }
}
