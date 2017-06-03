using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace GlobalX
{
	// Class for sorting the list
	public class SortList
    {
        //default constructor
        public SortList()
        {
        }

		//SortListInAscending method to sort list in ascending order based on sortBy property
        public List<T> SortListInAscending<T>(List<T> list, string sortBy)
        {
            return list.OrderBy(l => l.GetType().GetProperty(sortBy).GetValue(l, null)).ToList();
        }

		//SortListInDescending method to sort list in descending order based on sortBy property
		public List<T> SortListInDescending<T>(List<T> list, string sortBy)
		{
            return list.OrderByDescending(l => l.GetType().GetProperty(sortBy).GetValue(l,null)).ToList();
		}
	}
}