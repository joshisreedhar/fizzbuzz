using System;

namespace FizzBuzz
{
	public class Number
	{
		private int value=0;
		public Number (int number)
		{
			value = number;
		}

		public bool IsFizzBuzz()
		{
			return (value % 3 == 0) || (value % 5 == 0);
		}

		public override string ToString ()
		{
			return value.ToString();
		}

		public bool IsFizz()
		{
			return value % 3 == 0;
		}

		public bool IsBizz()
		{
			return value % 5 == 0;
		}

	}
}

