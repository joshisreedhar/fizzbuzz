using System;

namespace FizzBuzz
{
	public class BizzHandler:IFizzBizzHandler
	{
		public string GetToken(Number number)
		{
			return number.IsBizz() ?  "Bizz" : "";
		}
	}
}

