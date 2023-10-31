using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class RoomReservation<T> : HotelRoom
    {
        
        public void Booking<T>(int roomNum)
        {
            if( RoomNumber == roomNum)
            {
                IsBooked = true;
                Console.WriteLine("Booking confirmed");
            }
            else
            {
                Console.WriteLine("Booking not available" +
                    " with this Room number");
            }
              
            
            
        }

        public void Cancelation<T>(int roomNum)
        {
            if(RoomNumber == roomNum && IsBooked == true)
            {
                
                Console.WriteLine("Booking Canceled");
            }
            else
            {
                Console.WriteLine("Cannot cancel because " +
                    " no booking available with" +
                    " this Room number");
            }
            
        }
    }
}
