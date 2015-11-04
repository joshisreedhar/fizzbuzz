using System;

namespace FizzBuzz
{
	public class FizzBuzzGenerator
	{
		public string GetToken(string number)
		{
			
			int parsedNumber = 0;
			if (!int.TryParse (number, out parsedNumber)) {
				return "";
			}

			string output = "";
			if (parsedNumber % 3 == 0) {
				output += "Fizz";
			}
			if (parsedNumber % 5 == 0) {
				output += "Buzz";
			}
			if (output == "") {
				output = number;
			}

			return output;
		}
	}
}

