using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Hotel : TourismDestination
    {
        public string? HotelName { get; set; }
        public int AvailableRooms { get; set; }

        public Hotel(string? name, string? country, int rating, string? hotelName, int availableRooms) :
            base(name, country, rating)
        {
            HotelName = hotelName;
            AvailableRooms = availableRooms;
            Name = name;
            Country = country;
            Rating = rating;

        }
        public Hotel() { }

        public async Task HotelBooking(int numOfRoom,Hotel h)
        {
           
           
                if(numOfRoom < h.AvailableRooms )
                {
                    Console.WriteLine("Booking in progress ......");
                    await Task.Delay(1000);
                    h.AvailableRooms -= numOfRoom;

                Console.WriteLine("Booked" + numOfRoom + " in Hotel "
                    + h.HotelName);
                        Console.WriteLine("Available rooms in Hotel: " + h.HotelName
                        + " is " + h.AvailableRooms);
                
                }
                else{
                    await Task.Delay(1000);
                    Console.WriteLine(numOfRoom + " rooms are not available in hotel "+h.HotelName);
                }
                
                
            
            
            
        }
    }
}
