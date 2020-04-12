using System;

namespace Solar_System
{
    class SolarSystem 
    {
        public string planetName; // название планеты 
        public double diametrOfPlanet; //  диаметр планеты
        public string massOfPlanet; // масса планеты 
        public double distanceOfThePlanetFromTheSun; // расстояние планеты от солнца
        public int numberOfHoursPerDay; // количество часов в день
        public int numberOfDaysPerYear; // количество дней в году
        public int numberOfSatellites; // количество спутников
        public SolarSystem(){}
        public SolarSystem(string a, double b, string c, double d, int e, int f, int g)
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Планета: {planetName}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Количество спутников {numberOfSatellites}");
            Console.WriteLine($"Диаметр: {diametrOfPlanet} км");
            Console.WriteLine($"Масса {massOfPlanet} кг");
            Console.WriteLine($"Расстояние планеты от Солнца: {distanceOfThePlanetFromTheSun} км");
            Console.WriteLine($"Количество часов в день: {numberOfHoursPerDay} земных часов");
            Console.WriteLine($"Количество дней в году {numberOfDaysPerYear} земных дней");
            if (planetName != "Земля")
            {
                Console.WriteLine($"Сравнение часов в день(Земля и {planetName}) на : {ComparisonOfTheNumberOfHoursPerDayEarthAndAnotherPlanet(numberOfHoursPerDay) } больше чем на Земле");
                Console.WriteLine($"Сравнение дней в году(Земля и {planetName}) на: {ComparisonOfTheNumberOfDaysInAYearEarthAndAnotherPlanet(numberOfDaysPerYear)} больше чем на Земле");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string [] planetsName = {"Юпитер","Марс", "Земля", "Венера", "Меркурий", "Плутон", "Нептун", "Уран", "Сатурн"};
            double []  diametrs = {142984, 6794, 12742, 12100, 4879.4, 2374, 49500, 50724, 120536 };
            string[] mass = {"1.9*10^24", "6.42*10^23", "5.97*10^24", "4.87*10^24", "3.33*10^23", "(1,303 ± 0,003)⋅1022", "1.02*10^26", "8.68*10^25", "5.68*10^26"};
            double[] distance = {778000000,228000000,149500000,108000000,58000000,5929000000, 4496000000, 2880000000 ,1426000000};
            int [] hoursday = {10, 24, 24, 5832, 1408, 154, 16, 16, 10 };
            int [] dayyear = {4380, 687, 365, 82125, 792,  91250, 60152, 30660, 10950};
            int [] satellites = {67, 2, 1, 0, 0, 5, 13, 27, 62};
            for (int i = 0; i < 9; i++)
            {
                SolarSystem Sol = new SolarSystem(planetsName[i], diametrs[i], mass[i], distance[i], hoursday[i], dayyear[i], satellites[i]);
                Sol.GetInfo();
            }
            

        }
    }
}
