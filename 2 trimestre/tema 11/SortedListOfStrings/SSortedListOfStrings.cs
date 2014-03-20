using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListOfStrings
{
	public class SSortedListOfStrings
	{
		static List<string> _Sortedlist = new List<string>();

		private void Add(string newstring)
		{

		}

		private void Get (int n)
		{
			Console.WriteLine(_Sortedlist[n]);
		}

		private int Getsize()
		{
			int size = 0;
			int i = 0;

			while (_Sortedlist[i] != null)
			{
				size++;
			}
			return size;
		}

		private void Remove (int n)
		{
			_Sortedlist[i].s;
		}
	}
}
