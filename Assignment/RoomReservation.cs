using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class RoomReservation<T> where T  : HotelRoom
    {
        private List<T> _rooms;

        public RoomReservation(List<T> rooms)
        {
            _rooms = rooms;
        }

        
        public void Booking(int roomNum)
        {
            bool book = false;
            foreach (T room in _rooms)
            {
                if (room.RoomNumber == roomNum && room.IsBooked == false)
                {
                    room.IsBooked = true;
                    book  = true;
                    Console.WriteLine("Booking confirmed");
                    break;
                }
            }

                if (!book) 
                {
                    Console.WriteLine("Room is already booked");
                }

            
            
        }

        public void Cancelation(int roomNum)
        {
            bool book = false;

            foreach (T room in _rooms)
            {
                if (room.RoomNumber == roomNum && room.IsBooked == true)
                {
                    room.IsBooked = false;
                    book = true;
                    Console.WriteLine("Cancelled");
                    break;
                }
            }
                if (!book) 
                {
                    Console.WriteLine("Room is not occupied");
                }

        
        }
    }
}
