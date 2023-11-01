using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TourismDestination
    {
        public TourismDestination(string? name,
            string? country, int rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Rating { get; set; }
        //public static List<TourismDestination> tourismDestinations= new List<TourismDestination>();    

        
        public static void SortOnRating(List<TourismDestination> list)
        {
            if (list != null)
            {
                var rate = list.OrderByDescending(
                a => a.Rating);
                foreach (var l in rate)
                {
                    Console.WriteLine("Destination name: " + l.Name +
                        " Country: " + l.Country + " Rating: " + l.Rating);
                }
            }
            else
            {
                Console.WriteLine("No destination added");
            }
            

        }
    }
}
    

