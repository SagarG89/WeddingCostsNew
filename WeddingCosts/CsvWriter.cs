using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace WeddingCosts
{
    class CsvWriter
    {
        public static void WriteToCSV(string filePath, ref bool readOrAddCost, ref bool userWantsToAddCost, string newName, ref bool quitAdd)
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
}
