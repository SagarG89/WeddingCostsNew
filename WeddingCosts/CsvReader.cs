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

        public CsvReader(string csvFilePath)
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
                while ((bookCostLine = sr.ReadLine()) != null)
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

        public static void ReadFromCsv(ref bool readOrAddCost, ref bool userWantsToViewCosts, Dictionary<string, List<BookingCosts>> bookings)
        {
            Console.Write("Which of the costs do you wish to see? ");
            string chosenBooking = Console.ReadLine();

            if (bookings.ContainsKey(chosenBooking))
            {
                foreach (BookingCosts booking in bookings[chosenBooking].Take(1))
                    Console.WriteLine($"The cost of {booking.Booking} is £{booking.Cost}");
            }
            else
            {
                Console.WriteLine("That is not a valid cost");
            }
            Console.WriteLine("Press Q to quit or any key to return");
            string userQuitView = Console.ReadLine();
            if (userQuitView == "Q")
            {
                userWantsToViewCosts = true;
                readOrAddCost = true;
            }
        }
    }
    }



