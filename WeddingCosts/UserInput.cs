using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingCosts
{
    class UserInput
    {
        public static void UserInputLetter(string userInput)
        {
            bool userWantsToExit = false;

            do
            {
                switch (userInput)
                {
                    case "b":
                        Console.WriteLine($"Bandstand Cost = {Costs.BandStand}");
                        break;

                    case "v":
                        Console.WriteLine($"Venue Cost = {Costs.Venue}");
                        break;

                    case "q":
                        userWantsToExit = true;
                        break;
                }


            }


            while (!userWantsToExit);
                {
                    return;
                }

            
        }
    }
}


//Code below what I did originally, trying to get do while to make it loop but now running infinitely.. 

//if (userInput.Contains("b"))
//{
//    Console.WriteLine($"Bandstand Cost = {Costs.BandStand}");
//}
//if (userInput.Contains("v"))
//{
//    Console.WriteLine($"Venue Cost = {Costs.Venue}");
//}
//if (userInput.Contains("f"))
//{
//    Console.WriteLine($"Food Cost = {Costs.Food}");
//}
//if (userInput.Contains("c"))
//{
//    Console.WriteLine($"Cake Cost = {Costs.Cake}");
//}
//if (userInput.Contains("d"))
//{
//    Console.WriteLine($"Drinks Cost = {Costs.Drinks}");
//}
//if (userInput.Contains("de"))
//{
//    Console.WriteLine($"Decor Cost = {Costs.Decor}");
//}
//if (userInput.Contains("m"))
//{
//    Console.WriteLine($"Music Cost = {Costs.Music}");
//}
//if (userInput.Contains("h"))
//{
//    Console.WriteLine($"Hair Cost = {Costs.Hair}");
//}
//if (userInput.Contains("mu"))
//{
//    Console.WriteLine($"Make-Up Cost = {Costs.Makeup}");
//}
//if (userInput.Contains("p"))
//{
//    Console.WriteLine($"Photographer Cost = {Costs.Photographer}");
//}
//if (userInput.Contains("t"))
//{
//    Console.WriteLine($"Total Cost = {Costs.Total}");
//}
//if (userInput.Contains("q"))
//{
//    return;
//}
//else
//{
//    Console.WriteLine("This is not a valid option.");
//}