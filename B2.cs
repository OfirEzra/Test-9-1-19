using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	class B2
	{
		static void Main(string[] args)
		{
			int[,] board;
			board = new int[,]
			{ { 1, 2 },
			{ 3, 4 },
			{ 5, 6 },
			{ 7, 8 } };
			Console.WriteLine("first case: "+WinX0(board));
			board = new int[,]
			{ { 1, 2, 3 },
			{ 3, 4, 4 },
			{ 5, 6, 5 }};
			Console.WriteLine("2nd case: " + WinX0(board));
			board = new int[,]
			{ { 1, 1, 1 },
			{ 0, 0, 0 },
			{ 0, 0, 0 }};
			Console.WriteLine("3rd case: " + WinX0(board));
			board = new int[,]
			{ { 1, 1, 1 },
			{ 1, 0, 0 },
			{ 0, 0, 1 }};
			Console.WriteLine("4th case: " + WinX0(board));
			board = new int[,]
			{ { 0, 0, 0 },
			{ 0, 1, 1 },
			{ 1, 1, 0 }};
			Console.WriteLine("5th case: " + WinX0(board));
			board = new int[,]
			{ { 0, 1, 0 },
			{ 0, 1, 0 },
			{ 1, 0, 1 }};
			Console.WriteLine("6th case: " + WinX0(board));

		}
		static int WinX0(int[,] board)
		{
			if(board.GetLength(0)!=3 | board.GetLength(1) != 3)
			{
				return -1;
			}
			else if(!checkMatrixValidity(board)){
				return -2;
			}
			else
			{
				return PlayerWon(board);
			}
		}
		static bool checkMatrixValidity(int[,] board)
		{
			for(int i = 0; i < board.GetLength(0); i++)
			{
				for(int j = 0; j < board.GetLength(1); j++)
				{
					if(board[i,j]!=0 & board[i, j] != 1)
					{
						return false;
					}
				}
			}
			return true;
		}
		static int PlayerWon(int[,] board)
		{
			bool playerOneWon = false;
			bool playerTwoWon = false;
			//check rows
			for (int i = 0; i < board.GetLength(0); i++)
			{
				int trackingPlayerOne = 0, trackingPlayerTwo = 0;
				for (int j = 0; j < board.GetLength(1); j++)
				{
					if (board[i, j] == 1)
					{
						trackingPlayerOne++;
					}
					else
					{
						trackingPlayerTwo++;
					}
				}
				if (trackingPlayerOne == 3)
				{
					playerOneWon = true;
				}
				if (trackingPlayerTwo == 3)
				{
					playerTwoWon = true;
				}
			}
			//check diagonal
			int trackPlayerOne = 0, trackPlayerTwo = 0;
			for (int i = 0; i < 3; i++)
			{
				if (board[i, i] == 1)
				{
					trackPlayerOne++;
				}
				else
				{
					trackPlayerTwo++;
				}
			}
			if (trackPlayerOne == 3)
			{
				playerOneWon = true;
			}
			if (trackPlayerTwo == 3)
			{
				playerTwoWon = true;
			}

			trackPlayerOne = 0;
			trackPlayerTwo = 0;
			for (int i = 0; i < 3; i++)
			{
				if (board[board.GetLength(0)-1-i, board.GetLength(0) - 1 - i] == 1)
				{
					trackPlayerOne++;
				}
				else
				{
					trackPlayerTwo++;
				}
			}
			if (trackPlayerOne == 3)
			{
				playerOneWon = true;
			}
			if (trackPlayerTwo == 3)
			{
				playerTwoWon = true;
			}

			//sum up
			if (playerOneWon & playerTwoWon)
			{
				return -3;
			}
			else if (playerOneWon)
			{
				return 1;
			}
			else if (playerTwoWon)
			{
				return 2;
			}
			else
			{
				return 0;
			}
		}
	}
}
