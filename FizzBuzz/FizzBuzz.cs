using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzz
{
	public class FizzBuzzGenerator
	{
		List<IFizzBizzHandler> fizzBizzHandlers = new List<IFizzBizzHandler> (){ new FizzHandler (), new BizzHandler (), new NonFizzBizzHandler() };
			
		public string GetToken(int number)
		{
			string output = "";
			Number value = new Number (number);
			foreach (IFizzBizzHandler handler in fizzBizzHandlers) {
				output += handler.GetToken (value);
			}
			return output;
		}
	}
}

