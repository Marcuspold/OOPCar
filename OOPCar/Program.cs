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
            public string Markname
            {
                get { return markname; }
            }
            public string Modelname
            {
                get { return modelname; }
            }
            public string Color
            {
                get { return color; }
            }
            public int Odometer
            {
                get { return odometer; }
            }
            public int Fueltank
            {
                get { return fueltank; }
            }
            public void ShowCarData()
            {
                Console.WriteLine($"markname: {markname}; modelname: {modelname}; registration {registration}; color {color}");
            }
            public void Drive()
            {
                odometer += 100;
                fueltank -= 5;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car newCar = new Car("Audi", "T8", "TV343", "yellow" );
            Console.WriteLine(newCar.Color);
            Console.WriteLine(newCar.Registration);
            Console.WriteLine(newCar.Markname);
            Console.WriteLine(newCar.Modelname);
            Console.WriteLine(newCar.Odometer);
            Console.WriteLine(newCar.Fueltank);
        }
    }
}
