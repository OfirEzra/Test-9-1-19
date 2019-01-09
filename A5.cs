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
			while (true)
			{
				Console.WriteLine("for how many grades you want to calculate the averages for?");
				int length = int.Parse(Console.ReadLine());
				int[] grades = new int[length];
				Console.WriteLine("enter grades:");
				for(int i = 0; i < length; i++)
				{
					grades[i] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine(avg(grades));
			}
		}
		private static float avg(params int[] grades)
		{
			float sum = 0;
			for(int i = 0; i < grades.Length; i++)
			{
				sum = sum + grades[i];
			}
			return sum / grades.Length;
		}
	}
}
