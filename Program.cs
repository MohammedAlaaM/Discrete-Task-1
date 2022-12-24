using System;
using System.Linq;

namespace Prime_Numbers
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter A Number");
			int Number1 = int.Parse(Console.ReadLine());
			for (int Number2 = 2; Number2 < Number1 / 2; Number2++)

			{
				if (Number1 % Number2 == 0)

				{
					Console.WriteLine("This Number Is Not Prime ");
					return;
				}

			}
			Console.WriteLine("This Number Is Prime");

		}
	}
}


