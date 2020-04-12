using System;

namespace SolarSystem
{
    class SolarSystem 
    {
        public string planetName;
        public double diametrOfPlanet;
        public double massOfPlanet;
        public double distanceOfThePlanetFromTheSun;
        public SolarSystem(){}
        public SolarSystem(string a, double b, double c, double d)
        {
            this.planetName = a;
            this.diametrOfPlanet = b;
            this.massOfPlanet = c;
            this.distanceOfThePlanetFromTheSun = d;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
