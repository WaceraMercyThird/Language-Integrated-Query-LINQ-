// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;
using System.IO;

namespace UnderstandingLINQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Make = "BMW", Model = "550i", Year = 1996, StrickerPrice = 55000 },
                new Car()
                {
                    VIN = "B2", Make = "Land Rover", Model = "Discovery 4", Year = 1978, StrickerPrice = 35000
                },
                new Car() { VIN = "C3", Make = "BMW", Model = "745li", Year = 1987, StrickerPrice = 75000 },
                new Car() { VIN = "D4", Make = "Ford", Model = "Escape", Year = 2000, StrickerPrice = 25000 },
                new Car() { VIN = "E5", Make = "BMW", Model = "55i", Year = 1988, StrickerPrice = 57000 },
            };
            
            //LINQ query
            var bmws = from car in myCars 
                where car.Make == ("BMW") 
                && car.Year == 1988
                select car;
            
            
            var orderedCars = from car in myCars
                orderby car.Year ascending
                select car;
            
            var newCars = from car in myCars 
                where car.Make == ("BMW") 
                     
                select new { car.Make, car.Model};
            Console.WriteLine(newCars.GetType());
                
              
              


            //LINQ Method

            
            var bmws1 = myCars.Where(p => p.Make == "BMW");
            var orderedCars1 = myCars.OrderByDescending(p => p.Year);
            

            foreach (var car in  bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
                Console.WriteLine(bmws.GetType());
            }
            
            foreach (var car in bmws1)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
                Console.WriteLine("  ");
                Console.WriteLine(bmws1.GetType());
            }
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
                Console.WriteLine("  ");
                Console.WriteLine(orderedCars.GetType());
            }
            foreach (var car in orderedCars1)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
                Console.WriteLine("  ");
            }
            Console.WriteLine(myCars.GetType());
            
            

            Console.ReadLine();




        }
        
        
    }
    
    
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int StrickerPrice { get; set; }
    }
}
