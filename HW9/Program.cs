namespace ConsoleApp1
{
	internal class Program
	{
		
		static void Main(string[] args)
		{

			string text, pattern;
			Console.WriteLine("enter text");
			text = Console.ReadLine().ToLower();
			Console.WriteLine("enter pattern");
			pattern = Console.ReadLine().ToLower();
			Console.Clear();

			string[] words = text.Split(" ");

			if (pattern.Contains("*"))
			{

				for (int i = 0; i < words.Length; i++)
				{
					bool flag = true;
					for (int j = 0; j < pattern.Length; j++)
					{
						if (pattern[j] != '*' && !words[i].Contains(pattern[j]))
						{
							flag = false;
						}
					}
					if (flag)
						Console.WriteLine(words[i]);
				}

			}
			else
			{
				for (int i = 0; i < words.Length; i++)
				{
					bool flag = true;
					if (pattern.Length == words[i].Length)
					{
						for (int j = 0; j < pattern.Length; j++)
						{
							if (pattern[j] != '-' && !words[i].Contains(pattern[j]))
							{
								flag = false;
							}
						}
						if (flag)
							Console.WriteLine(words[i]);
					}
				}
			}




		}
	}
}