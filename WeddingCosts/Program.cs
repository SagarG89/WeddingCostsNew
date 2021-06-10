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
            bool readOrAddCost = false;
            bool userWantsToViewCosts = false;
            bool userWantsToAddCost = false;
            bool userWantsToDeleteCost = false;
           
            

           
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
                        Console.WriteLine("Press Q to quit or any key to return");
                        string userQuitView = Console.ReadLine();
                        if (userQuitView == "Q")
                        {
                            userWantsToViewCosts = true;
                            readOrAddCost = true;
                        }

                    }

                }

                if (userChoice == "A")
                {
                    Console.WriteLine("Please write the Name and Cost (ex. Name, Cost)");
                    string newName = Console.ReadLine();
                    bool quitAdd = false;
                

                    //adds to file but wanted to add above Total. Not sure CSV can do maths operations so deleted total. Also does not show after when trying to view without typing the full entry.
                    while (!userWantsToAddCost)
                    {

                       
                            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                            {
                                using (StreamWriter sw = new StreamWriter(fs))
                                {
                                    Console.WriteLine($"{newName} added Successfully.");
                                    sw.WriteLine(newName);
                                }
                            }

                        Console.WriteLine("Press Q to quit");
                        while (!quitAdd)
                        {
                            string userQuitAdd = Console.ReadLine();
                            if (userQuitAdd == "Q")
                            {
                                userWantsToAddCost = true;
                                readOrAddCost = true;
                                quitAdd = true;
                            }
                            else
                            {
                                Console.WriteLine("Press Q to quit!");
                            }
                        }
                        

                      

                      
                    }
                }
                    if (userChoice == "D")
                    {
                        Console.WriteLine("Write the name of the Record you wish to Delete");
                        string deleteLine = Console.ReadLine();

                        //deletes line from file (NOT FUNCTIONING. 
                        while (!userWantsToDeleteCost)
                        {
                            if (deleteLine.Contains(deleteLine))
                            {
                                while (filePath.Contains(deleteLine))
                                {
                                    bookings.Remove(deleteLine);
                                }

                               
                            }
                            Console.WriteLine("Press Q to quit or any key to return");
                            string userQuitDelete = Console.ReadLine();
                            if (userQuitDelete == "Q")
                            {
                                userWantsToDeleteCost = true;
                            readOrAddCost = true;
                               
                            }
                        }
                    }
                

            }
         


           
        }
    }
}

