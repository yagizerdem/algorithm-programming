using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
	internal class Program
	{
		static bool Chec(string[,] matrix) 
		{
			bool result = false;
			//lookin columns
			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				if ((matrix[0, i] != null && matrix[0, i] == "D")&& 
					(matrix[1, i] != null && matrix[1, i] == "E")&&
					(matrix[2, i] != null && matrix[2, i] == "U"))
				{
					result = true;
				}
				if ((matrix[0, i] != null && matrix[0, i] == "U") &&
					(matrix[1, i] != null && matrix[1, i] == "E") &&
					(matrix[2, i] != null && matrix[2, i] == "D"))
				{
					result = true;
				}
				//
			}
			//looking rows
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1)-2; j++)
				{
					if (matrix[i,j]=="D" && matrix[i, j+1] == "E" &&matrix[i, j + 2] == "U")
					{
						result=true;
					}
					if (matrix[i, j] == "U" && matrix[i, j + 1] == "E" && matrix[i, j + 2] == "D")
					{
						result = true;
					}
				}
			}
			// looking diagonals

				for (int j = 0; j < matrix.GetLength(1)-2; j++)
				{
					if (matrix[0,j]=="D" && matrix[1, j + 1] == "E" && matrix[2, j + 2] == "U")
					{
						result = true;
					}
					if (matrix[0, j] == "U" && matrix[1, j + 1] == "E" && matrix[2, j + 2] == "D")
					{
						result = true;
					}
				}

			for (int j = matrix.GetLength(1)-1; j >=2 ; j--)
			{
				if (matrix[0, j] == "D" && matrix[1, j - 1] == "E" && matrix[2, j - 2] == "U")
				{
					result = true;
				}
				if (matrix[0, j] == "U" && matrix[1, j - 1] == "E" && matrix[2, j - 2] == "D")
				{
					result = true;
				}
			}

			return result;
		}



		static void Main(string[] args)
		{

			string[,] matrix = new string[3, 15];
			bool flag = false;
			Random rnd = new Random();
			string[] letterarr = new string[3] {"D","E","U"};
			string winner = "";
			int counter0 = 0, counter1 = 0, counter2 = 0;
			int p1point = 120, p2point = 120;

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = " ";
				}
			}
			do
			{
				string letter = letterarr[rnd.Next(0,3)];
				int random = rnd.Next(0, 3);
				if (random == 0)
				{
					if (counter0 == 15)
						continue;
					matrix[random,counter0] = letter;
					counter0++;
				}
				if (random == 1)
				{
					if (counter1 == 15)
						continue;
					matrix[random, counter1] = letter;
					counter1++;
				}
				if (random == 2)
				{
					if (counter2 == 15)
						continue;
					matrix[random, counter2] = letter;
					counter2++;
				}
				
				flag = Program.Chec(matrix);
				if (flag)
				{
					if ((counter0 + counter1 + counter2) % 2 == 1)
						winner = "player1";
					else winner = "player2";
				}

				if((counter0 + counter1 + counter2) % 2 == 1)
				{
					p1point -= 5;
				}
                else
                {
                    p2point -= 5;
                }

				Console.WriteLine(p1point + " -- " + p2point);

				if(counter0+counter1+counter2 == 45)
				{
					break;
				}

            } while (!flag);
			Console.Clear();

			for (int i = 0; i < counter0; i++)
			{
				Console.Write(matrix[0, i]+" ");
			}
			Console.WriteLine();
			for (int i = 0; i < counter1; i++)
			{
				Console.Write(matrix[1, i]+" ");
			}
			Console.WriteLine();
			for (int i = 0; i < counter2; i++)
			{
				Console.Write(matrix[2, i]+ " ");
			}
			Console.WriteLine() ;
			Console.Write("winener is " + winner);
		}
	}
}