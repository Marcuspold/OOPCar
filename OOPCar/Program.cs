using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string markname;
            string modelname;
            string registration;
            string color;
            int odometer;
            int fueltank;

            public Car(string _markname, string _modelname, string _registration, string _color)
            {
                markname = _markname;
                modelname = _modelname;
                registration = _registration;
                color = _color;
                odometer = 0;
                fueltank = 60;
                Console.WriteLine($"The {modelname} of the car has been created");
            }

            public string Registration
            {
                get { return registration; }
                set
                {
                    if (value.Length == 6)
                    {
                        Registration = value;
                    }else
                    {
                        registration = "ERROR FAILURE";
                    }
                }
            }
            public string Color
            {
                get { return color; }
            }
            public void ShowCarData()
            {
                Console.WriteLine($"markname: {markname}; modelname: {modelname}; registration {registration}; color {color}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car newCar = new Car("Audi", "T8", "TV343", "yellow" );
            Console.WriteLine(newCar.Color);
            Console.WriteLine(newCar.Registration);


        }
    }
}
