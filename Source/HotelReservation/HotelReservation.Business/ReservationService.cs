using HotelReservation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Business
{
    public class ReservationService
    {
        public List<Room> GetAvailableRooms(DateTime? BookingStart, DateTime? BookingEnd)
        {
            return new List<Room>() { new Room() };
        }

        //public bool ReserveRoom(int roomId, int bookingId, int customerId)
        //{
            
        //}


    
    }
}
