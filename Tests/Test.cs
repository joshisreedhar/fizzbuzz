using NUnit.Framework;
using System;
using FizzBuzz;

namespace Fizzbuzz.Tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void A_Number_Divisible_By_3_Should_Give_Fizz ()
		{
			FizzBuzzGenerator fz = new FizzBuzzGenerator ();
			string token = fz.GetToken ("9");
			Assert.AreEqual ("Fizz", token);
		}

		[Test ()]
		public void A_Number_Divisible_By_5_Should_Give_buzz ()
		{
			FizzBuzzGenerator fz = new FizzBuzzGenerator ();
			string token = fz.GetToken ("20");
			Assert.AreEqual ("Buzz", token);
		}

		[Test ()]
		public void A_Number_Not_Divisible_By_3_And_5_Should_Give_Number()
		{
			FizzBuzzGenerator fz = new FizzBuzzGenerator ();
			string token = fz.GetToken ("17");
			Assert.AreEqual ("17", token);
		}

		[Test ()]
		public void A_Number_Is_Divisible_By_3_And_5_Should_Give_FizzBuzz()
		{
			FizzBuzzGenerator fz = new FizzBuzzGenerator ();
			string token = fz.GetToken ("15");
			Assert.AreEqual ("FizzBuzz", token);
		}
	}
}

