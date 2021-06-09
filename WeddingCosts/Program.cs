using System;
using System.Linq;
using CsvHelper;
using System.Collections.Generic;
using System.IO;




namespace WeddingCosts
{
    class Program
    {
        static void Main(string[] args)
        {
            //OG code
            //UI.UserInterface();

            //var userInput = Console.ReadLine();

            //UserInput.UserInputLetter(userInput);


            //I've used some help from previous tutorial code to write this up
            string filePath = @"C:\Users\sagar\source\repos\WeddingCosts\WeddingCosts\BookCost.csv";
            CsvReader reader = new CsvReader(filePath);
            bool userWantsToExit = false;

            Dictionary<string, List<BookingCosts>> bookings = reader.ReadBookingCosts();
            foreach (string booking in bookings.Keys)
                Console.WriteLine(booking);

            while (!userWantsToExit)
            {
                Console.Write("Which of the costs do you wish to see? ");
                string chosenBooking = Console.ReadLine();

                if (bookings.ContainsKey(chosenBooking))
                {
                    foreach (BookingCosts booking in bookings[chosenBooking].Take(1))
                        Console.WriteLine($"The cost of {booking.Booking} is {booking.Cost}");
                }
                else
                {
                    Console.WriteLine("That is not a valid cost");
                }
                Console.WriteLine("Continue? Y or N");
                string userChoice = Console.ReadLine();
                    if (userChoice == "N")
                {
                    userWantsToExit = true;
                }
           
            }
        }
    }
}

