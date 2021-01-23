using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator admin = new Administrator() { FirstName = "Игорь", LastName = "Макар"};
            Pilot pilot = new Pilot() { firstName = "Пётр" , lastName = "Верзилов"};
            City city = new City() { Start = "Гродно", Middle = "Минск", End = "Москва"};
            Plane plane = new Plane() { Name = "ТУ-126", Capacity = "123" };

            FlightBuilder flightBuilder = new FlightBuilder();
            flightBuilder.City(city)
                .Pilot(pilot)
                .Plane(plane)
                .Build(admin);
            


            Console.ReadLine();
        }
    }
}
