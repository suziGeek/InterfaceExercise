using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck: IVehicle, ICompany
    {
        public bool FourWheelDrive { get; set; } = true;
        public int BedSize { get; set; } = 5;

        public void Color()
        {
            Console.WriteLine("Red");
        }

        public void  CompanyName()
        {
            Console.WriteLine("Truck Comapny Name");
        }

        public void CompanySlogan()
        {
            Console.WriteLine("Truck Comapny Slogan");
        }

        public void Doors()
        {
            Console.WriteLine(2);
        }

        public void Trunk()
        {
            Console.WriteLine("Truck bed no trunk");
        }

        public void  Wheels()
        {
            Console.WriteLine("I have 4");
        }
    }
}
