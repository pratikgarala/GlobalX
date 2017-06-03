using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GlobalX
{
    // Main Class - Starting of the application
    class MainClass
    {
        // main method
        public static void Main(string[] args)
        {
            // Read File Path
            Console.WriteLine("Please enter file path: ");
            string filePath = Console.ReadLine();

            try
            {
                //Read File to List
                ReadFile readFile = new ReadFile(filePath);
                List<string> listOfRecords = readFile.ReadFileToList();

                //Convert list of records to list of person
                List<Person> listOfPersons = new ConvertLineToObject().ConvertLineToSpecificObject<Person>(listOfRecords);

                //Sort List of person 
                List<Person> sortedListOfPersons = new SortList().SortListInAscending<Person>(listOfPersons, "FName");

                //Print Sorted List
                for (int i = 0; i < sortedListOfPersons.Count; i++)
                {
                    Console.WriteLine("{0}, {1}", sortedListOfPersons[i].FName, sortedListOfPersons[i].LName);
                }

                listOfRecords = new ConvertObjectToLine().ConvertSpecificObjectToLine<Person>(sortedListOfPersons);

                //Write Sorted List to File
                WriteFile writeFile = new WriteFile(filePath.Substring(0, filePath.LastIndexOf('/') + 1) + "sortedFile.txt");
                writeFile.WriteListToFile(listOfRecords);
            }
            catch(Exception)
            {
                Console.WriteLine("Please rerun the program");
            }

        }

    }
}