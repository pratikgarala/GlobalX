using System;
using System.IO;
using System.Collections.Generic;

namespace GlobalX
{
	// Class for writing File Content
	public class WriteFile
    {
		//instance Variable
		string filePath;

		//constructor with parameter
		public WriteFile(string filePath)
        {
            this.filePath = filePath;
        }

		//WriteListToFile method to store the content of list into File
		public void WriteListToFile(List<string> list)
        {
			try
			{
				StreamWriter outputfile = new StreamWriter(filePath);
				for (int i = 0; i < list.Count; i++)
				{
					outputfile.WriteLine(list[i]);
				}
                Console.WriteLine("Finished : Please find sorted file at " + filePath);
				outputfile.Close();
			}
			catch (Exception)
			{
				Console.WriteLine("Sorry File Path is incorrect.");
			}
        }
    }
}
