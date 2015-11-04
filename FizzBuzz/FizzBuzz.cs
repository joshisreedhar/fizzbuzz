using System;

namespace FizzBuzz
{
	public class FizzBuzzGenerator
	{
		public string GetToken(int number)
		{
			Number value = new Number (number);
			if (!value.IsFizzBuzz ()) {
				return number.ToString ();
			}

			string output = "";
			if (number % 3 == 0) {
				output += "Fizz";
			}
			if (number % 5 == 0) {
				output += "Buzz";
			}
			return output;
		}
	}
}

