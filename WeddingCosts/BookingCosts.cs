using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingCosts
{
    public class BookingCosts
    {
        

        public string Booking { get; }
        public int Cost { get; }
        
        public BookingCosts (string booking, int cost)
        {
            this.Booking = booking;
            this.Cost = cost;
        }

    }
}
