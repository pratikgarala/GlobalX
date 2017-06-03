using System;
using System.IO;
using System.Collections.Generic;

namespace GlobalX
{
    // Class for Reading File Content
    public class ReadFile
    {
        //instance Variable
        string filePath;

        //constructor with parameter
        public ReadFile(string filePath)
        {
            this.filePath = filePath;
        }

		//ReadFileToList method to store the content of file into list
		public List<string> ReadFileToList()
        {
            List<string> list = null;

            //try catch to check the correctness of the filePath
			try
			{
                list = new List<string>(File.ReadAllLines(filePath));
			}
			catch (Exception)
			{
				Console.WriteLine("Sorry File Path is incorrect.");
			}
            return list;
        }
    }
}