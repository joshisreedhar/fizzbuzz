using System;

namespace FizzBuzz
{
	public class InputParser
	{
		public int Parse(string input)
		{
			int parsedNumber = 0;
			int.TryParse (input, out parsedNumber);
			return parsedNumber;
		}
	}
}

