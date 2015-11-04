using System;

namespace FizzBuzz
{
	public class FizzBuzzGenerator
	{
		public string GetToken(string number)
		{
			int parsedNumber = 0;
			string output = number;
			if (int.TryParse (number, out parsedNumber)) {
				if (parsedNumber % 3 == 0) {
					output = "Fizz";
				}
				if (parsedNumber % 5 == 0) {
					output = "Buzz";
				}
			} 
			return output;
		}
	}
}

