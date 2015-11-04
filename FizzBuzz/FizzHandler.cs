using System;

namespace FizzBuzz
{
	public class FizzHandler:IFizzBizzHandler
	{
		public string GetToken(Number number)
		{
			return number.IsFizz() ?  "Fizz" : "";
		}
	}
}

