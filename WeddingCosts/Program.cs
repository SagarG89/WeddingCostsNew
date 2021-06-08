using System;
using System.Linq;

namespace WeddingCosts
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.UserInterface();

            var userInput = Console.ReadLine();

            UserInput.UserInputLetter(userInput);

        }

        

    }
    }


