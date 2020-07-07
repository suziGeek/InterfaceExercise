using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public void CompanySlogan() { Console.WriteLine( "SUV Company Slogan"); }
        public void CompanyName()
        {
            Console.WriteLine( "SUV Company Name");
        }

        public void CargoSize() 
        {
            Console.WriteLine("This SUV a huge cargo area");           
        }

        

        public void OffRoad() 
        {
            Console.WriteLine("This SUV can go off road");
        }

        public void Wheels()
        {
            Console.WriteLine(4) ;
        }

        public void Doors()
        {
            Console.WriteLine(2);
        }

        public void Trunk()
        {
            Console.WriteLine("Big Trunk");
        }

        public void Color()
        {
            Console.WriteLine("Blue");
        }
    }
}
