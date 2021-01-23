using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5v2
{
    public class FlightBuilder
    {
        List<Pilot> p = new List<Pilot>();
        List<City> c = new List<City>();
        Plane pl;
        
        public Flight Build(Administrator admin)
        {
            Flight flight = new Flight() {admin= admin, city= c, pilot =p, plane =pl};
            pl = null;
            p = new List<Pilot>();
            c = new List<City>();
            return flight;

        }
        public FlightBuilder Pilot(Pilot pilot)
        {
            p.Add(pilot);
            return this;
        }

        public FlightBuilder City(City city)
        {
            c.Add(city);
            return this;
        }

        public FlightBuilder Plane(Plane plane)
        {
            this.pl =plane;
            return this;
        }
    }
}
