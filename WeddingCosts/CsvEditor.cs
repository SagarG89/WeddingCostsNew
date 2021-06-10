//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CsvHelper;
//using System.IO;

//namespace WeddingCosts
//{
//    class CsvEditor
//    {
//        public static bool recordMatches(string searchTerm, string[] record, int positionofSearchTerm)
//        {
//            if (record[positionofSearchTerm].Equals(searchTerm))
//            {
//                return true;
//            }
//            return false;
//        }
//        public static void DeleteFromCsv(string searchTerm, string filePath, int positionOfSearchTerm, ref bool readOrAddCost, ref bool userWantsToDeleteCost)
//        {

//            string tempFile = "text.csv";
//            bool deleted = false;

//            try
//            {
//                string[] lines = System.IO.File.ReadAllLines(@filePath);
//                for (int i = 0; i < lines.Length; i i++)
//                {
//                    string[] fields = lines[i].Split(',');

//                    if (!(recordMatches(searchTerm, fields, positionOfSearchTerm)) || deleted)
//                    {
//                        Console.WriteLine(fields[0]);
//                    }
//                    else
//                    {
//                        deleted = true;
//                        Console.WriteLine("Cost deleted");
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error");
//                throw new ApplicationException("Error", ex);

//            }

//            File.Delete(filePath);
//            System.IO.File.Move(tempFile, filePath);


//            ////deletes line from file (NOT FUNCTIONING)
//            //while (!userWantsToDeleteCost)
//            //{
//            //    Console.WriteLine("Press Q to quit or any key to return");
//            //    string userQuitDelete = Console.ReadLine();
//            //    if (userQuitDelete == "Q")
//            //    {
//            //        userWantsToDeleteCost = true;
//            //        readOrAddCost = true;

//            //    }
//            //}

//        }

//        internal static void DeleteFromCsv(object searchTerm, string filePath, object positionOfSearchTerm, bool readOrAddCost, bool userWantsToDeleteCost)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}



      
    


