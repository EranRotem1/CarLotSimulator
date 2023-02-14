using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            CarLot myLot = new CarLot();

            Car fastCar = new Car(2020, "Mercedes", "A-Class", "vroom", "Papapaaapa", true);
            myLot.Cars.Add(fastCar);
            Car ehCar = new Car(2000, "Subaru", "Outback", "rum rum rum", "hoonk", true);
            myLot.Cars.Add(ehCar);
            Car slowCar= new Car(1988, "Toyota", "TrashHeap", "...", "BAAAAAHHH", false);
            myLot.Cars.Add(slowCar);

            slowCar.Year = 1987;
            slowCar.Make = "Dodge";


            fastCar.MakeEngineNoise();
            fastCar.MakeHonkNoise();

            ehCar.MakeEngineNoise();
            ehCar.MakeHonkNoise();

            slowCar.MakeEngineNoise();
            slowCar.MakeHonkNoise();

            myLot.PrintDets();
        }
    }
    class Car
    {
        public Car(int _year, string _make, string _model, string _enginenoise, string _honknoise, bool _isdriveable) 
        {
            Year = _year;
            Make = _make;
            Model = _model;
            EngineNoise = _enginenoise;
            HonkNoise = _honknoise;
            IsDriveable = _isdriveable;
        }
        public int Year;
        public string Make;
        public string Model;
        public string EngineNoise;
        public string HonkNoise;
        public bool IsDriveable;

        public void MakeEngineNoise(string noise = "rrrrrrrr")
        {
            noise = EngineNoise;
            Console.WriteLine(noise);
        }

        public void MakeHonkNoise(string noise = "honk") 
        {
            noise = HonkNoise;
            Console.WriteLine(noise);
        }
    }

    class CarLot
    {
        public List<Car> Cars = new List<Car>();

        public void PrintDets()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($"{car.Make} {car.Model} specs: \nYear: {car.Year}\nMake: {car.Make}\nModel: {car.Model}\nDriveable: " +
                    $"{car.IsDriveable}\nEngine Noise: {car.EngineNoise}\nHonk Noise: {car.HonkNoise}\n\n");
            }
        }
    }
}
