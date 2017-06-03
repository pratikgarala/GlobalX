using System;
using System.Collections.Generic;
using System.Reflection;
namespace GlobalX
{
    public class ConvertObjectToLine
    {
        //default constructor
        public ConvertObjectToLine()
        {
        }

		//converting list of objects into list of string
		public List<string> ConvertSpecificObjectToLine<T>(List<T> listOfObjects)
		{
			List<string> listOfRecords = new List<string>();
            string line;
			for (int i = 0; i < listOfObjects.Count; i++)
			{
                line = "";
                PropertyInfo[] properties = listOfObjects[i].GetType().GetProperties();
                foreach(PropertyInfo property in properties)
                {
                    line = line + property.GetValue(listOfObjects[i],null).ToString().Trim();
                    line = line + ", ";
                }
                line = line.Substring(0, line.Length - 2);
                listOfRecords.Add(line);
			}
			return listOfRecords;
		}
    }
}
