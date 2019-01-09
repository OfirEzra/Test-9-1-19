using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	public partial class Form1 : Form
	{
		Random r = new Random();
		int time = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			generateNumbers();
		}
		private void generateNumbers()
		{
			label1.Text = r.Next(201).ToString();
			label2.Text = r.Next(201).ToString();
			label3.Text = r.Next(201).ToString();
			label4.Text = r.Next(201).ToString();
			label5.Text = r.Next(201).ToString();
		}
		private void startButton_Click(object sender, EventArgs e)
		{
			label1.Visible = false;
			textBox1.BackColor = Color.White;
			label2.Visible = false;
			textBox2.BackColor = Color.White;
			label3.Visible = false;
			textBox3.BackColor = Color.White;
			label4.Visible = false;
			textBox4.BackColor = Color.White;
			label5.Visible = false;
			textBox5.BackColor = Color.White;
			time = 0;
			timer1.Start();
		}

		private void finishButton_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			label1.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
			label4.Visible = true;
			label5.Visible = true;

			bool won = true;
			int count = 0;
			if (int.Parse(label1.Text) == int.Parse(textBox1.Text))
			{
				count++;
			}
			else
			{
				won = false;
				textBox1.BackColor = Color.Red;
			}

			if (int.Parse(label2.Text) == int.Parse(textBox2.Text))
			{
				count++;
			}
			else
			{
				won = false;
				textBox2.BackColor = Color.Red;
			}

			if (int.Parse(label3.Text) == int.Parse(textBox3.Text))
			{
				count++;
			}
			else
			{
				won = false;
				textBox3.BackColor = Color.Red;
			}

			if (int.Parse(label4.Text) == int.Parse(textBox4.Text))
			{
				count++;
			}
			else
			{
				won = false;
				textBox4.BackColor = Color.Red;
			}

			if (int.Parse(label5.Text) == int.Parse(textBox5.Text))
			{
				count++;
			}
			else
			{
				won = false;
				textBox5.BackColor = Color.Red;
			}
			scoreList.Items.Add(count);

			if (won & time == 0)
			{
				MessageBox.Show("you won in time!", "yay", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (won)
			{
				MessageBox.Show("you won but not in time", "sort of yay", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("you lost", "nay", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox1.BackColor = Color.White;
			textBox2.BackColor = Color.White;
			textBox3.BackColor = Color.White;
			textBox4.BackColor = Color.White;
			textBox5.BackColor = Color.White;
			generateNumbers();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
				Application.Exit();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			time++;
		}
	}
}
