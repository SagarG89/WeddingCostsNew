using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace WeddingCosts
{
    class CsvReader
    {

        private string _csvFilePath;

        public CsvReader (string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        public Dictionary<string, List<BookingCosts>> ReadBookingCosts()
        {
            var costs = new Dictionary<string, List<BookingCosts>>();

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();

                string bookCostLine;
                while ((bookCostLine = sr.ReadLine())!=null)
                {
                    BookingCosts booking = ReadBookingFromCsv(bookCostLine);
                    if (costs.ContainsKey(booking.Booking))
                    {
                        costs[booking.Booking].Add(booking);
                    }
                    else
                    {
                        List<BookingCosts> bookingsInList = new List<BookingCosts> { booking };
                        costs.Add(booking.Booking, bookingsInList);

                    }
                }
                    
            }

            return costs;
        }

        public BookingCosts ReadBookingFromCsv(string costs)
        {
            string[] parts = costs.Split(',');
            string booking = parts[0];
            string cost = parts[1];


            //confused here on how to get csvfile to read exactly 
            int.TryParse(cost, out int expense);
            return new BookingCosts(booking, expense);
        }
        
    }
}
