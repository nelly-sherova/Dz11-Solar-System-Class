using System;

namespace SolarSystem
{
    class SolarSystem 
    {
        public string planetName; // название планеты 
        public double diametrOfPlanet; //  диаметр планеты
        public double massOfPlanet; // масса планеты 
        public double distanceOfThePlanetFromTheSun; // расстояние планеты от солнца
        public int numberOfHoursPerDay; // количество часов в день
        public int numberOfDaysPerYear; // количество дней в году
        public int numberOfSatellites; // количество спутников
        public SolarSystem(){}
        public SolarSystem(string a, double b, double c, double d, int e, int f, int g)
        {
            this.planetName = a;
            this.diametrOfPlanet = b;
            this.massOfPlanet = c;
            this.distanceOfThePlanetFromTheSun = d;
            this.numberOfHoursPerDay = e;
            this.numberOfDaysPerYear = f;
            this.numberOfSatellites = g;
        }
        public int ComparisonOfTheNumberOfHoursPerDayEarthAndAnotherPlanet(int numberOfHoursPerDay)
        {
            this.numberOfHoursPerDay = numberOfHoursPerDay;
            return numberOfHoursPerDay-24;
        }
        public int ComparisonOfTheNumberOfDaysInAYearEarthAndAnotherPlanet(int numberOfDaysPerYear)
        {
            this.numberOfDaysPerYear = numberOfDaysPerYear;
            return numberOfDaysPerYear - 365;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Планета: {planetName}");
            Console.WriteLine($"количество спутников {numberOfSatellites}");
            Console.WriteLine($"Диаметр: {diametrOfPlanet}");
            Console.WriteLine($"Масса {massOfPlanet}");
            Console.WriteLine($"Расстояние планеты от Солнца: {distanceOfThePlanetFromTheSun}");
            Console.WriteLine($"Количество часов в день: {numberOfHoursPerDay}");
            Console.WriteLine($"Количество дней в году {numberOfDaysPerYear}");
            if (planetName != "Земля")
            {
                Console.WriteLine($"Сравнение часов в день(Земля и {planetName}): {ComparisonOfTheNumberOfHoursPerDayEarthAndAnotherPlanet(numberOfHoursPerDay)}");
                Console.WriteLine($"Сравнение дней в году(Земля и {planetName}: {ComparisonOfTheNumberOfDaysInAYearEarthAndAnotherPlanet(numberOfDaysPerYear)}");
            }
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
