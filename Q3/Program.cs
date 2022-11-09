using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}
	public static class StringExtensions
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool isInt = int.TryParse(value, out int result);
			return isInt ? result : defaultValue;	
		}
	}
	
}
