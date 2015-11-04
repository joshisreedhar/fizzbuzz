using System;

namespace FizzBuzz
{
	public class NonFizzBizzHandler:IFizzBizzHandler
	{
		public string GetToken(Number number)
		{
			return !number.IsFizzBuzz() ?  number.ToString() : "";
		}
	}
}

