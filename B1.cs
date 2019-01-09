using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	class B1
	{
		static Random r = new Random();
		static void Main(string[] args)
		{
			int[] a = CreateAndPopulate();
			for(int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
			Console.WriteLine("test");
			int[] b = CreateAndPopulate();
			for (int i = 0; i < b.Length; i++)
			{
				Console.WriteLine(b[i]);
			}
			Console.WriteLine("test");
			Console.WriteLine(Measure(a, b));
		}
		private static int[] CreateAndPopulate()
		{
			int[] toReturn = new int[r.Next(1,11)];
			for(int i = 0; i < toReturn.Length; i++)
			{
				toReturn[i] = r.Next(21);
			}
			return toReturn;
		}
		private static int Measure(int[] a, int[] b)
		{
			int Ascore = 0, Bscore = 0;
			for (int i=0; i < a.Length & i < b.Length;i++)
			{
				if (a[i] > b[i])
				{
					Ascore++;
				}
				else if (a[i] < b[i])
				{
					Bscore++;
				}
			}

			if (Ascore > Bscore)
			{
				return 1;
			}
			else if (Ascore < Bscore)
			{
				return -1;
			}
			return 0;
		}
	}
}
