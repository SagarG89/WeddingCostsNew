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
            

            //I've used some help from previous tutorial code to write this up

            string filePath = @"C:\Users\sagar\source\repos\WeddingCosts\WeddingCosts\BookCost.csv";
            CsvReader reader = new CsvReader(filePath);
            bool readOrAddCost = false;
            bool userWantsToViewCosts = false;
            bool userWantsToAddCost = false;
            //bool userWantsToDeleteCost = false;

            Dictionary<string, List<BookingCosts>> bookings = reader.ReadBookingCosts();
            foreach (string booking in bookings.Keys)
                Console.WriteLine($"{booking}");
            Console.WriteLine("-------------------------------");

            while (!readOrAddCost)
            {
                Console.WriteLine("Press V to View Costs,  A to add or D to Delete.");
                string userChoice = Console.ReadLine();

                if (userChoice == "V")
                {
                    while (!userWantsToViewCosts)
                    {
                        CsvReader.ReadFromCsv(ref readOrAddCost, ref userWantsToViewCosts, bookings);

                    }
                }
                if (userChoice == "A")
                {
                    Console.WriteLine("Please write the Name and Cost (ex. Name, Cost)");
                    string newName = Console.ReadLine();
                    bool quitAdd = false;

                    //adds to file but wanted to add above Total. Not sure CSV can do maths operations so deleted total.
                    while (!userWantsToAddCost)
                    {
                        CsvWriter.WriteToCSV(filePath, ref readOrAddCost, ref userWantsToAddCost, newName, ref quitAdd);

                    }
                }
                //if (userChoice == "D")
                //{

                //    while (!userWantsToDeleteCost)
                //    {
                //        CsvEditor.DeleteFromCsv(string searchTerm, string filePath, int positionOfSearchTerm, ref bool readOrAddCost, ref bool userWantsToDeleteCost);
                //    } 
                //}
            }
        }

    }
}


