using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPCProtoTypeBlazorV3.Shared.ApiOpkald;
using BPCProtoTypeBlazorV3.Shared.Model;

namespace BPCProtoTypeBlazorV3.Client.ViewModel
{
    public class BookingViewModel
    {
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        private BookingMetodeApi dbBookingMetodeApi = new BookingMetodeApi();

        public async Task GetBookings()
        {
            await dbBookingMetodeApi.GetAllBookings();
        }
    }
}
