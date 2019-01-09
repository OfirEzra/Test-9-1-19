using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
	public partial class Form1 : Form
	{
		int[] a;
		private void Form1_Load(object sender, EventArgs e)
		{
			InitializeArrays();
			PrintArray();
		}
		private void PrintArray()
		{
			for (int i = 0; i < a.Length; i++)
			{
				//cant execute next line
				//Console.WriteLine(a[i]);
			}
		}
		private void InitializeArrays()
		{
			Random r = new Random();
			a = new int[10];
			for (int i = 0; i < 10; i++)
			{
				a[i] = r.Next(101);
			}
		}
	}
}
