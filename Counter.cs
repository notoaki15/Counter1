using System;

namespace Console3
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			Counter1 count = new Counter1();

			while (true)
			{
				Console.WriteLine(count.GetNextValue());
			}


		}

	}
	public class Counter1
	{
		private int _count;
		public int GetNextValue()
		{
			_count += 1;
			return _count;
		}
	}
}
