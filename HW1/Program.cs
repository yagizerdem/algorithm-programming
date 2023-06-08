namespace ConsoleApp1
{
	internal class Program
	{
		public static double Factorial(double sayi)
		{
			double result = 1;
			for (int i = 1;i<= sayi; i++)
			{
				result *= i;
			}
			return result;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("enter iteration count");
			double userinput = Convert.ToInt32(Console.ReadLine());
			if (userinput < 1)
				return;
			Console.WriteLine("enter operation");
			string operation = Console.ReadLine();
			if (operation != "*" && operation != "/")
				return;
			Console.WriteLine("enter x");
			double x = Convert.ToInt32(Console.ReadLine());
			Console.Clear();

			double totalSum = 0;
			for (int i = 1; i <= userinput; i++)
			{
				double sum1 = 0 , sum2 = 0 , sum = 0 , altsum = 0;
				sum1 = ((4 * i) - 1) * Math.Pow(x, (3 * i) - 1);
				sum2 = Factorial(Convert.ToDouble((2 * i) + 2));
				if (sum1 < sum2)
					sum = sum1;
				else if (sum1 == sum2)
					sum = sum2;
				else
					sum = sum2;

				if (operation == "*")
					sum = sum * ((5 * i) - 3);
				if (operation == "*")
					sum = sum / ((5 * i) - 3);

				for (int j = 2*i; j <=4*i ; j+=2)
				{
					altsum += Math.Pow(j,2);
				}
				if (i % 2 == 1)
					totalSum += sum / altsum;
				else totalSum -= sum / altsum;
			}

			Console.Write(totalSum);
		
		}
	}
}