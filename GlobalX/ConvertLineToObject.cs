using System;
using System.Collections.Generic;

namespace GlobalX
{
    public class ConvertLineToObject
    {
        public ConvertLineToObject()
        {
        }
		public List<T> ConvertLineToSpecificObject<T>(List<string> listOfRecords) where T : new()
		{
			//converting list of string into list of persons
			List<T> listOfSpecificObject = new List<T>();
			for (int i = 0; i < listOfRecords.Count; i++)
			{
				listOfSpecificObject.Add((T)Activator.CreateInstance(typeof(T), listOfRecords[i]));
			}
			return listOfSpecificObject;
		}
    }
}
