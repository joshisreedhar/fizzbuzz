using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzz
{
	public class FizzBuzzGenerator
	{
		List<IFizzBizzHandler> fizzBizzHandlers = new List<IFizzBizzHandler> (){ new FizzHandler (), new BizzHandler () };
			
		public string GetToken(int number)
		{
			Number value = new Number (number);
			if (!value.IsFizzBuzz ()) {
				return number.ToString ();
			}
				
			string output = "";
			foreach (IFizzBizzHandler handler in fizzBizzHandlers) {
				output += handler.GetToken (value);
			}
			return output;
		}
	}
}

