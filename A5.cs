using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	class A5
	{

		static void Main(string[] args)
		{
			Console.WriteLine(Numbers(4, 10, 12, -8, 111));
		}
		private static int Numbers(params int[] arrayOfNumber)
		{
			int sum = 0;
			for (int i = 0; i < arrayOfNumber.Length; i++)
			{
				sum = sum + arrayOfNumber[i];
			}
			return sum;
		}
	}
}
